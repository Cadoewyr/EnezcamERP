using BL.Models.Interfaces;
using BL.Validators.Validators;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;

namespace BL.Repositories.Repositories
{
    public class SpecRepository : GenericRepository<Spec>, IRepository<Spec>
    {
        public override bool Add(Spec entity)
        {
            var result = GenericValidator<Spec>.Validate(entity);

            if (result.IsValid)
            {
                try
                {
                    if (!table.Any(x => x.Name == entity.Name))
                        return base.Add(entity);
                    else
                        throw new Exception("Aynı özellikten birden fazla oluşturulamaz.");
                }
                catch { }
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
        public override bool Update(Spec entity, int id)
        {
            var result = GenericValidator<Spec>.Validate(entity);

            if (result.IsValid)
            {
                var oldEntity = Get(id);

                if (table.Where(x => x.Name == entity.Name & x.ID != id).FirstOrDefault() == null)
                {
                    var entityType = typeof(Spec);

                    foreach (var prop in entityType.GetProperties().Where(x => x.SetMethod != null))
                    {
                        if (prop.Name != "ID")
                        {
                            prop.SetValue(oldEntity, prop.GetValue(entity));
                        }
                    }

                    context.SaveChanges();
                }
                else
                    throw new Exception($"{entity.Name} adlı başka bir özellik oluşturulmuş. Aynı ad ile birden fazla özellik oluşturulamaz.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
        public override bool Delete(Spec entity)
        {
            if (!EnzDBContext.GetInstance.OrderDetails.Any(x => x.Specs.Any(s => s.Spec.ID == entity.ID)))
            {
                table.Remove(entity);
                context.SaveChanges();
                return true;
            }
            else
                throw new Exception($"Bu özellik başka siparişlerde kayıtlı olduğundan silinemez.");
        }
    }
}