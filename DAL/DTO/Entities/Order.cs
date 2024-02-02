using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record Order : BaseEntity
    {
        public int JobNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public string Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        //Satış
        #region

        [NotMapped]
        public decimal TotalPrice
        {
            get => OrderDetails.Sum(x => x.TotalPrice);
        }

        [NotMapped]
        public decimal TotalCost
        {
            get => OrderDetails.Sum(x => x.TotalCost);
        }

        [NotMapped]
        public decimal TotalProfit
        {
            get => TotalPrice - TotalCost;
        }

        [NotMapped]
        public decimal TotalProfitPercentage
        {
            get => (TotalPrice - TotalCost) / TotalCost;
        }

        #endregion

        //Üretim
        #region

        [NotMapped]
        public decimal TotalProducedCost
        {
            get => OrderDetails.Sum(x => x.TotalProducedCost);
        }

        [NotMapped]
        public decimal TotalProducedPrice
        {
            get => OrderDetails.Sum(x => x.TotalProducedPrice);
        }

        [NotMapped]
        public decimal TotalProducedProfit
        {
            get => TotalProducedPrice - TotalCost;
        }

        [NotMapped]
        public decimal TotalProducedProfitPercentage
        {
            get => (TotalProducedPrice - TotalProducedCost) / TotalProducedCost;
        }

        #endregion









    }
}
