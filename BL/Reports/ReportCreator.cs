using BL.Report.Enums;
using BL.Reports.Enums;
using BL.Reports.ProductionReports;
using BL.Reports.SalesReports;

namespace BL.Reports
{
    public class ReportCreator<T> where T : class, IDateRangedReport
    {
        public static IDateRangedReport Create(DateTime date, ReportInterval interval, decimal outgoing, decimal[]? monthlyOutgoings, bool calculateAllInterval)
        {
            IDateRangedReport report = null;

            if (typeof(T) == typeof(DateRangedProductionReport))
                report = new DateRangedProductionReport(date, interval, outgoing, monthlyOutgoings, calculateAllInterval);
            else if (typeof(T) == typeof(DateRangedSalesReport))
                report = new DateRangedSalesReport(date, interval, outgoing, monthlyOutgoings, calculateAllInterval);

            return report;
        }
    }
}
