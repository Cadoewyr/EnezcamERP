using BL.Models.Interfaces;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> table;
        private readonly DbContext context;

        public GenericRepository()
        {
            context = EnzDBContext.GetInstance;
            this.table = EnzDBContext.GetInstance.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            await table.AddAsync(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(T entity)
        {
            table.Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAll()
        {
            table.RemoveRange(await GetAll());
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<T> Get(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(string filter)
        {
            ICollection<T> results = [];

            foreach (var entity in await GetAll())
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
            return results;
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await table.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = table;

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(string filter, params Expression<Func<T, object>>[] includeProperties)
        {
            ICollection<T> results = [];
            IQueryable<T> query = table;

            foreach (var entity in await GetAll(includeProperties))
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
            return results;
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = table;

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.Where(predicate).ToListAsync();
        }

        public async Task<bool> Update(T entity, int id)
        {
            var oldEntity = Get(id);

            var entityType = typeof(T);

            foreach (var prop in entityType.GetProperties())
            {
                if (prop.Name != "ID")
                    prop.SetValue(oldEntity, prop.GetValue(entity));
            }

            await context.SaveChangesAsync();

            return true;
        }
    }
}
