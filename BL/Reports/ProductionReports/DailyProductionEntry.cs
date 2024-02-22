using DAL.DTO.Entities.Enums;

namespace BL.Reports.ProductionReports
{
    public class DailyProductionEntry
    {
        public DateTime IssueDate { get; set; }
        public string CustomerName { get; set; }
        public int JobNo { get; set; }
        public string ProductName { get; set; }
        public ProcessType ProductType { get; set; }
        public decimal Quantity { get; set; }
        public UnitCode UnitCode { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price
        {
            get => UnitPrice * Quantity;
        }
        public decimal FinalPrice
        {
            get
            {
                if (DiscountRatio > 0)
                    return (Quantity * UnitPrice) - ((Quantity * UnitPrice) * (DiscountRatio / 100));
                else
                    return Price;
            }
        }
        public decimal DiscountRatio { get; set; }
        public decimal Cost
        {
            get => UnitCost * Quantity;
        }
        public decimal Profit
        {
            get => FinalPrice - Cost;
        }
        public decimal ProfitRatio
        {
            get => (FinalPrice - Cost) / Cost;
        }
    }
}
