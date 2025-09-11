using BL.Models.Interfaces;
using BL.Validators.Validators;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BL.Repositories.Repositories
{
    public class ProducedOrdersRepository : GenericRepository<ProducedOrder>, IRepository<ProducedOrder>
    {
        public override bool Add(ProducedOrder entity)
        {
            var result = GenericValidator<ProducedOrder>.Validate(entity);

            if (result.IsValid)
            {
                if (entity.ProducedOrderQuantity <= entity.OrderDetail.RemainingToProduceQuantity)
                {
                    table.Add(entity);
                    context.SaveChanges();
                }
                else
                    throw new Exception("Sipariş miktarından daha fazla üretim eklenemez.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
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
                .OrderByDescending(x => x.ProducedDate)
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

            return results.OrderByDescending(x => x.ProducedDate);
        }
        public override IEnumerable<ProducedOrder> GetAll(Expression<Func<ProducedOrder, bool>> predicate)
        {
            return table
                .Where(predicate)
                .Include(x => x.OrderDetail).ThenInclude(x => x.Order)
                .OrderBy(x => x.ProducedDate)
                .ToList();
        }
        public override bool Update(ProducedOrder entity, int id)
        {
            var result = GenericValidator<ProducedOrder>.Validate(entity);

            if (result.IsValid)
            {

                if (entity.ProducedOrderQuantity <= entity.OrderDetail.RemainingToProduceQuantity)
                    base.Update(entity, id);
                else
                    throw new Exception("Sipariş miktarından daha fazla üretim eklenemez.");
            }
            else
                throw new FormatException(ErrorStringify.Stringify(result.Errors));

            return true;
        }
    }
}
