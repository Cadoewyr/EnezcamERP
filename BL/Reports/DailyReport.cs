using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace BL.Report
{
    public class DailyReport
    {
        public DailyReport(ReportType reportType, DateTime date, decimal outgoing)
        {
            _reportType = reportType;
            _date = date;
            _outgoing = outgoing;

            if (reportType == ReportType.Production)
                Orders.AddRange(producedOrdersDB.GetAll(x => x.ProducedDate.Date == date).Select(x => x.OrderDetail.Order).ToArray());
            else if (reportType == ReportType.Sales)
                Orders.AddRange(ordersDB.GetAll(x => x.IssueDate.Date == date));
        }

        OrderRepository ordersDB = new();
        ProducedOrdersRepository producedOrdersDB = new();

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

        private ReportType _reportType;
        public ReportType ReportType
        {
            get => _reportType;
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public List<Order> Orders { get; set; } = [];

        public decimal Cost
        {
            get => Orders.Sum(x => x.Cost);
        }
        public decimal CostTax
        {
            get => Orders.Sum(x => x.CostTax);
        }
        public decimal CostWithTax
        {
            get => Cost + CostTax;
        }
        public decimal Price
        {
            get => Orders.Sum(x => x.Price);
        }
        public decimal PriceTax
        {
            get => Orders.Sum(x => x.PriceTax);
        }
        public decimal PriceWithTax
        {
            get => Price + PriceTax;
        }
        public decimal Profit
        {
            get => Orders.Sum(x => x.Profit);
        }
        public decimal ProfitWithoutOutgoing
        {
            get => Profit - Outgoing;
        }
        public decimal ProfitRatio
        {
            get => Profit / Price;
        }
    }
}
