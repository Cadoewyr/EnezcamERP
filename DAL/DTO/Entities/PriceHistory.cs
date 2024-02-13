using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record PriceHistory : BaseEntity
    {
        public decimal LastCost { get; set; } = 0;
        public decimal LastPrice { get; set; } = 0;

        [NotMapped]
        public decimal LastProfit
        {
            get => LastPrice - LastCost;
        }

        [NotMapped]
        public decimal LastProfitMargin
        {
            get
            {
                if (LastPrice > 0 && LastCost > 0)
                    return (LastPrice - LastCost) / LastPrice;
                else 
                    return 0;
            }
        }

        [NotMapped]
        public decimal LastProfitRatio
        {
            get
            {
                if(LastPrice > 0 && LastCost > 0)
                    return (LastPrice - LastCost) / LastCost;
                else return 0;
            }
        }
    }
}
