namespace DAL.DTO.Entities
{
    public record PriceHistory : BaseEntity
    {
        public decimal LastCost { get; set; } = 0;
        public decimal LastPrice { get; set; } = 0;
    }
}
