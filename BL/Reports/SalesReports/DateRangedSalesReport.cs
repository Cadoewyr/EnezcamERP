using BL.Report.Enums;
using BL.Reports.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.SalesReports
{
    public class DateRangedSalesReport : IDateRangedReport
    {
        public DateRangedSalesReport(DateTime date, ReportInterval interval, decimal outgoing, bool calculateAllInterval)
        {
            _interval = interval;
            _outgoing = outgoing;
            _calculateAllInterval = calculateAllInterval;

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

        DateTime _dateRangeStart, _dateRangeEnd;
        public DateTime DateRangeStart => _dateRangeStart;
        public DateTime DateRangeEnd => _dateRangeEnd;

        decimal _outgoing;
        List<MonthlyOutgoing> _monthlyOutgoings;

        bool _calculateAllInterval;

        ReportInterval _interval;
        public ReportInterval Interval => _interval;

        void CreateReport()
        {
            DailySalesReports.Clear();

            DateTime date = DateRangeStart;

            _monthlyOutgoings = new MonthlyOutgoingsRepository().GetAll(x => (x.Year >= DateRangeStart.Year & x.Month >= DateRangeStart.Month) & (x.Year <= DateRangeEnd.Year & x.Month <= DateRangeEnd.Month)).ToList();

            while (date <= DateRangeEnd)
            {
                if (new OrderRepository().GetAll(x => x.IssueDate.Date == date.Date).Count() > 0 || (int)date.DayOfWeek >= 1 & (int)date.DayOfWeek <= 5)
                {
                    bool hasSoldOrders = new OrderRepository().GetAll(x => x.IssueDate.Date == date.Date).Count() > 0;
                    bool isWeekday = (int)date.DayOfWeek >= 1 & (int)date.DayOfWeek <= 5;
                    bool isWithinDateRange = date.Date <= (_calculateAllInterval ? _dateRangeEnd : DateTime.Now.Date);
                    bool isYearlyReport = _interval == ReportInterval.Yearly;

                    decimal res = (hasSoldOrders || isWeekday) && isWithinDateRange ?
                                new MonthlyOutgoingsRepository().GetAll(x => x.Month == date.Month && x.Year == date.Year).FirstOrDefault().Outgoing //haftaiçi üretim varsa, rapor yıllık raporsa 
                                : 0;

                    DailySalesReports.Add(new(date, res));
                }

                if (new ProducedOrdersRepository().GetAll(x => x.ProducedDate.Date == date.Date & x.IsOvertime).Count() > 0)
                {
                    OvertimeOutgoing overtimeOutgoing = new OvertimeOutgoingsRepository().GetAll(x => x.Date.Date == date.Date).FirstOrDefault();
                    var outgoing = overtimeOutgoing != null ? overtimeOutgoing.Outgoing : 0;

                    DailySalesReports.Add(new(date, outgoing));
                }

                date = date.AddDays(1);
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

        public List<DailySalesReport> DailySalesReports { get; set; } = [];

        public string GetProduceQuantityString()
        {
            return $"{ProduceQuantity.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {ProduceQuantity.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }
        public string GetProcessQuantityString()
        {
            return $"{ProcessQuantity.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {ProcessQuantity.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }

        //Calculation properties
        #region
        public Dictionary<UnitCode, decimal> ProduceQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, DailySalesReports.Sum(x => x.ProduceQuantity.Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
                dic.Add(UnitCode.M2, DailySalesReports.Sum(x => x.ProduceQuantity.Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> ProcessQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, DailySalesReports.Sum(x => x.ProcessQuantity.Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
                dic.Add(UnitCode.M2, DailySalesReports.Sum(x => x.ProcessQuantity.Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> GetSpecQuantity(Spec spec, ProductionType productionType)
        {
            Dictionary<UnitCode, decimal> dic = [];

            dic.Add(UnitCode.AD, DailySalesReports.Sum(x => x.GetSpecQuantity(spec, productionType).Where(x => x.Key == UnitCode.AD).Sum(x => x.Value)));
            dic.Add(UnitCode.M2, DailySalesReports.Sum(x => x.GetSpecQuantity(spec, productionType).Where(x => x.Key == UnitCode.M2).Sum(x => x.Value)));

            return dic;
        }
        public string GetSpecQuantityString(Dictionary<UnitCode, decimal> dic)
        {
            return $"{dic.Where(x => x.Key == UnitCode.AD).First().Value.ToString("N0")} {UnitCode.AD}, {dic.Where(x => x.Key == UnitCode.M2).First().Value.ToString("N3")} {UnitCode.M2}";
        }
        public decimal Price => DailySalesReports.Sum(x => x.Price);
        public decimal PriceTax => DailySalesReports.Sum(x => x.PriceTax);
        public decimal PriceWithTax => Price + PriceTax;
        public decimal Cost => DailySalesReports.Sum(x => x.Cost);
        public decimal CostTax => DailySalesReports.Sum(x => x.CostTax);
        public decimal CostWithTax => Cost + CostTax;
        public decimal Profit => DailySalesReports.Sum(x => x.Profit);
        public decimal ProfitRatio => Price > 0 & Cost > 0 ? (Price - Cost) / Cost : 0;
        public decimal ProfitMargin => Price > 0 & Cost > 0 ? (Price - Cost) / Price : 0;
        public decimal Outgoing => DailySalesReports.Sum(x => x.Outgoing);
        public decimal CostWithOutgoing => DailySalesReports.Sum(x => x.CostWithOutgoing);
        public decimal ProfitWithoutOutgoing => Profit - Outgoing;
        public decimal ProfitRatioAfterOutgoing => Price == 0 & CostWithOutgoing == 0 ? 0 : ((Price - CostWithOutgoing) / CostWithOutgoing);
        #endregion
    }
}
