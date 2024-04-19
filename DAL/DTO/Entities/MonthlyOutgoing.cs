namespace DAL.DTO.Entities
{
    public record MonthlyOutgoing : BaseEntity
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Outgoing { get; set; }
    }
}
