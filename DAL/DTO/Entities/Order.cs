using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record Order : BaseEntity
    {
        public int JobNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DeliveryDate { get; set; }
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
            get => OrderDetails.Sum(x => x.ProducedOrders.Sum(w => w.ProducedOrderCount));
        }

        //Satış
        #region

        [NotMapped]
        public decimal Price
        {
            get
            {
                if (OrderDetails.Any())
                    return OrderDetails.Sum(x => x.TotalPrice);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal Cost
        {
            get
            {
                if(OrderDetails.Any())
                    return OrderDetails.Sum(x => x.TotalCost);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal Profit
        {
            get
            {
                if (OrderDetails.Any())
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
                if (OrderDetails.Any())
                    return (Price - Cost) / Cost;
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
                if (OrderDetails.Any())
                    return OrderDetails.Sum(x => x.TotalProducedCost);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProducedPrice
        {
            get
            {
                if(OrderDetails.Any())
                    return OrderDetails.Sum(x => x.TotalProducedPrice);
                else
                    return 0;
            }
        }

        [NotMapped]
        public decimal ProducedProfit
        {
            get
            {
                if (OrderDetails.Any())
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
                if (OrderDetails.Any())
                    return (ProducedPrice - ProducedCost) / ProducedCost;
                else
                    return 0;
            }
        }

        #endregion
    }
}
