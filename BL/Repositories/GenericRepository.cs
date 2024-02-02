using BL.Models.Interfaces;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<T> GetAll()
        {
            try
            {
                return table.ToList();
            }
            catch { return null; }
        }

        public bool Update(T entity, int id)
        {
            try
            {
                var oldEntity = Get(id);
                table.Entry(oldEntity).CurrentValues.SetValues(entity);
                return true;
            }
            catch { return false; }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
