using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace BL.Reports
{
    public class DailyProductionReport
    {
        public DailyProductionReport(DateTime date, decimal outgoing)
        {
            _date = date.Date;
            _outgoing = outgoing;

            ProducedOrders.AddRange(producedOrdersDB.GetAll(x => x.ProducedDate.Date == date.Date));

            ProducedOrders = MergeOrders(ProducedOrders);
            CreateEntries(ProducedOrders);
        }

        ProducedOrdersRepository producedOrdersDB = new();
        OrderDetailsRepository orderDetailsDB = new();

        void CreateEntries(IEnumerable<ProducedOrder> producedOrders)
        {
            foreach (var item in producedOrders)
            {
                DailyProductionEntries.Add(new()
                {
                    IssueDate = item.OrderDetail.Order.IssueDate.Date,
                    CustomerName = item.OrderDetail.Order.Customer.Name,
                    JobNo = item.OrderDetail.Order.JobNo,
                    ProductType = item.OrderDetail.Product.Type,
                    UnitCode = item.OrderDetail.UnitCode,
                    ProductName = item.OrderDetail.Product.Name,
                    UnitCost = item.OrderDetail.UnitCost,
                    UnitPrice = item.OrderDetail.UnitPrice,
                    Quantity = item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity)
                });
            }
        }
        List<ProducedOrder> MergeOrders(List<ProducedOrder> producedOrders)
        {
            List<ProducedOrder> mergedProducedOrders = [];

            for (int i = 0; i < producedOrders.Count(); i++)
            {
                var currentProducedOrder = producedOrders[i];

                if (mergedProducedOrders.Any(x => x.OrderDetail.ID == currentProducedOrder.OrderDetail.ID))
                {
                    var producedOrder = mergedProducedOrders.Where(x => x.OrderDetail.ID == currentProducedOrder.OrderDetail.ID).First();
                    producedOrder.ProducedOrderQuantity += currentProducedOrder.ProducedOrderQuantity;
                }
                else
                    mergedProducedOrders.Add(currentProducedOrder);
            }

            return mergedProducedOrders.ToList();
        }

        private decimal _outgoing;
        public decimal Outgoing
        {
            get => _outgoing;
        }

        public ReportInterval Interval
        {
            get => ReportInterval.Daily;
        }
        public ReportType Type
        {
            get => ReportType.Production;
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        List<ProducedOrder> ProducedOrders { get; set; } = [];
        public List<DailyProductionEntry> DailyProductionEntries { get; set; } = [];

        public decimal GetCustomerTotal(int jobNo)
        {
            return DailyProductionEntries.Where(x => x.JobNo == jobNo).Sum(x => x.Price);
        }
    }
}
