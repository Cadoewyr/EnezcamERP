using DAL.DTO.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record OrderDetail : BaseEntity
    {
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; } = new();
        public UnitCode UnitCode { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Quantity { get; set; } = 0;
        public virtual ICollection<ProducedOrder> ProducedOrders { get; set; } = [];

        [NotMapped]
        public decimal ProducedQuantity
        {
            get => ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }

        [NotMapped]
        public decimal RemainingToProduceQuantity
        {
            get => Quantity - ProducedQuantity;
        }

        //Üretim
        #region
        [NotMapped]
        public decimal ProducedPrice
        {
            get => UnitPrice * ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }

        [NotMapped]
        public decimal ProducedCost
        {
            get => UnitCost * ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }

        [NotMapped]
        public decimal ProducedProfit
        {
            get => ProducedPrice - ProducedCost;
        }

        [NotMapped]
        public decimal ProducedProfitRatio
        {
            get => (ProducedPrice - ProducedCost) / ProducedCost;
        }

        [NotMapped]
        public decimal ProducedProfitMargin
        {
            get => (ProducedPrice - ProducedCost) / ProducedPrice;
        }
        #endregion

        //Satış
        #region
        [NotMapped]
        public decimal Cost
        {
            get => UnitCost * Quantity;
        }

        [NotMapped]
        public decimal Price
        {
            get => UnitPrice * Quantity;
        }

        [NotMapped]
        public decimal Profit
        {
            get => Price - Cost;
        }

        [NotMapped]
        public decimal ProfitRatio
        {
            get => (Price - Cost) / Cost;
        }

        [NotMapped]
        public decimal ProfitMargin
        {
            get => (Price - Cost) / Price;
        }
        #endregion
    }
}
