namespace DAL.DTO.Entities
{
    public record ProducedOrder : BaseEntity
    {
        public OrderDetail OrderDetail { get; set; }
        public uint ProducedOrderCount { get; set; } = 0;
        public DateTime ProducedDate { get; set; } = DateTime.Now;
    }
}
