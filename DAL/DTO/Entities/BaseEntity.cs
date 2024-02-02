using DAL.DTO.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record BaseEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
