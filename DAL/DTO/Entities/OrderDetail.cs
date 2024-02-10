using DAL.DTO.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record OrderDetail : BaseEntity
    {
        public Order Order { get; set; }
        public Product Product { get; set; } = new();
        public UnitCode UnitCode { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public decimal UnitCost { get; set; } = 0;
        public decimal Quantity { get; set; } = 0;
        public ICollection<ProducedOrder> ProducedOrders { get; set; } = [];

        //Üretim
        #region

        [NotMapped]
        public decimal ProducedPrice
        {
            get => UnitPrice * ProducedOrders.Sum(x => x.ProducedOrderCount);
        }

        [NotMapped]
        public decimal ProducedCost
        {
            get => UnitCost * ProducedOrders.Sum(x => x.ProducedOrderCount);
        }

        [NotMapped]
        public decimal ProducedProfit
        {
            get => ProducedPrice - ProducedCost;
        }

        [NotMapped]
        public decimal ProducedProfitPercentage
        {
            get => (ProducedPrice - ProducedCost) / ProducedCost;
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
        public decimal ProfitPercentage
        {
            get => (Price - Cost) / Cost;
        }

        #endregion
    }
}
