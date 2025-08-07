using BL.Report.Enums;
using BL.Reports.Enums;
using BL.Reports.ProductionReports;
using BL.Reports.SalesReports;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace BL.Reports
{
    public class ReportCreator<T> where T : class, IDateRangedReport
    {
        public static IDateRangedReport Create(DateTime date, ReportInterval interval, decimal outgoing, bool calculateAllInterval, bool IsOvertime)
        {
            IDateRangedReport report = null;

            if (typeof(T) == typeof(DateRangedProductionReport))
                report = new DateRangedProductionReport(date, null, interval, outgoing, calculateAllInterval, IsOvertime);
            else if (typeof(T) == typeof(DateRangedSalesReport))
                report = new DateRangedSalesReport(date, null, interval, outgoing, calculateAllInterval);

            return report;
        }

        public static IDateRangedReport CreateCustomReport(DateTime date, IEnumerable<Order> orders, ReportInterval interval, decimal outgoing, bool calculateAllInterval, bool IsOvertime)
        {
            IDateRangedReport report = null;

            if (typeof(T) == typeof(DateRangedProductionReport))
                report = new DateRangedProductionReport(date, orders, interval, outgoing, calculateAllInterval, IsOvertime);
            else if (typeof(T) == typeof(DateRangedSalesReport))
                report = new DateRangedSalesReport(date, orders, interval, outgoing, calculateAllInterval);

            return report;
        }
    }
}
