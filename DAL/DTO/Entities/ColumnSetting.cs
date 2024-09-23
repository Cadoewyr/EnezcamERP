using Microsoft.Identity.Client;

namespace DAL.DTO.Entities
{
    public record ColumnSetting : BaseEntity
    {
        public string FormName { get; set; }
        public string ColumnName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
