using BL.Report;
using BL.Report.Enums;

namespace BL.Reports
{
    public class ReportCreator
    {
        public static DailyReport CreateDailyReport(ReportType type, DateTime date, decimal outgoing)
        {
            DailyReport report = new(type, date, outgoing);
            return report;
        }
    }
}
