using BL.Report.Enums;
using BL.Reports.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.ProductionReports
{
    public class DateRangedProductionReport : IDateRangedReport
    {
        public DateRangedProductionReport(DateTime date, ReportInterval interval, decimal outgoing, bool calculateAllInterval, bool isOvertime)
        {
            _interval = interval;
            _outgoing = outgoing;
            _calculateAllInterval = calculateAllInterval;
            _IsOvertime = isOvertime;

            SetDateRange(date, interval);
            CreateReport();
        }

        DateTime GetWeekStart(DateTime date)
        {
            return date.Date.AddDays(-(int)date.Date.DayOfWeek + 1);
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
            return new DateTime(date.Year, date.Month + 1, 1).AddTicks(-1);
        }
        DateTime GetYearStart(DateTime date)
        {
            return new DateTime(date.Year, 1, 1);
        }
        DateTime GetYearEnd(DateTime date)
        {
            return new DateTime(date.Year + 1, 1, 1).AddTicks(-1);
        }

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

            _monthlyOutgoings = new MonthlyOutgoingsRepository().GetAll(x => (x.Year >= DateRangeStart.Year & x.Month >= DateRangeStart.Month) & (x.Year <= DateRangeEnd.Year & x.Month <= DateRangeEnd.Month)).ToList();

            if(_interval == ReportInterval.Daily)
            {
                decimal outgoing = _IsOvertime ? (new OvertimeOutgoingsRepository().GetAll(x => x.Date.Date == date.Date).FirstOrDefault() != null ? new OvertimeOutgoingsRepository().GetAll(x => x.Date.Date == date.Date).FirstOrDefault().Outgoing : 0) : _monthlyOutgoings.Where(x => x.Month == date.Month & x.Year == date.Year).FirstOrDefault().Outgoing;
                DailyProductionReports.Add(new(date, outgoing, _IsOvertime));
            }
            else
            {
                while (date <= DateRangeEnd)
                {
                    //check conditions
                    if (new ProducedOrdersRepository().GetAll(x => x.ProducedDate.Date == date.Date & !x.IsOvertime).Count() > 0 || (int)date.DayOfWeek >= 1 & (int)date.DayOfWeek <= 5)
                    {
                        DailyProductionReports.Add(new(date, (new ProducedOrdersRepository().GetAll(x => x.ProducedDate.Date == date.Date & !x.IsOvertime).Count() > 0 || (int)date.DayOfWeek >= 1 & (int)date.DayOfWeek <= 5) && date.Date <= (_calculateAllInterval ? _dateRangeEnd : DateTime.Now.Date) ? (_interval == ReportInterval.Yearly ? _monthlyOutgoings.Where(x => x.Year == date.Year & x.Month >= date.Month).FirstOrDefault().Outgoing : _outgoing) : 0, false));
                    }

                    if (new ProducedOrdersRepository().GetAll(x => x.ProducedDate.Date == date.Date & x.IsOvertime).Count() > 0)
                    {
                        OvertimeOutgoing overtimeOutgoing = new OvertimeOutgoingsRepository().GetAll(x => x.Date.Date == date.Date).FirstOrDefault();
                        var outgoing = overtimeOutgoing != null ? overtimeOutgoing.Outgoing : 0;

                        DailyProductionReports.Add(new(date, outgoing, true));
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
