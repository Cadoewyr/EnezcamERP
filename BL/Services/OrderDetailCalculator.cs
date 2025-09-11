using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace BL.Services
{
    public static class OrderDetailCalculator
    {
        public static decimal UnitArea(OrderDetail od)
        {
            MinimumSquareMeterHistoryRepository repo = new();

            var minSqm = repo.CurrentMinSqm()?.MinimumSquareMeter ?? 0;

            decimal unitArea = decimal.Round(Math.Max(od.Width * od.Height, minSqm), 3, MidpointRounding.AwayFromZero);

            return unitArea;
        }
    }
}
