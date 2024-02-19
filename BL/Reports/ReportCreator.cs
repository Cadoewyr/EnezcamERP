namespace BL.Reports
{
    public class ReportCreator
    {
        public static DailyProductionReport Create(DateTime date, decimal outgoing)
        {
            DailyProductionReport report = new(date, outgoing);
            return report;
        }
    }
}
