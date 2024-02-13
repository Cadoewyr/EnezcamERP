using BL.Models.Interfaces;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IRepository<Order>
    {
        public override bool Add(Order entity)
        {
            if (!table.Any(x => x.ID == entity.ID))
                return base.Add(entity);
            else
                throw new Exception($"{entity.JobNo} numarası ile başka bir sipariş oluşturulmuş. Aynı numara ile birden fazla sipariş oluşturulamaz.");
        }
        public override Order Get(int id)
        {
            return table
                .Include(x => x.Customer)
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Include(x => x.OrderDetails).ThenInclude(x => x.ProducedOrders)
                .Where(x => x.ID == id)
                .First();
        }
        public override IEnumerable<Order> GetAll()
        {
            return table
                .Include(x => x.Customer)
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Include(x => x.OrderDetails).ThenInclude(x => x.ProducedOrders)
                .ToList();
        }
        public override IEnumerable<Order> GetAll(string filter)
        {
            ICollection<Order> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(Order).GetProperties())
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
        public override IEnumerable<Order> GetAll(Expression<Func<Order, bool>> predicate)
        {
            return table
                .Include(x => x.Customer)
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Include(x => x.OrderDetails).ThenInclude(x => x.ProducedOrders)
                .Where(predicate)
                .ToList();
        }
        public override bool Update(Order entity, int id)
        {
            var oldEntity = Get(id);

            if (table.Where(x => x.JobNo == entity.JobNo & x != entity).FirstOrDefault() == null)
            {
                var entityType = typeof(Order);

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
                throw new Exception($"{entity.JobNo} numaralı başka bir sipariş oluşturulmuş. Aynı sipariş numarası ile birden fazla sipariş oluşturulamaz.");
        }
    }
}
