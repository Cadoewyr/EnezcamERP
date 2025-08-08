using BL.Report.Enums;
using BL.Reports.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.ProductionReports
{
    public class DateRangedProductionReport : IDateRangedReport
    {
        public DateRangedProductionReport(DateTime date, IEnumerable<Order> orders, ReportInterval interval, decimal outgoing, bool calculateAllInterval, bool isOvertime)
        {
            _interval = interval;
            _outgoing = outgoing;
            _calculateAllInterval = calculateAllInterval;
            _IsOvertime = isOvertime;
            _orders = orders;

            SetDateRange(date, interval);
            CreateReport();
        }

        DateTime GetWeekStart(DateTime date)
        {
            // Pazartesi başlangıçlı hafta: Pazar (0) için 6 gün geri git
            int dow = (int)date.DayOfWeek; // Sunday=0 ... Saturday=6
            int diff = (7 + (dow - 1)) % 7; // Mon=0, Tue=1, ... Sun=6
            return date.Date.AddDays(-diff);
        }
        DateTime GetWeekEnd(DateTime date)
        {
            return GetWeekStart(date).AddDays(7).AddTicks(-1);
        }
        DateTime GetMonthStart(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }
        DateTime GetMonthEnd(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).AddMonths(1).AddTicks(-1);
        }
        DateTime GetYearStart(DateTime date)
        {
            return new DateTime(date.Year, 1, 1);
        }
        DateTime GetYearEnd(DateTime date)
        {
            return new DateTime(date.Year, 1, 1).AddYears(1).AddTicks(-1);
        }

        IEnumerable<Order> _orders;

        DateTime _dateRangeStart, _dateRangeEnd;
        public DateTime DateRangeStart => _dateRangeStart;
        public DateTime DateRangeEnd => _dateRangeEnd;

        decimal _outgoing;
        List<MonthlyOutgoing> _monthlyOutgoings;

        bool _calculateAllInterval;
        bool _IsOvertime;

        ReportInterval _interval;
        public ReportInterval Interval => _interval;

        void CreateReport()
        {
            DailyProductionReports.Clear();

            DateTime date = DateRangeStart;

            _monthlyOutgoings = new MonthlyOutgoingsRepository().GetAll(x => (x.Year >= DateRangeStart.Year && x.Month >= DateRangeStart.Month) & (x.Year <= DateRangeEnd.Year && x.Month <= DateRangeEnd.Month)).ToList();

            if (_interval == ReportInterval.Daily)
            {
                decimal outgoing = _IsOvertime ? (new OvertimeOutgoingsRepository().GetAll(x => x.Date.Date == date.Date).FirstOrDefault() != null ? new OvertimeOutgoingsRepository().GetAll(x => x.Date.Date == date.Date).FirstOrDefault().Outgoing : 0) : _monthlyOutgoings.Where(x => x.Month == date.Month & x.Year == date.Year).FirstOrDefault().Outgoing;
                DailyProductionReports.Add(new(date, _orders, outgoing, _IsOvertime));
            }
            else
            {
                var producedOrdersRepo = new ProducedOrdersRepository();
                var monthlyOutRepo = new MonthlyOutgoingsRepository();
                var overtimeOutRepo = new OvertimeOutgoingsRepository();

                while (date <= DateRangeEnd)
                {
                    bool isWeekday = (int)date.DayOfWeek >= 1 && (int)date.DayOfWeek <= 5; // Pazartesi–Cuma
                    bool isWithinDateRange = date.Date <= (_calculateAllInterval ? _dateRangeEnd.Date : DateTime.Now.Date);

                    bool hasNormal = producedOrdersRepo
                        .GetAll(x => x.ProducedDate.Date == date.Date && !x.IsStock && !x.IsOvertime)
                        .Any();

                    bool hasOvertime = producedOrdersRepo
                        .GetAll(x => x.ProducedDate.Date == date.Date && !x.IsStock && x.IsOvertime)
                        .Any();

                    if (isWeekday || (!isWeekday && hasNormal))
                    {
                        var mo = monthlyOutRepo
                            .GetAll(x => x.Month == date.Month && x.Year == date.Year)
                            .FirstOrDefault();

                        bool shouldApplyOutgoing = isWithinDateRange && (isWeekday || (!isWeekday && hasNormal));
                        decimal normalOutgoing = shouldApplyOutgoing ? (mo?.Outgoing ?? 0) : 0;

                        DailyProductionReports.Add(new(date, _orders, normalOutgoing, false));
                    }

                    if (hasOvertime)
                    {
                        var overtime = overtimeOutRepo
                            .GetAll(x => x.Date.Date == date.Date)
                            .FirstOrDefault();

                        decimal overtimeOutgoing = overtime?.Outgoing ?? 0;

                        DailyProductionReports.Add(new(date, _orders, overtimeOutgoing, true));
                    }

                    date = date.AddDays(1);
                }
            }
        }

        void SetDateRange(DateTime date, ReportInterval interval)
        {
            switch (interval)
            {
                case ReportInterval.Daily:
                    _dateRangeStart = date.Date;
                    _dateRangeEnd = date.Date.AddDays(1).AddTicks(-1);
                    break;
                case ReportInterval.Weekly:
                    _dateRangeStart = GetWeekStart(date);
                    _dateRangeEnd = GetWeekEnd(date);
                    break;
                case ReportInterval.Monthly:
                    _dateRangeStart = GetMonthStart(date);
                    _dateRangeEnd = GetMonthEnd(date);
                    break;
                case ReportInterval.Yearly:
                    _dateRangeStart = GetYearStart(date);
                    _dateRangeEnd = GetYearEnd(date);
                    break;
            }
        }

        public List<DailyProductionReport> DailyProductionReports { get; set; } = [];

        public string GetProducedQuantityString()
        {
            return $"{ProducedQuantity.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {ProducedQuantity.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }
        public string GetProcessedQuantityString()
        {
            return $"{ProcessedQuantity.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {ProcessedQuantity.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }
        public string GetStockQuantityString()
        {
            return $"{StockQuantity.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {StockQuantity.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }
        public string GetSpecQuantityString(Dictionary<UnitCode, decimal> dic)
        {
            return $"{dic.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {dic.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }

        //Calculation properties
        #region
        public Dictionary<UnitCode, decimal> ProducedQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, DailyProductionReports.Sum(x => x.ProducedQuantity.Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
                dic.Add(UnitCode.M2, DailyProductionReports.Sum(x => x.ProducedQuantity.Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> ProcessedQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, DailyProductionReports.Sum(x => x.ProcessedQuantity.Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
                dic.Add(UnitCode.M2, DailyProductionReports.Sum(x => x.ProcessedQuantity.Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> StockQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, DailyProductionReports.Sum(x => x.StockQuantity.Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
                dic.Add(UnitCode.M2, DailyProductionReports.Sum(x => x.StockQuantity.Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> GetSpecQuantity(Spec spec, ProductionType productionType)
        {
            Dictionary<UnitCode, decimal> dic = [];

            dic.Add(UnitCode.AD, DailyProductionReports.Sum(x => x.GetSpecQuantity(spec, productionType).Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
            dic.Add(UnitCode.M2, DailyProductionReports.Sum(x => x.GetSpecQuantity(spec, productionType).Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

            return dic;
        }
        public decimal Price => DailyProductionReports.Sum(x => x.Price);
        public decimal PriceTax => DailyProductionReports.Sum(x => x.PriceTax);
        public decimal PriceWithTax => Price + PriceTax;
        public decimal Cost => DailyProductionReports.Sum(x => x.Cost);
        public decimal CostTax => DailyProductionReports.Sum(x => x.CostTax);
        public decimal CostWithTax => Cost + CostTax;
        public decimal Profit => DailyProductionReports.Sum(x => x.Profit);
        public decimal ProfitRatio => Price > 0 & Cost > 0 ? (Price - Cost) / Cost : 0;
        public decimal ProfitMargin => Price > 0 & Cost > 0 ? (Price - Cost) / Price : 0;
        public decimal Outgoing => DailyProductionReports.Sum(x => x.Outgoing);
        public decimal CostWithOutgoing => DailyProductionReports.Sum(x => x.CostWithOutgoing);
        public decimal ProfitWithoutOutgoing => Profit - Outgoing;
        public decimal ProfitRatioAfterOutgoing => Price == 0 & CostWithOutgoing == 0 ? 0 : ((Price - CostWithOutgoing) / CostWithOutgoing);
        #endregion
    }
}
