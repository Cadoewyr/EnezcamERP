using DAL.DTO.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record Order : BaseEntity
    {
        public int JobNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public virtual Customer Customer { get; set; } = new();
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

        //Satış
        #region
        [NotMapped]
        public Dictionary<UnitCode, decimal> ProductQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> quantities = new();
                var unitCodes = OrderDetails.Select(x => x.UnitCode).Distinct().ToList();

                foreach (var unitCode in unitCodes)
                {
                    quantities.Add(unitCode, OrderDetails.Where(x => x.UnitCode == unitCode & x.Product.IsCounting).Sum(x => x.Quantity));
                }

                return quantities;
            }
        }

        [NotMapped]
        public decimal Price
        {
            get
            {
                if (OrderDetails.Count > 0)
                    return OrderDetails.Sum(x => x.Price);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal PriceTax
        {
            get => OrderDetails.Sum(x => x.PriceTax);
        }

        [NotMapped]
        public decimal PriceWithTax
        {
            get => OrderDetails.Sum(x => x.PriceWithTax);
        }

        [NotMapped]
        public decimal Cost
        {
            get
            {
                if (OrderDetails.Count > 0)
                    return OrderDetails.Sum(x => x.Cost);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal CostTax
        {
            get => OrderDetails.Sum(x => x.CostTax);
        }

        [NotMapped]
        public decimal CostWithTax
        {
            get => OrderDetails.Sum(x => x.CostWithTax);
        }

        [NotMapped]
        public decimal Profit
        {
            get
            {
                if (OrderDetails.Count > 0)
                    return Price - Cost;
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProfitRatio
        {
            get
            {
                if (OrderDetails.Count > 0 & Cost > 0)
                    return (Price - Cost) / Cost;
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProditMargin
        {
            get
            {
                if (OrderDetails.Count > 0 & Cost > 0)
                    return (Price - Cost) / Price;
                else return 0;
            }
        }
        #endregion

        //Production
        #region
        [NotMapped]
        public Dictionary<UnitCode, decimal> ProducedProductQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> quantities = new();
                var unitCodes = OrderDetails.Select(x => x.UnitCode).Distinct().ToList();

                foreach (var unitCode in unitCodes)
                {
                    quantities.Add(unitCode, OrderDetails.Where(x => x.Product.IsCounting & x.UnitCode == unitCode).Sum(x => x.ProducedOrders.Sum(w => w.ProducedOrderQuantity)));
                }

                return quantities;
            }
        }

        public Dictionary<UnitCode, decimal> RemainingProductQuantity
        {
            get
            {
                Dictionary<UnitCode, decimal> quantities = new();
                var unitCodes = OrderDetails.Select(x => x.UnitCode).Distinct().ToList();

                foreach (var unitCode in unitCodes)
                {
                    quantities.Add(unitCode, OrderDetails.Where(x => x.UnitCode == unitCode & x.Product.IsCounting).Sum(x => x.Quantity) - OrderDetails.Where(x => x.Product.IsCounting & x.UnitCode == unitCode).Sum(x => x.ProducedOrders.Sum(w => w.ProducedOrderQuantity)));
                }

                return quantities;
            }
        }

        [NotMapped]
        public decimal ProducedCost
        {
            get
            {
                if (OrderDetails.Count > 0)
                    return OrderDetails.Sum(x => x.ProducedCost);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProducedCostTax
        {
            get => OrderDetails.Sum(x => x.ProducedCostTax);
        }

        [NotMapped]
        public decimal ProducedCostWithTax
        {
            get => OrderDetails.Sum(x => x.ProducedCostWithTax);
        }

        [NotMapped]
        public decimal ProducedPrice
        {
            get
            {
                if (OrderDetails.Count > 0)
                    return OrderDetails.Sum(x => x.ProducedPrice);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProducedPriceTax
        {
            get => OrderDetails.Sum(x => x.ProducedPriceTax);
        }

        [NotMapped]
        public decimal ProducedPriceWithTax
        {
            get => OrderDetails.Sum(x => x.ProducedPriceWithTax);
        }

        [NotMapped]
        public decimal ProducedProfit
        {
            get
            {
                if (OrderDetails.Count > 0)
                    return ProducedPrice - Cost;
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProducedProfitRatio
        {
            get
            {
                if (OrderDetails.Count > 0 & ProducedCost > 0)
                    return (ProducedPrice - ProducedCost) / ProducedCost;
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProducedProfitMargin
        {
            get
            {
                if (OrderDetails.Count > 0 & ProducedCost > 0)
                    return (ProducedPrice - ProducedCost) / ProducedPrice;
                else
                    return 0;
            }
        }

        [NotMapped]
        public bool IsDone
        {
            get
            {
                bool isDone = true;

                foreach (var item in RemainingProductQuantity)
                {
                    if (item.Value > 0)
                    {
                        isDone = false;
                        break;
                    }
                }

                return isDone;
            }
        }

        [NotMapped]
        public DateTime? CompletedDate
        {
            get
            {
                return OrderDetails.SelectMany(od => od.ProducedOrders)
                .MaxBy(po => po.ProducedDate)?.ProducedDate;
            }
        }
        #endregion
    }
}
