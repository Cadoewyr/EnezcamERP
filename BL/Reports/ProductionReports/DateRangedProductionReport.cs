using BL.Report.Enums;
using BL.Reports.Enums;

namespace BL.Reports.ProductionReports
{
    public class DateRangedProductionReport : IDateRangedReport
    {
        public DateRangedProductionReport(DateTime date, ReportInterval interval, decimal outgoing)
        {
            _interval = interval;
            _outgoing = outgoing;

            SetDateRange(date, interval);
            CreateReport();
        }

        DateTime GetWeekStart(DateTime date)
        {
            return date.Date.AddDays(-(int)date.Date.DayOfWeek + 1);
        }
        DateTime GetWeekEnd(DateTime date)
        {
            return GetWeekStart(date).AddDays(5).AddTicks(-1);
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

        ReportInterval _interval;
        public ReportInterval Interval => _interval;

        void CreateReport()
        {
            DailyProductionReports.Clear();

            DateTime date = DateRangeStart;

            while (date <= DateRangeEnd)
            {
                DailyProductionReports.Add(new(date, ((int)date.DayOfWeek > 0 & (int)date.DayOfWeek <= 5) ? _outgoing : 0));
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

        public List<DailyProductionReport> DailyProductionReports { get; set; } = [];

        //Calculation properties
        #region
        public decimal Price => DailyProductionReports.Sum(x => x.Price);
        public decimal Cost => DailyProductionReports.Sum(x => x.Cost);
        public decimal Profit => DailyProductionReports.Sum(x => x.Profit);
        public decimal ProfitRatio => ((Price - Cost) / Cost);
        public decimal Outgoing => DailyProductionReports.Sum(x => x.Outgoing);
        public decimal CostWithOutgoing => DailyProductionReports.Sum(x => x.CostWithOutgoing);
        public decimal ProfitRatioAfterOutgoing => ((Price - CostWithOutgoing) / CostWithOutgoing);
        #endregion
    }
}
