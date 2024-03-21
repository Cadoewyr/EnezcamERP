using DAL.DTO.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO.Entities
{
    public record ProducedOrder : BaseEntity
    {
        public virtual OrderDetail OrderDetail { get; set; } = new();
        [Range(0, 99999)]
        public decimal ProducedOrderQuantity { get; set; } = 0;
        public DateTime ProducedDate { get; set; } = DateTime.Now;
        public bool IsStock { get; set; } = false;

        [NotMapped]
        public decimal ProducedOrderArea => decimal.Round(ProducedOrderQuantity * OrderDetail.UnitArea, 3, MidpointRounding.AwayFromZero);

        public string GetProducedQuantityString()
        {
            return $"{ProducedOrderQuantity.ToString("N0")} {UnitCode.AD}, {ProducedOrderArea.ToString("N3")} {UnitCode.M2}";
        }
    }
}
