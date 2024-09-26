using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.ProductionReports
{
    public class DailyProductionReport
    {
        public DailyProductionReport(DateTime date, decimal outgoing, bool IsOvertime)
        {
            _date = date.Date;
            _outgoing = outgoing;
            _IsOvertime = IsOvertime;

            ProducedOrders.AddRange(producedOrdersDB.GetAll(x => x.ProducedDate.Date == date.Date & !x.IsStock & x.IsOvertime == _IsOvertime));

            ProducedOrders = MergeProducedOrders(ProducedOrders);
            CreateEntries(ProducedOrders);
        }

        ProducedOrdersRepository producedOrdersDB = new();

        void CreateEntries(IEnumerable<ProducedOrder> producedOrders)
        {
            foreach (var item in producedOrders)
            {
                DailyProductionEntry entry = null;

                if (DailyProductionEntries.Any(x =>
                    x.JobNo == item.OrderDetail.Order.JobNo &
                    x.ProductType == item.OrderDetail.Product.Type &
                    x.UnitPrice == item.OrderDetail.UnitPrice &
                    x.UnitCost == item.OrderDetail.UnitCost &
                    x.UnitCode == item.OrderDetail.UnitCode &
                    x.DiscountRatio == item.OrderDetail.DiscountRatio &
                    //x.TaxRatio == item.OrderDetail.TaxRatio &
                    x.FinalUnitPrice == item.OrderDetail.FinalUnitPrice &
                    x.DiscountRatio == item.OrderDetail.DiscountRatio &
                    x.Product == item.OrderDetail.Product &
                    x.IsOvertime == item.IsOvertime
                ))
                    entry = DailyProductionEntries.First(x =>
                    x.JobNo == item.OrderDetail.Order.JobNo &
                    x.ProductType == item.OrderDetail.Product.Type &
                    x.UnitPrice == item.OrderDetail.UnitPrice &
                    x.UnitCost == item.OrderDetail.UnitCost &
                    x.UnitCode == item.OrderDetail.UnitCode &
                    x.DiscountRatio == item.OrderDetail.DiscountRatio &
                    //x.TaxRatio == item.OrderDetail.TaxRatio &
                    x.FinalUnitPrice == item.OrderDetail.FinalUnitPrice &
                    x.DiscountRatio == item.OrderDetail.DiscountRatio &
                    x.Product == item.OrderDetail.Product &
                    x.IsOvertime == item.IsOvertime
                );

                if (entry != null)
                    entry.Quantity += item.OrderDetail.UnitCode == UnitCode.AD ? item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date & !x.IsStock & x.IsOvertime == _IsOvertime).Sum(x => x.ProducedOrderQuantity) : item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date & !x.IsStock & x.IsOvertime == _IsOvertime).Sum(x => x.ProducedOrderArea);
                else
                {
                    DailyProductionEntries.Add(new()
                    {
                        Product = item.OrderDetail.Product,
                        IssueDate = item.OrderDetail.Order.IssueDate.Date,
                        CustomerName = item.OrderDetail.Order.Customer.Name,
                        JobNo = item.OrderDetail.Order.JobNo,
                        ProductType = item.OrderDetail.Product.Type,
                        UnitCode = item.OrderDetail.UnitCode,
                        ProductName = item.OrderDetail.Product.Name,
                        UnitCost = item.OrderDetail.UnitCost,
                        UnitPrice = item.OrderDetail.UnitPrice,
                        DiscountRatio = item.OrderDetail.DiscountRatio,
                        TaxRatio = item.OrderDetail.TaxRatio,
                        Quantity = item.OrderDetail.UnitCode == UnitCode.AD ? item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date & !x.IsStock & x.IsOvertime == _IsOvertime).Sum(x => x.ProducedOrderQuantity) : item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date & !x.IsStock & x.IsOvertime == _IsOvertime).Sum(x => x.ProducedOrderArea),
                        IsOvertime = item.IsOvertime,
                        Specs = item.OrderDetail.Specs
                    });
                }
            }
            DailyProductionEntries = DailyProductionEntries.OrderBy(x => x.JobNo).ThenByDescending(x => x.Product.IsCounting).ToList();
        }
        List<ProducedOrder> MergeProducedOrders(List<ProducedOrder> producedOrders)
        {
            List<ProducedOrder> mergedProducedOrders = [];

            for (int i = 0; i < producedOrders.Count(); i++)
            {
                var currentProducedOrder = producedOrders[i] with { };

                if (mergedProducedOrders.Any(x => x.OrderDetail.ID == currentProducedOrder.OrderDetail.ID & x.IsOvertime == currentProducedOrder.IsOvertime))
                {
                    var producedOrder = mergedProducedOrders.Where(x => x.OrderDetail.ID == currentProducedOrder.OrderDetail.ID & x.IsOvertime == currentProducedOrder.IsOvertime).First();
                    producedOrder.ProducedOrderQuantity += currentProducedOrder.ProducedOrderQuantity;
                }
                else if (currentProducedOrder.IsOvertime == _IsOvertime)
                    mergedProducedOrders.Add(currentProducedOrder);
            }

            return mergedProducedOrders.ToList();
        }

        decimal _outgoing;
        public decimal Outgoing => _outgoing;

        bool _IsOvertime;
        public bool IsOvertime => _IsOvertime;

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
        public Dictionary<UnitCode, decimal> ProducedQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.ISICAM & !x.IsStock & x.OrderDetail.Product.IsCounting).Sum(x => x.ProducedOrderQuantity));
                dic.Add(UnitCode.M2, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.ISICAM & !x.IsStock & x.OrderDetail.Product.IsCounting).Sum(x => x.ProducedOrderArea));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> ProcessedQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                dic.Add(UnitCode.AD, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.İŞLEME & !x.IsStock & x.OrderDetail.Product.IsCounting).Sum(x => x.ProducedOrderQuantity));
                dic.Add(UnitCode.M2, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.İŞLEME & !x.IsStock & x.OrderDetail.Product.IsCounting).Sum(x => x.ProducedOrderArea));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> StockQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> dic = [];

                var res = producedOrdersDB.GetAll(x => x.ProducedDate.Date == _date.Date && x.IsStock & x.IsOvertime == IsOvertime & x.OrderDetail.Product.IsCounting);

                dic.Add(UnitCode.AD, res.Sum(x => x.ProducedOrderQuantity));
                dic.Add(UnitCode.M2, res.Sum(x => x.ProducedOrderArea));

                return dic;
            }
        }
        public Dictionary<UnitCode, decimal> GetSpecQuantity(Spec spec, ProductionType productionType)
        {
            Dictionary<UnitCode, decimal> dic = [];

            switch (productionType)
            {
                case ProductionType.Stock:
                    var res = producedOrdersDB.GetAll(x => x.ProducedDate.Date == _date.Date && x.IsStock & x.IsOvertime == IsOvertime & x.OrderDetail.Product.IsCounting & x.OrderDetail.Specs.Any(s => s.Spec.ID == spec.ID));
                    dic.Add(UnitCode.AD, res.Sum(x => x.ProducedOrderQuantity));
                    dic.Add(UnitCode.M2, res.Sum(x => x.ProducedOrderArea));
                    break;
                case ProductionType.Produced:
                    dic.Add(UnitCode.AD, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.ISICAM & !x.IsStock & x.OrderDetail.Product.IsCounting & x.OrderDetail.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.ProducedOrderQuantity));
                    dic.Add(UnitCode.M2, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.ISICAM & !x.IsStock & x.OrderDetail.Product.IsCounting & x.OrderDetail.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.ProducedOrderArea));
                    break;
                case ProductionType.Processed:
                    dic.Add(UnitCode.AD, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.İŞLEME & !x.IsStock & x.OrderDetail.Product.IsCounting & x.OrderDetail.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.ProducedOrderQuantity));
                    dic.Add(UnitCode.M2, ProducedOrders.Where(x => x.OrderDetail.Product.Type == ProcessType.İŞLEME & !x.IsStock & x.OrderDetail.Product.IsCounting & x.OrderDetail.Specs.Any(s => s.Spec.ID == spec.ID)).Sum(x => x.ProducedOrderArea));
                    break;
            }

            return dic;
        }
        public decimal Price => DailyProductionEntries.Sum(x => x.FinalPrice);
        public decimal PriceTax => Price > 0 ? DailyProductionEntries.Sum(x => x.FinalPrice * (x.TaxRatio / 100)) : 0;
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
        public decimal ProfitRatioWithOutgoing => Price == 0 & CostWithOutgoing == 0 ? 0 : ((Price - CostWithOutgoing) / CostWithOutgoing);
        #endregion
    }
}
