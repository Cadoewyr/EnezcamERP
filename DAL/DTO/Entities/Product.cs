namespace DAL.DTO.Entities
{
    public record Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public Enums.ProcessType Type { get; set; }
        public PriceHistory PriceHistory { get; set; } = new() { LastCost = 0 , LastPrice = 0 };
        public bool IsCounting { get; set; }
    }
}
