namespace DAL.DTO.Entities
{
    public record ProducedOrder : BaseEntity
    {
        public virtual OrderDetail OrderDetail { get; set; } = new();
        public decimal ProducedOrderQuantity { get; set; } = 0;
        public DateTime ProducedDate { get; set; } = DateTime.Now;
        public bool IsStock { get; set; } = false;
    }
}
