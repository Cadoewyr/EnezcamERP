using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace BL.Reports.ProductReports
{
    public class MontlyProductStatistic
    {
        public MontlyProductStatistic(Product product, int year, int month)
        {
            _product = product;
            _month = month;
            _year = year;

            CreateStatisticReport();
        }

        void CreateStatisticReport()
        {
            orderDetails.AddRange(orderDetailsDB.GetAll(x => x.Product.ID == _product.ID & x.Order.IssueDate.Month == _month & x.Order.IssueDate.Year == _year));
            tempOrder = new()
            {
                OrderDetails = orderDetails
            };
        }

        OrderDetailsRepository orderDetailsDB = new();

        Order tempOrder;

        int _month;
        int _year;
        Product _product;

        List<OrderDetail> orderDetails = [];

        public Product Product => _product;
        public int Month => _month;
        public decimal Quantity => tempOrder.ProductQuantity.Where(x => x.Key == UnitCode.AD).First().Value;
        public decimal Area => tempOrder.ProductQuantity.Where(x => x.Key == UnitCode.M2).First().Value;
        public decimal Price => tempOrder.Price;
        public decimal Cost => tempOrder.Cost;
    }
}
