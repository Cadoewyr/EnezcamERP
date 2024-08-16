using DAL.DTO.Entities;
using FluentValidation.Results;

namespace BL.Validators.Validators
{
    public static class GenericValidator<T>
    {
        public static ValidationResult Validate(T entity)
        {
            ValidationResult result = null;

            switch (entity)
            {
                case Customer customer:
                    result = ValidateCustomer(customer);
                    break;
                case Product product:
                    result = ValidateProduct(product);
                    break;
                case Order order:
                    result = ValidateOrder(order);
                    break;
                case OrderDetail orderDetail:
                    result = ValidateOrderDetail(orderDetail);
                    break;
                case ProducedOrder producedOrder:
                    result = ValidateProducedOrder(producedOrder);
                    break;
                case MonthlyOutgoing monthlyOutgoing:
                    result = ValidateMonthlyOutgoing(monthlyOutgoing);
                    break;
                case Spec spec:
                    result = ValidateSpec(spec);
                    break;
                case OrderDetailSpec orderDetailSpec:
                    result = ValidateOrderDetailSpec(orderDetailSpec);
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        static ValidationResult ValidateSpec(Spec entity)
        {
            return new SpecValidator().Validate(entity);
        }
        static ValidationResult ValidateOrderDetailSpec(OrderDetailSpec entity)
        {
            return new OrderDetailSpecValidator().Validate(entity);
        }
        static ValidationResult ValidateCustomer(Customer entity)
        {
            return new CustomerValidator().Validate(entity);
        }
        static ValidationResult ValidateProduct(Product entity)
        {
            return new ProductValidator().Validate(entity);
        }
        static ValidationResult ValidateOrderDetail(OrderDetail entity)
        {
            return new OrderDetailValidator().Validate(entity);
        }
        static ValidationResult ValidateOrder(Order entity)
        {
            return new OrderValidator().Validate(entity);
        }
        static ValidationResult ValidateProducedOrder(ProducedOrder entity)
        {
            return new ProducedOrderValidator().Validate(entity);
        }
        static ValidationResult ValidateMonthlyOutgoing(MonthlyOutgoing entity)
        {
            return new MonthlyOutgoingValidator().Validate(entity);
        }
    }
}
