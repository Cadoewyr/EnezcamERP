using BL.Models.Interfaces;
using BL.Validators.Validators;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IRepository<Order>
    {
        public int TotalCount()
        {
            return table.Count();
        }
        public override bool Add(Order entity)
        {
            var result = GenericValidator<Order>.Validate(entity);

            if (result.IsValid)
            {
                if (!table.Any(x => x.JobNo == entity.JobNo))
                    base.Add(entity);
                else
                    throw new Exception($"{entity.JobNo} numarası ile başka bir sipariş oluşturulmuş. Aynı numara ile birden fazla sipariş oluşturulamaz.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
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
                .ToList()
                .OrderByDescending(x => x.JobNo);
        }
        public IEnumerable<Order> GetAll(int pageNumber, int pageSize = 50)
        {
            return table
                .Include(x => x.Customer)
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Include(x => x.OrderDetails).ThenInclude(x => x.ProducedOrders)
                .OrderByDescending(x => x.JobNo)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public override IEnumerable<Order> GetAll(string filter)
        {
            ICollection<Order> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(Order).GetProperties())
                {
                    if (prop.GetValue(entity) == null)
                        continue;

                    var value = prop.GetValue(entity).ToString().ToLower();

                    if (value.Contains(filter.ToLower()) && !results.Contains(entity))
                    {
                        results.Add(entity);
                        continue;
                    }
                }

                if (entity.OrderDetails.Any(x =>
                (x.Product.Code.ToLower().Contains(filter.ToLower())) |
                x.Product.Name.ToLower().Contains(filter.ToLower()) |
                (x.Height * 1000).ToString().Contains(filter.ToLower()) |
                $"{x.Height * 1000} * {x.Width * 1000}" == filter.ToLower() | $"{Convert.ToInt32(x.Width * 1000)} * {Convert.ToInt32(x.Height * 1000)}" == filter.ToLower() |
                (x.Width * 1000).ToString().Contains(filter.ToLower())) &&
                !results.Contains(entity))
                    results.Add(entity);
            }

            return results.ToList().OrderByDescending(x => x.JobNo);
        }
        public IEnumerable<Order> GetAll(string filter, int pageNumber, int pageSize = 50)
        {
            ICollection<Order> results = [];

            foreach (var entity in GetAll())
            {
                foreach (var prop in typeof(Order).GetProperties())
                {
                    if (prop.GetValue(entity) == null)
                        continue;

                    var value = prop.GetValue(entity).ToString().ToLower();

                    if (value.Contains(filter.ToLower()) && !results.Contains(entity))
                    {
                        results.Add(entity);
                        continue;
                    }
                }

                if (entity.OrderDetails.Any(x =>
                (x.Product.Code.ToLower().Contains(filter.ToLower())) |
                x.Product.Name.ToLower().Contains(filter.ToLower()) |
                (x.Height * 1000).ToString().Contains(filter.ToLower()) |
                $"{x.Height * 1000} * {x.Width * 1000}".Contains(filter.ToLower()) | $"{Convert.ToInt32(x.Width * 1000)} * {Convert.ToInt32(x.Height * 1000)}".Contains(filter.ToLower()) |
                (x.Width * 1000).ToString().Contains(filter.ToLower())) &&
                !results.Contains(entity))
                    results.Add(entity);
            }

            return results.OrderByDescending(x => x.JobNo).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }
        public override IEnumerable<Order> GetAll(Expression<Func<Order, bool>> predicate)
        {
            return table
                .Include(x => x.Customer)
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Include(x => x.OrderDetails).ThenInclude(x => x.ProducedOrders)
                .Where(predicate)
                .ToList()
                .OrderByDescending(x => x.JobNo);
        }
        public IEnumerable<Order> GetAll(Expression<Func<Order, bool>> predicate, int pageNumber, int pageSize = 50)
        {
            return table
                .Include(x => x.Customer)
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Include(x => x.OrderDetails).ThenInclude(x => x.ProducedOrders)
                .Where(predicate)
                .OrderByDescending(x => x.JobNo)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToList();
        }
        public override bool Update(Order entity, int id)
        {
            var result = GenericValidator<Order>.Validate(entity);

            if (entity.OrderDetails.Count < 1)
                throw new FormatException("Siparişe ait en az bir kalem bulunmak zorunda.");

            if (result.IsValid)
            {
                var oldEntity = Get(id);

                if (table.Where(x => x.JobNo == entity.JobNo & x != entity).FirstOrDefault() == null)
                {
                    var entityType = typeof(Order);

                    foreach (var prop in entityType.GetProperties().Where(x => x.SetMethod != null))
                    {
                        if (prop.Name != "ID")
                            prop.SetValue(oldEntity, prop.GetValue(entity));
                    }

                    context.SaveChanges();
                }
                else
                    throw new Exception($"{entity.JobNo} numaralı başka bir sipariş oluşturulmuş. Aynı sipariş numarası ile birden fazla sipariş oluşturulamaz.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
    }
}
