using DAL.DTO.Entities.Enums;

namespace BL.Reports
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
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal CustomerTotalPrice { get; set; }
        public decimal Profit { get; set; }
        public decimal ProfitRatio { get; set; }
    }
}
