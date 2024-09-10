using BL.Models.Interfaces;
using BL.Validators.Validators;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;

namespace BL.Repositories.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, IRepository<Customer>
    {
        public override bool Add(Customer entity)
        {
            var result = GenericValidator<Customer>.Validate(entity);

            if (result.IsValid)
            {
                try
                {
                    if (!table.Any(x => x.Name == entity.Name))
                        return base.Add(entity);
                    else
                        throw new Exception("Aynı cariden birden fazla oluşturulamaz.");
                }
                catch { }
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
        public override bool Update(Customer entity, int id)
        {
            var result = GenericValidator<Customer>.Validate(entity);

            if (result.IsValid)
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

                    oldEntity.UpdatedAt = DateTime.Now;
                    context.SaveChanges();
                }
                else
                    throw new Exception($"{entity.Name} adlı başka bir cari oluşturulmuş. Aynı ad ile birden fazla cari oluşturulamaz.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
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
