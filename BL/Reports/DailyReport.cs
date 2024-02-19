using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace BL.Report
{
    public class DailySalesReport
    {
        public DailySalesReport(DateTime date, decimal outgoing)
        {
            _date = date;
            _outgoing = outgoing;

            OrderDetails.AddRange(orderDetailsDB.GetAll(x => x.Order.IssueDate.Date == date.Date));
        }

        OrderDetailsRepository orderDetailsDB = new();

        private decimal _outgoing;
        public decimal Outgoing
        {
            get => _outgoing;
        }

        private ReportInterval _reportInterval;
        public ReportInterval Interval
        {
            get => _reportInterval;
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        List<OrderDetail> OrderDetails { get; set; } = [];
    }
}
