using BL.Models.Interfaces;
using DAL.DTO.Entities;

namespace BL.Repositories.Repositories
{
    public class MinimumSquareMeterHistoryRepository : GenericRepository<MinimumSquareMeterHistory>, IRepository<MinimumSquareMeterHistory>
    {
        public MinimumSquareMeterHistory CurrentMinSqm()
        {
            return table.Where(x => x.IsActive()).FirstOrDefault();
        }

        public MinimumSquareMeterHistory MinSqm(DateTime date)
        {
            return table.Where(x => DateOnly.FromDateTime(date) >= x.Start && DateOnly.FromDateTime(date) < x.End.Value).FirstOrDefault();
        }

        public MinimumSquareMeterHistory MinSqm(DateOnly date)
        {
            return table.Where(x => date >= x.Start && date < x.End.Value).FirstOrDefault();
        }
    }
}
