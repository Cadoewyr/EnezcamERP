using DAL.DTO.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

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
        [Range(0, 100)]
        public decimal TaxRatio { get; set; } = 0;
        public virtual ICollection<ProducedOrder> ProducedOrders { get; set; } = [];

        //Production
        #region
        [NotMapped]
        public decimal ProducedPrice
        {
            get => UnitPrice * ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }

        public decimal ProducedPriceTax
        {
            get => ProducedPrice * (TaxRatio / 100);
        }

        public decimal ProducedPriceWithTax
        {
            get => ProducedPrice + ProducedPriceTax;
        }

        [NotMapped]
        public decimal ProducedCost
        {
            get => UnitCost * ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }

        [NotMapped]
        public decimal ProducedCostTax
        {
            get => ProducedCost * (TaxRatio / 100);
        }

        [NotMapped]
        public decimal ProducedCostWithTax
        {
            get => ProducedCost + ProducedCostTax;
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
        #endregion

        //Sales
        #region
        [NotMapped]
        public decimal Cost
        {
            get => UnitCost * Quantity;
        }

        [NotMapped]
        public decimal CostTax
        {
            get => Cost * (TaxRatio / 100);
        }

        [NotMapped]
        public decimal CostWithTax
        {
            get => Cost + CostTax;
        }

        [NotMapped]
        public decimal Price
        {
            get => UnitPrice * Quantity;
        }

        [NotMapped]
        public decimal PriceTax
        {
            get => Price * (TaxRatio / 100);
        }

        [NotMapped]
        public decimal PriceWithTax
        {
            get => Price + PriceTax;
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
