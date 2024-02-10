using BL.Models.Interfaces;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        public GenericRepository(DbContext dbContext)
        {
            context = dbContext;
            table = context.Set<T>();
        }

        private readonly DbContext context;
        private readonly DbSet<T> table;

        public bool Add(T entity)
        {
            try
            {
                table.Add(entity);
                return true;
            }
            catch { return false; }
        }

        public bool Delete(T entity)
        {
            try
            {
                table.Remove(entity);
                return true;
            }
            catch { return false; }
        }

        public bool DeleteAll()
        {
            try
            {
                table.RemoveRange(GetAll());
                return true;
            }
            catch { return false; }
        }

        public T Get(int id)
        {
            try
            {
                return table.Where(x => x.ID == id).FirstOrDefault();
            }
            catch { return null; }
        }

        public IEnumerable<T> GetAll(string filter)
        {
            try
            {
                ICollection<T> results = [];

                foreach(var entity in GetAll())
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
            catch { return null; }
        }

        /// <summary>
        /// The navigated properties that would be included to the entity. By default, lazy loading won't load related entities.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IEnumerable<T> GetAll(string filter, params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                ICollection<T> results = [];
                IQueryable<T> query = table;

                foreach (var entity in GetAll(includeProperties))
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
            catch { return null; }
        }

        public IEnumerable<T> GetAll(Func<T,bool> predicate)
        {
            try
            {
                return table.Where(predicate);
            }
            catch { return null; }
        }

        /// <summary>
        /// The navigated properties that would be included to the entity. By default, lazy loading won't load related entities.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> query = table;

                foreach(var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }

                return query.Where(predicate);
            }
            catch { return null; }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return table.ToList();
            }
            catch { return null; }
        }

        /// <summary>
        /// The navigated properties that would be included to the entity. By default, lazy loading won't load related entities.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            try
            {
                IQueryable<T> query = table;

                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }

                return query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Update(T entity, int id)
        {
            try
            {
                var oldEntity = Get(id);

                var entityType = typeof(T);

                foreach(var prop in entityType.GetProperties())
                {
                    if(prop.Name != "ID")
                        prop.SetValue(oldEntity, prop.GetValue(entity));
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
