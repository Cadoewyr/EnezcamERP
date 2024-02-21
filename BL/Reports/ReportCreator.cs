using BL.Report.Enums;
using BL.Reports.ProductionReports;

namespace BL.Reports
{
    public class ReportCreator
    {
        public static DateRangedProductionReport Create(DateTime date, ReportInterval interval, decimal outgoing)
        {
            return new(date, interval, outgoing);
        }
    }
}
