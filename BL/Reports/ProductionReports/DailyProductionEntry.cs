using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using Microsoft.Identity.Client;

namespace BL.Reports.ProductionReports
{
    public class DailyProductionEntry
    {
        public Product Product { get; set; }

        public DateTime IssueDate { get; set; }
        public string CustomerName { get; set; }
        public int JobNo { get; set; }
        public string ProductName { get; set; }
        public ProcessType ProductType { get; set; }
        public decimal Quantity { get; set; }
        public decimal TaxRatio { get; set; }
        public UnitCode UnitCode { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal FinalUnitPrice
        {
            get
            {
                if (DiscountRatio > 0)
                    return UnitPrice - (UnitPrice * (DiscountRatio / 100));
                else
                    return UnitPrice;
            }
        }
        public decimal Price
        {
            get => UnitPrice * Quantity;
        }
        public decimal FinalPrice
        {
            get => Quantity * FinalUnitPrice;
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
