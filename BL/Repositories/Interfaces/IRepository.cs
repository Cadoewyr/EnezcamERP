using DAL.DTO.Entities;
using System.Linq.Expressions;

namespace BL.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public bool Add(T entity);
        public T Get(int id);
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        public bool Update(T entity, int id);
        public bool Delete(T entity);
        public bool DeleteAll();
        public void Save();
    }
}
