namespace DAL.DTO.Entities
{
    public record OvertimeOutgoing : BaseEntity
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal Outgoing { get; set; } = 0;
    }
}