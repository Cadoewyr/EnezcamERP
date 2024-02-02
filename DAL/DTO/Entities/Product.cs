using DAL.DTO.Entities.Enums;

namespace DAL.DTO.Entities
{
    public record Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ProductType Type { get; set; }
    }
}
