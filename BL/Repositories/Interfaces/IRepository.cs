using DAL.DTO.Entities;
using System.Linq.Expressions;

namespace BL.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task<bool> Add(T entity);
        public Task<T> Get(int id);
        public Task<IEnumerable<T>> GetAll();
        public Task<IEnumerable<T>> GetAll(string filter);
        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate);
        public Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties);
        public Task<IEnumerable<T>> GetAll(string filter, params Expression<Func<T, object>>[] includeProperties);
        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        public Task<bool> Update(T entity, int id);
        public Task<bool> Delete(T entity);
        public Task<bool> DeleteAll();
    }
}
