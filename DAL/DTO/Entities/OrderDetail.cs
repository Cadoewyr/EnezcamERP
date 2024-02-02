using DAL.DTO.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record OrderDetail : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public Product Product { get; set; }
        public UnitCode Code { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public decimal UnitCost { get; set; } = 0;
        public decimal Quantity { get; set; } = 0;
        public List<ProducedOrder> ProducedOrders { get; set; } = new List<ProducedOrder>();

        //Satış
        #region

        [NotMapped]
        public decimal TotalProducedPrice
        {
            get => UnitPrice * ProducedOrders.Sum(x => x.ProducedOrderCount);
        }

        [NotMapped]
        public decimal TotalProducedCost
        {
            get => UnitCost * ProducedOrders.Sum(x => x.ProducedOrderCount);
        }

        [NotMapped]
        public decimal TotalProducedProfit
        {
            get => TotalProducedPrice - TotalProducedCost;
        }

        [NotMapped]
        public decimal TotalProducedProfitPercentage
        {
            get => (TotalProducedPrice - TotalProducedCost) / TotalProducedCost;
        }

        #endregion

        //Üretim
        #region

        [NotMapped]
        public decimal TotalCost
        {
            get => UnitCost * Quantity;
        }

        [NotMapped]
        public decimal TotalPrice
        {
            get => UnitPrice * Quantity;
        }

        [NotMapped]
        public decimal TotalProfit
        {
            get => TotalPrice - TotalCost;
        }

        [NotMapped]
        public decimal ProfitPercentage
        {
            get => (TotalPrice - TotalCost) / TotalCost;
        }

        #endregion
    }
}
