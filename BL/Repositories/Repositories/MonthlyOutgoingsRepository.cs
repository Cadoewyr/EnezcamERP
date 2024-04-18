using BL.Models.Interfaces;
using DAL.DTO.Entities;

namespace BL.Repositories.Repositories
{
    public class MonthlyOutgoingsRepository : GenericRepository<MonthlyOutgoing>, IRepository<MonthlyOutgoing>
    {
        public MonthlyOutgoing GetByMonth(int month)
        {
            return base.GetAll(x => x.Month == month).FirstOrDefault();
        }
    }
}
