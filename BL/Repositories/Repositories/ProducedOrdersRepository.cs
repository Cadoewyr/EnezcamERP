using BL.Models.Interfaces;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class ProducedOrdersRepository : GenericRepository<ProducedOrder>, IRepository<ProducedOrder>
    {
        public override bool Add(ProducedOrder entity)
        {
            if (entity.ProducedOrderQuantity <= entity.OrderDetail.RemainingToProduceQuantity)
            {
                table.Add(entity);
                context.SaveChanges();
                return true;
            }
            else
                throw new Exception("Sipariş miktarından daha fazla üretim eklenemez.");
        }
        public override ProducedOrder Get(int id)
        {
            return table
                .Include(x => x.OrderDetail).ThenInclude(x => x.Order)
                .FirstOrDefault(x => x.ID == id);
        }
        public override IEnumerable<ProducedOrder> GetAll()
        {
            return table
                .Include(x => x.OrderDetail).ThenInclude(x => x.Order)
                .ToList();
        }
        public override IEnumerable<ProducedOrder> GetAll(string filter)
        {
            ICollection<ProducedOrder> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(ProducedOrder).GetProperties())
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
        public override IEnumerable<ProducedOrder> GetAll(Expression<Func<ProducedOrder, bool>> predicate)
        {
            return table
                .Where(predicate)
                .Include(x => x.OrderDetail).ThenInclude(x => x.Order)
                .ToList();
        }
        public override bool Update(ProducedOrder entity, int id)
        {
            if (entity.ProducedOrderQuantity <= entity.OrderDetail.RemainingToProduceQuantity)
            {
                return base.Update(entity, id);
            }
            else
                throw new Exception("Sipariş miktarından daha fazla üretim eklenemez.");
        }
    }
}
