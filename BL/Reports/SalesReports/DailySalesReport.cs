using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.SalesReports
{
    public class DailySalesReport
    {
        public DailySalesReport(DateTime date, decimal outgoing)
        {
            if (date == null | outgoing == null)
                throw new ArgumentNullException("null");

            _date = date.Date;
            _outgoing = outgoing;

            OrderDetails.AddRange(orderDetailsDB.GetAll(x => x.Order.IssueDate.Date == date.Date));

            CreateEntries(OrderDetails);
        }

        OrderDetailsRepository orderDetailsDB = new();

        void CreateEntries(IEnumerable<OrderDetail> orderDetails)
        {
            foreach (var item in orderDetails)
            {
                DailySalesEntry entry = null;

                if (DailySalesEntries.Any(x =>
                    x.JobNo == item.Order.JobNo &
                    x.ProductType == item.Product.Type &
                    x.UnitPrice == item.UnitPrice &
                    x.UnitCost == item.UnitCost &
                    x.UnitCode == item.UnitCode &
                    x.DiscountRatio == item.DiscountRatio &
                    x.TaxRatio == item.TaxRatio &
                    x.FinalUnitPrice == item.FinalUnitPrice &
                    x.DiscountRatio == item.DiscountRatio &
                    x.Product.ID == item.Product.ID
                ))
                    entry = DailySalesEntries.First(x =>
                    x.JobNo == item.Order.JobNo &
                    x.ProductType == item.Product.Type &
                    x.UnitPrice == item.UnitPrice &
                    x.UnitCost == item.UnitCost &
                    x.UnitCode == item.UnitCode &
                    x.DiscountRatio == item.DiscountRatio &
                    x.TaxRatio == item.TaxRatio &
                    x.FinalUnitPrice == item.FinalUnitPrice &
                    x.DiscountRatio == item.DiscountRatio &
                    x.Product.ID == item.Product.ID
                );

                if (entry != null)
                    entry.Quantity += item.UnitCode == UnitCode.AD ? item.Quantity : item.TotalArea;
                else
                {
                    DailySalesEntries.Add(new()
                    {
                        Product = item.Product,
                        IssueDate = item.Order.IssueDate.Date,
                        TaxRatio = item.TaxRatio,
                        CustomerName = item.Order.Customer.Name,
                        JobNo = item.Order.JobNo,
                        ProductType = item.Product.Type,
                        UnitCode = item.UnitCode,
                        ProductName = item.Product.Name,
                        UnitCost = item.UnitCost,
                        UnitPrice = item.UnitPrice,
                        DiscountRatio = item.DiscountRatio,
                        Quantity = item.UnitCode == UnitCode.AD ? item.Quantity : item.TotalArea
                    });
                }
            }
            DailySalesEntries = DailySalesEntries.OrderBy(x => x.JobNo).ThenByDescending(x => x.Product.IsCounting).ToList();
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

        List<OrderDetail> OrderDetails { get; set; } = [];
        public List<DailySalesEntry> DailySalesEntries { get; set; } = [];

        public decimal GetCustomerTotal(int jobNo)
        {
            return DailySalesEntries.Where(x => x.JobNo == jobNo).Sum(x => x.FinalPrice);
        }

        //Calculation properties
        #region
        public Dictionary<UnitCode, decimal> ProduceQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, OrderDetails.Where(x => x.Product.Type == ProcessType.ISICAM & x.Product.IsCounting).Sum(x => x.Quantity));
                dic.Add(UnitCode.M2, OrderDetails.Where(x => x.Product.Type == ProcessType.ISICAM & x.Product.IsCounting).Sum(x => x.TotalArea));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> ProcessQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, OrderDetails.Where(x => x.Product.Type == ProcessType.İŞLEME & x.Product.IsCounting).Sum(x => x.Quantity));
                dic.Add(UnitCode.M2, OrderDetails.Where(x => x.Product.Type == ProcessType.İŞLEME & x.Product.IsCounting).Sum(x => x.TotalArea));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> GetSpecQuantity(Spec spec, ProductionType productionType)
        {
            Dictionary<UnitCode, decimal> dic = [];

            switch (productionType)
            {
                case ProductionType.Produced:
                    dic.Add(UnitCode.AD, OrderDetails.Where(x => x.Product.Type == ProcessType.ISICAM & x.Product.IsCounting & x.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.Quantity));
                    dic.Add(UnitCode.M2, OrderDetails.Where(x => x.Product.Type == ProcessType.ISICAM & x.Product.IsCounting & x.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.TotalArea));
                    break;
                case ProductionType.Processed:
                    dic.Add(UnitCode.AD, OrderDetails.Where(x => x.Product.Type == ProcessType.İŞLEME & x.Product.IsCounting & x.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.Quantity));
                    dic.Add(UnitCode.M2, OrderDetails.Where(x => x.Product.Type == ProcessType.İŞLEME & x.Product.IsCounting & x.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.TotalArea));
                    break;
            }

            return dic;
        }
        public decimal Price => DailySalesEntries.Sum(x => x.FinalPrice);
        public decimal PriceTax => Price > 0 ? DailySalesEntries.Sum(x => x.FinalPrice * (x.TaxRatio / 100)) : 0;
        public decimal PriceWithTax => Price + PriceTax;
        public decimal Cost => DailySalesEntries.Sum(x => x.Cost);
        public decimal CostTax => Cost > 0 ? (Cost / 100) * 20 : 0;
        public decimal CostWithTax => Cost + CostTax;
        public decimal Profit => DailySalesEntries.Sum(x => x.Profit);
        public decimal ProfitWithoutOutgoing => Profit - Outgoing;
        public decimal ProfitRatio => Price > 0 & Cost > 0 ? ((Price - Cost) / Cost) : 0;
        public decimal ProfitMargin => Price > 0 & Cost > 0 ? ((Price - Cost) / Price) : 0;
        public decimal CostWithOutgoing => Outgoing + Cost;
        public decimal WithoutOutgoing => Cost - Outgoing;
        public decimal ProfitRatioWithOutgoing => Price == 0 & CostWithOutgoing == 0 ? 0 : ((Price - CostWithOutgoing) / CostWithOutgoing);
        #endregion
    }
}
