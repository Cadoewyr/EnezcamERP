using DAL.DTO.Entities.Enums;
using System.ComponentModel.DataAnnotations;
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
        [Range(0, 100)]
        public decimal TaxRatio { get; set; } = 0;
        [Range(0, 100)]
        public decimal DiscountRatio { get; set; } = 0;
        public virtual ICollection<ProducedOrder> ProducedOrders { get; set; } = [];
        //[Range(1, 99999)]
        //public int Width { get; set; } = 1;
        //[Range(1, 99999)]
        //public int Height { get; set; } = 1;

        //[NotMapped]
        //public decimal UnitArea => Width * Height;
        //[NotMapped]
        //public decimal TotalArea => UnitArea * Quantity;

        //Production
        #region
        [NotMapped]
        public decimal ProducedPrice
        {
            get => UnitPrice * ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }
        [NotMapped]
        public decimal ProducedFinalPrice
        {
            get
            {
                if (DiscountRatio > 0)
                    return ProducedPrice - (ProducedPrice * (DiscountRatio / 100));
                else
                    return ProducedPrice;
            }
        }
        [NotMapped]
        public decimal ProducedFinalPriceTax
        {
            get => ProducedFinalPrice * (TaxRatio / 100);
        }
        [NotMapped]
        public decimal ProducedFinalPriceWithTax
        {
            get => ProducedFinalPrice + ProducedFinalPriceTax;
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
            get => ProducedFinalPrice - ProducedCost;
        }
        [NotMapped]
        public decimal ProducedProfitRatio
        {
            get => (ProducedFinalPrice - ProducedCost) / (ProducedCost > 0 ? ProducedCost : 1);
        }
        [NotMapped]
        public decimal ProducedProfitMargin
        {
            get => (ProducedFinalPrice - ProducedCost) / (ProducedFinalPrice > 0 ? ProducedFinalPrice : 1);
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
        public decimal FinalPrice
        {
            get
            {
                if (DiscountRatio > 0)
                    return Price - (Price * (DiscountRatio / 100));
                else
                    return Price;
            }
        }
        [NotMapped]
        public decimal FinalPriceTax
        {
            get => FinalPrice * (TaxRatio / 100);
        }
        [NotMapped]
        public decimal FinalPriceWithTax
        {
            get => FinalPrice + FinalPriceTax;
        }
        [NotMapped]
        public decimal Profit
        {
            get => FinalPrice - Cost;
        }
        [NotMapped]
        public decimal ProfitRatio
        {
            get => (FinalPrice - Cost) / (Cost > 0 ? Cost : 1);
        }
        [NotMapped]
        public decimal ProfitMargin
        {
            get => (FinalPrice - Cost) / (FinalPrice > 0 ? FinalPrice : 1);
        }
        #endregion
    }
}
