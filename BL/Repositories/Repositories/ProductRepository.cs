using BL.Models.Interfaces;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IRepository<Product>
    {
        public override bool Add(Product entity)
        {
            if (!table.Any(x => x.Name == entity.Name & x.Type == entity.Type & x.Code == entity.Code))
                return base.Add(entity);
            else
                throw new Exception("Aynı üründen birden fazla oluşturulamaz.");
        }
        public override IEnumerable<Product> GetAll()
        {
            return table.
                Include(x => x.PriceHistory)
                .ToList();
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

            return results;
        }
        public override IEnumerable<Product> GetAll(Expression<Func<Product, bool>> predicate)
        {
            return table
                .Where(predicate)
                .Include(x => x.PriceHistory)
                .ToList();
        }
        public override bool Update(Product entity, int id)
        {
            var oldEntity = Get(id);

            if (table.Where(x => x.Name == entity.Name & x != entity).FirstOrDefault() == null)
            {
                var entityType = typeof(Product);

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
                throw new Exception($"{entity.Name} adlı başka bir ürün oluşturulmuş. Aynı ad ile birden fazla ürün oluşturulamaz.");
        }
        public override bool Delete(Product entity)
        {
            if (!EnzDBContext.GetInstance.OrderDetails.Include(x => x.Product).Any(x => x.Product == entity))
            {
                table.Remove(entity);
                context.SaveChanges();
                return true;
            }
            else
                throw new Exception("Bu ürün başka siparişlerde kayıtlı olduğundan silinemez.");
        }
    }
}
