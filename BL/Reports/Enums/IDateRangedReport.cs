using BL.Report.Enums;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.Enums
{
    public interface IDateRangedReport
    {
        public Dictionary<UnitCode, decimal> GetSpecQuantity(Spec spec, ProductionType productionType);
        public string GetSpecQuantityString(Dictionary<UnitCode, decimal> dic);
    }
}
