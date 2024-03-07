using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace BL.Reports.ProductionReports
{
    public class DailyProductionReport
    {
        public DailyProductionReport(DateTime date, decimal outgoing)
        {
            _date = date.Date;
            _outgoing = outgoing;

            ProducedOrders.AddRange(producedOrdersDB.GetAll(x => x.ProducedDate.Date == date.Date && !x.IsStock));

            ProducedOrders = MergeOrders(ProducedOrders);
            CreateEntries(ProducedOrders);
        }

        ProducedOrdersRepository producedOrdersDB = new();

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
                    DiscountRatio = item.OrderDetail.DiscountRatio,
                    Quantity = item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date && !x.IsStock).Sum(x => x.ProducedOrderQuantity)
                });
            }
            DailyProductionEntries = DailyProductionEntries.OrderBy(x => x.JobNo).ToList();
        }
        List<ProducedOrder> MergeOrders(List<ProducedOrder> producedOrders)
        {
            List<ProducedOrder> mergedProducedOrders = [];

            for (int i = 0; i < producedOrders.Count(); i++)
            {
                var currentProducedOrder = producedOrders[i] with { };

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

        decimal _outgoing;
        public decimal Outgoing => _outgoing;

        public ReportInterval Interval => ReportInterval.Daily;
        public ReportType Type => ReportType.Production;

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
            return DailyProductionEntries.Where(x => x.JobNo == jobNo).Sum(x => x.FinalPrice);
        }

        //Calculation properties
        #region
        public decimal Price => DailyProductionEntries.Sum(x => x.FinalPrice);
        public decimal PriceTax => Price > 0 ? (Price / 100) * 20 : 0;
        public decimal PriceWithTax => Price + PriceTax;
        public decimal Cost => DailyProductionEntries.Sum(x => x.Cost);
        public decimal CostTax => Cost > 0 ? (Cost / 100) * 20 : 0;
        public decimal CostWithTax => Cost + CostTax;
        public decimal Profit => DailyProductionEntries.Sum(x => x.Profit);
        public decimal ProfitWithoutOutgoing => Profit - Outgoing;
        public decimal ProfitRatio => Price > 0 & Cost > 0 ? ((Price - Cost) / Cost) : 0;
        public decimal ProfitMargin => Price > 0 & Cost > 0 ? ((Price - Cost) / Price) : 0;
        public decimal CostWithOutgoing => Outgoing + Cost;
        public decimal WithoutOutgoing => Cost - Outgoing;
        public decimal ProfitRatioWithOutgoing => Price > 0 & CostWithOutgoing > 0 ? ((Price - CostWithOutgoing) / CostWithOutgoing) : 0;
        public decimal CustomProfitRatio => Profit > 0 & Price > 0 ? Profit / Price : 0;
        #endregion
    }
}
