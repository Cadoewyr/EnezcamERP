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
        [Range(1, 999999)]
        public int Quantity { get; set; } = 1;
        [Range(0, 100)]
        public decimal TaxRatio { get; set; } = 0;
        [Range(0, 100)]
        public decimal DiscountRatio { get; set; } = 0;
        public virtual ICollection<ProducedOrder> ProducedOrders { get; set; } = [];
        [Range(1, 999999)]
        public decimal Width { get; set; } = 1;
        [Range(1, 999999)]
        public decimal Height { get; set; } = 1;
        public virtual ICollection<OrderDetailSpec> Specs { get; set; } = [];

        [NotMapped]
        public decimal UnitArea
        {
            get
            {
                // Order null olursa bugünkü tarihi baz al
                var issueDate = Order.IssueDate;

                // Milat tarihi
                var cutoffDate = new DateTime(2025, 8, 13);

                decimal minSqm;

                if (issueDate <= cutoffDate)
                    minSqm = 0.25m;
                else
                    minSqm = 0.3m;

                    return decimal.Round(
                        Math.Max(Width * Height, minSqm),
                        3,
                        MidpointRounding.AwayFromZero
                    );
            }
        }
        [NotMapped]
        public decimal TotalArea => decimal.Round(UnitArea * Quantity, 3);

        public string GetQuantityString()
        {
            return $"{Quantity.ToString("N0")} {UnitCode.AD}, {TotalArea.ToString("N3")} {UnitCode.M2}";
        }
        public string GetProducedQuantityString()
        {
            return $"{ProducedQuantity.ToString("N0")} {UnitCode.AD}, {ProducedArea.ToString("N3")} {UnitCode.M2}";
        }
        public string GetRemainingQuantityString()
        {
            return $"{(Quantity - ProducedQuantity).ToString("N0")} {UnitCode.AD}, {(TotalArea - ProducedArea).ToString("N3")} {UnitCode.M2}";
        }
        public string GetSizeString()
        {
            return $"{Width.ToString("N3")} * {Height.ToString("N3")}";
        }

        //Production
        #region
        [NotMapped]
        public decimal ProducedPrice
        {
            get => UnitPrice * ProducedOrders.Sum(x => (UnitCode == UnitCode.M2 ? x.ProducedOrderArea : x.ProducedOrderQuantity));
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
            get => UnitCost * ProducedOrders.Sum(x => (UnitCode == UnitCode.M2 ? x.ProducedOrderArea : x.ProducedOrderQuantity));
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
        public int ProducedQuantity
        {
            get => ProducedOrders.Sum(x => x.ProducedOrderQuantity);
        }
        [NotMapped]
        public int RemainingToProduceQuantity
        {
            get => Quantity - ProducedQuantity;
        }
        [NotMapped]
        public decimal ProducedArea
        {
            get => ProducedOrders.Sum(x => x.ProducedOrderArea);
        }
        [NotMapped]
        public decimal RemainingToProduceArea
        {
            get => TotalArea - ProducedArea;
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
            get => UnitCost * (UnitCode == UnitCode.M2 ? TotalArea : Quantity);
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
            get => UnitPrice * (UnitCode == UnitCode.M2 ? TotalArea : Quantity);
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
