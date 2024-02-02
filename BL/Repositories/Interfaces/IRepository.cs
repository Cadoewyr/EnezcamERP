using DAL.DTO.Entities;

namespace BL.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public bool Add(T entity);
        public T Get(int id);
        public IEnumerable<T> GetAll();
        public bool Update(T entity, int id);
        public bool Delete(T entity);
        public bool DeleteAll();
        public void Save();
    }
}
