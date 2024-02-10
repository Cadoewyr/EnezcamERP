using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record Order : BaseEntity
    {
        public int JobNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Customer Customer { get; set; } = new();
        public ICollection<OrderDetail> OrderDetails { get; set; } = [];

        [NotMapped]
        public decimal ProductCount
        {
            get => OrderDetails.Sum(x => x.Quantity);
        }

        [NotMapped]
        public decimal ProducedProductCount
        {
            get => OrderDetails.Sum(x => x.ProducedOrders.Sum(w => w.ProducedOrderCount));
        }

        //Satış
        #region

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
        public decimal Cost
        {
            get
            {
                if(OrderDetails.Count > 0)
                    return OrderDetails.Sum(x => x.Cost);
                else
                    return 0;
            }
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
        public decimal ProfitPercentage
        {
            get
            {
                if (OrderDetails.Count > 0 & Cost > 0)
                    return Profit / Price;
                else
                    return 0;
            }
        }

        #endregion

        //Üretim
        #region

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
        public decimal ProducedPrice
        {
            get
            {
                if(OrderDetails.Count > 0)
                    return OrderDetails.Sum(x => x.ProducedPrice);
                else
                    return 0;
            }
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
        public decimal ProducedProfitPercentage
        {
            get
            {
                if (OrderDetails.Count > 0 & ProducedCost > 0)
                    return (ProducedPrice - ProducedCost) / ProducedCost;
                else
                    return 0;
            }
        }

        #endregion
    }
}
