using BL.Models.Interfaces;
using DAL.DTO.Context;
using DAL.DTO.Entities;

namespace BL.Repositories.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, IRepository<Customer>
    {
        public override bool Add(Customer entity)
        {
            if (!table.Any(x => x.Name == entity.Name))
                return base.Add(entity);
            else
                throw new Exception("Aynı cariden birden fazla oluşturulamaz.");
        }
        public override bool Update(Customer entity, int id)
        {
            var oldEntity = Get(id);

            if (table.Where(x => x.Name == entity.Name & x.ID != id).FirstOrDefault() == null)
            {
                var entityType = typeof(Customer);

                foreach (var prop in entityType.GetProperties().Where(x => x.SetMethod != null))
                {
                    if (prop.Name != "ID")
                    {
                        prop.SetValue(oldEntity, prop.GetValue(entity));
                    }
                }

                context.SaveChanges();

                return true;
            }
            else
                throw new Exception($"{entity.Name} adlı başka bir cari oluşturulmuş. Aynı ad ile birden fazla cari oluşturulamaz.");
        }
        public override bool Delete(Customer entity)
        {
            if (!EnzDBContext.GetInstance.Orders.Any(x => x.Customer.ID == entity.ID))
            {
                table.Remove(entity);
                context.SaveChanges();
                return true;
            }
            else
                throw new Exception($"Bu cari başka siparişlerde kayıtlı olduğundan silinemez.");
        }
    }
}
