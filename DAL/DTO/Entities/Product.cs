namespace DAL.DTO.Entities
{
    public record Product : BaseEntity
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Enums.ProcessType Type { get; set; }
        public virtual PriceHistory PriceHistory { get; set; } = new() { LastCost = 1, LastPrice = 1 };
        public bool IsCounting { get; set; }
    }
}
