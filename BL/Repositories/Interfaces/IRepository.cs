using DAL.DTO.Entities;
using System.Linq.Expressions;

namespace BL.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public bool Add(T entity);
        public T Get(int id);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetAll(string filter);
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        public bool Update(T entity, int id);
        public bool Delete(T entity);
        public bool DeleteAll();
    }
}
