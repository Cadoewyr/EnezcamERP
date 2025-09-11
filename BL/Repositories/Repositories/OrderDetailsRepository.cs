using BL.Models.Interfaces;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IRepository<OrderDetail>
    {
        public override OrderDetail Get(int id)
        {
            return table
                .Include(x => x.Order)
                .Include(x => x.ProducedOrders)
                .Include(x => x.Product).ThenInclude(x => x.PriceHistory)
                .Where(x => x.ID == id)
                .First();
        }
        public override IEnumerable<OrderDetail> GetAll()
        {
            return table
                .Include(x => x.Order)
                .Include(x => x.ProducedOrders)
                .Include(x => x.Product).ThenInclude(x => x.PriceHistory)
                .Include(x => x.Specs).ThenInclude(x => x.Spec)
                .OrderBy(x => x.CreatedAt)
                .ToList();
        }
        public override IEnumerable<OrderDetail> GetAll(string filter)
        {
            ICollection<OrderDetail> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(OrderDetail).GetProperties())
                {
                    var value = prop.GetValue(entity).ToString().ToLower();

                    if (value.Contains(filter.ToLower()) && !results.Contains(entity))
                    {
                        results.Add(entity);
                        continue;
                    }
                }

                if ($"{Convert.ToInt32(entity.Width * 1000)} * {entity.Height * 1000}".Contains(filter.ToLower()) | $"{Convert.ToInt32(entity.Height * 1000)} * {entity.Width * 1000}".Contains(filter.ToLower()) && !results.Contains(entity))
                    results.Add(entity);
            }

            return results.OrderBy(x => x.CreatedAt);
        }
        public override IEnumerable<OrderDetail> GetAll(Expression<Func<OrderDetail, bool>> predicate)
        {
            return table
                .Include(x => x.Order)
                .Include(x => x.ProducedOrders)
                .Include(x => x.Product).ThenInclude(x => x.PriceHistory)
                .Include(x => x.Specs).ThenInclude(x => x.Spec)
                .Where(predicate)
                .OrderBy(x => x.CreatedAt).ToList();
        }
        public override bool Delete(OrderDetail entity)
        {
            if (entity.Order.OrderDetails.Count > 1)
                base.Delete(entity);
            else
                throw new Exception("Siparişe ait en az bir ürün bulunmak zorunda.");

            return true;
        }
    }
}
