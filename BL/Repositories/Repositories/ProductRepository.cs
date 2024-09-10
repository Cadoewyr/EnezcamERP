using BL.Models.Interfaces;
using BL.Validators.Validators;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IRepository<Product>
    {
        public override bool Add(Product entity)
        {
            var result = GenericValidator<Product>.Validate(entity);

            if (result.IsValid)
            {
                if (!table.Any(x => x.Name == entity.Name & x.Type == entity.Type & x.Code == entity.Code))
                    base.Add(entity);
                else
                    throw new Exception("Aynı üründen birden fazla oluşturulamaz.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
        public override IEnumerable<Product> GetAll()
        {
            return table.
                Include(x => x.PriceHistory)
                .ToList().OrderBy(x => x.Name);
        }
        public override IEnumerable<Product> GetAll(string filter)
        {
            ICollection<Product> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(Product).GetProperties())
                {
                    var value = prop.GetValue(entity).ToString().ToLower();

                    if (value.Contains(filter.ToLower()) && !results.Contains(entity))
                    {
                        results.Add(entity);
                        continue;
                    }
                }
            }

            return results.OrderBy(x => x.Name);
        }
        public override IEnumerable<Product> GetAll(Expression<Func<Product, bool>> predicate)
        {
            return table
                .Include(x => x.PriceHistory)
                .Where(predicate)
                .ToList().OrderBy(x => x.Name);
        }
        public override bool Update(Product entity, int id)
        {
            var result = GenericValidator<Product>.Validate(entity);

            if (result.IsValid)
            {
                var oldEntity = Get(id);

                if (table.Where(x => (x.Code == entity.Code & x.Name == entity.Name) & x.ID != id).FirstOrDefault() == null)
                {
                    var entityType = typeof(Product);

                    foreach (var prop in entityType.GetProperties().Where(x => x.SetMethod != null))
                    {
                        if (prop.Name != "ID")
                            prop.SetValue(oldEntity, prop.GetValue(entity));
                    }

                    oldEntity.UpdatedAt = DateTime.Now;
                    context.SaveChanges();
                }
                else
                    throw new Exception($"{entity.Name} adlı başka bir ürün oluşturulmuş. Aynı ad ile birden fazla ürün oluşturulamaz.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
        public override bool Delete(Product entity)
        {
            var result = GenericValidator<Product>.Validate(entity);

            if (result.IsValid)
            {
                if (!EnzDBContext.GetInstance.OrderDetails.Include(x => x.Product).Any(x => x.Product == entity))
                {
                    table.Remove(entity);
                    context.SaveChanges();
                }
                else
                    throw new Exception("Bu ürün başka siparişlerde kayıtlı olduğundan silinemez.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;

        }
    }
}
