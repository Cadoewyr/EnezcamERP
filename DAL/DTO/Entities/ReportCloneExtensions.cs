namespace DAL.DTO.Entities
{
    public static class ReportCloneExtensions
    {
        public static List<Order> DeepCloneForReport(
            this IEnumerable<Order> source,
            DateTime? forceDate = null)
        {
            var cloned = new List<Order>();
            if (source == null) return cloned;

            foreach (var s in source)
            {
                cloned.Add(CloneOrder(s, forceDate));
            }

            return cloned;
        }

        static Order CloneOrder(Order src, DateTime? forceDate)
        {
            var dst = new Order
            {
                ID = src.ID,
                CreatedAt = src.CreatedAt,
                UpdatedAt = src.UpdatedAt,

                JobNo = src.JobNo,
                IssueDate = src.IssueDate,
                DeliveryDate = src.DeliveryDate,

                Customer = src.Customer,
                OrderDetails = new List<OrderDetail>()
            };

            foreach (var odSrc in src.OrderDetails ?? Enumerable.Empty<OrderDetail>())
            {
                var odDst = new OrderDetail
                {
                    ID = odSrc.ID,
                    CreatedAt = odSrc.CreatedAt,
                    UpdatedAt = odSrc.UpdatedAt,

                    Order = dst,

                    Product = CloneOrReuseProduct(odSrc.Product),
                    UnitCode = odSrc.UnitCode,
                    UnitPrice = odSrc.UnitPrice,
                    UnitCost = odSrc.UnitCost,
                    Quantity = odSrc.Quantity,

                    TaxRatio = odSrc.TaxRatio,
                    DiscountRatio = odSrc.DiscountRatio,
                    Height = odSrc.Height,
                    Width = odSrc.Width,
                    Specs = new List<OrderDetailSpec>(),

                    ProducedOrders = new List<ProducedOrder>()
                };

                foreach (var poSrc in odSrc.ProducedOrders ?? Enumerable.Empty<ProducedOrder>())
                {
                    var poDst = new ProducedOrder
                    {
                        // BaseEntity
                        ID = poSrc.ID,
                        CreatedAt = poSrc.CreatedAt,
                        UpdatedAt = poSrc.UpdatedAt,

                        // Back-ref
                        OrderDetail = odDst,

                        ProducedOrderQuantity = poSrc.ProducedOrderQuantity,
                        ProducedDate = forceDate?.Date ?? poSrc.ProducedDate,
                        IsStock = poSrc.IsStock,
                        IsOvertime = poSrc.IsOvertime
                    };

                    odDst.ProducedOrders.Add(poDst);
                }

                dst.OrderDetails.Add(odDst);
            }

            return dst;
        }

        static Product CloneOrReuseProduct(Product? p)
        {
            if (p is null) return new Product();

            return new Product
            {
                ID = p.ID,
                CreatedAt = p.CreatedAt,
                UpdatedAt = p.UpdatedAt,
                Code = p.Code,
                Name = p.Name,
                Type = p.Type,
                PriceHistory = p.PriceHistory, // gerekirse derinleştir
                IsCounting = p.IsCounting
            };
        }
    }
}
