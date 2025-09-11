using BL.Models.Interfaces;
using BL.Validators.Validators;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> table;
        protected readonly DbContext context;

        public GenericRepository()
        {
            context = EnzDBContext.GetInstance;
            this.table = EnzDBContext.GetInstance.Set<T>();
        }

        public virtual bool Add(T entity)
        {
            var result = GenericValidator<T>.Validate(entity);

            if (result != null && result.IsValid)
            {
                table.Add(entity);
                context.SaveChanges();
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
        public virtual bool Delete(T entity)
        {
            table.Remove(entity);
            context.SaveChanges();
            return true;
        }
        public virtual bool DeleteAll()
        {
            table.RemoveRange(GetAll());
            context.SaveChanges();
            return true;
        }
        public virtual T Get(int id)
        {
            return table.Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return table
                .OrderBy(x => x.ID)
                .ToList();
        }
        public virtual IEnumerable<T> GetAll(string filter)
        {
            ICollection<T> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(T).GetProperties())
                {
                    var value = prop.GetValue(entity).ToString().ToLower();

                    if (value.Contains(filter.ToLower()) && !results.Contains(entity))
                    {
                        results.Add(entity);
                        continue;
                    }
                }
            }
            return results.OrderBy(x => x.ID);
        }
        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return table
                .Where(predicate)
                .OrderBy(x => x.ID)
                .ToList();
        }
        public virtual bool Update(T entity, int id)
        {
            var result = GenericValidator<T>.Validate(entity);

            if (result.IsValid)
            {
                var oldEntity = Get(id);

                var entityType = typeof(T);

                foreach (var prop in entityType.GetProperties().Where(x => x.SetMethod != null))
                {
                    if (prop.Name != "ID")
                        prop.SetValue(oldEntity, prop.GetValue(entity));
                }

                oldEntity.UpdatedAt = DateTime.Now;
                context.SaveChanges();
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));


            return true;
        }
    }
}
