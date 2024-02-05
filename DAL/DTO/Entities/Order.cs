using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace DAL.DTO.Entities
{
    public record Order : BaseEntity
    {
        public int JobNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public string Customer { get; set; } = string.Empty;
        public List<OrderDetail> OrderDetails { get; set; } = [];

        [NotMapped]
        public decimal ProductCount
        {
            get => OrderDetails.Sum(x => x.Quantity);
        }

        [NotMapped]
        public decimal ProducedProductCount
        {
            get => OrderDetails.Sum(x => x.ProducedOrders.Sum(w=>w.ProducedOrderCount));
        }

        //Satış
        #region

        [NotMapped]
        public decimal Price
        {
            get => OrderDetails.Sum(x => x.TotalPrice);
        }

        [NotMapped]
        public decimal Cost
        {
            get => OrderDetails.Sum(x => x.TotalCost);
        }

        [NotMapped]
        public decimal Profit
        {
            get => Price - Cost;
        }

        [NotMapped]
        public decimal ProfitPercentage
        {
            get => (Price - Cost) / Cost;
        }

        #endregion

        //Üretim
        #region

        [NotMapped]
        public decimal ProducedCost
        {
            get => OrderDetails.Sum(x => x.TotalProducedCost);
        }

        [NotMapped]
        public decimal ProducedPrice
        {
            get => OrderDetails.Sum(x => x.TotalProducedPrice);
        }

        [NotMapped]
        public decimal ProducedProfit
        {
            get => ProducedPrice - Cost;
        }

        [NotMapped]
        public decimal ProducedProfitPercentage
        {
            get => (ProducedPrice - ProducedCost) / ProducedCost;
        }

        #endregion
    }
}
