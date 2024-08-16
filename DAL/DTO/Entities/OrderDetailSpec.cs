namespace DAL.DTO.Entities
{
    public record OrderDetailSpec : BaseEntity
    {
        public virtual OrderDetail OrderDetail { get; set; } = new();
        public virtual Spec Spec { get; set; } = new();
    }
}