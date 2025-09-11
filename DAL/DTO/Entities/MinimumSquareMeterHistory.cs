using System.ComponentModel.DataAnnotations;

namespace DAL.DTO.Entities
{
    public record MinimumSquareMeterHistory : BaseEntity
    {
        [Required]
        public DateOnly Start { get; set; }
        public DateOnly? End { get; set; }
        [Required]
        public decimal MinimumSquareMeter { get; set; }

        public bool IsActive()
        {
            if (!End.HasValue || DateTime.Now < End.Value.ToDateTime(TimeOnly.MaxValue))
                return true;
            else
                return false;
        }
    }
}
