using BL.Models.Interfaces;
using DAL.DTO.Entities;

namespace BL.Repositories.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, IRepository<Customer>
    {
        public override bool Add(Customer entity)
        {
            if (!table.Any(x => x == entity))
                return base.Add(entity);
            else
                throw new Exception("Aynı cariden birden fazla oluşturulamaz.");
        }
    }
}
