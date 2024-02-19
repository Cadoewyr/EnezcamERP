using BL.Report.Enums;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reports
{
    public class DailyProductionReport
    {
        public DailyProductionReport(DateTime date, decimal outgoing)
        {
            _date = date.Date;
            _outgoing = outgoing;

            ProducedOrders.AddRange(producedOrdersDB.GetAll(x => x.ProducedDate.Date == date.Date));

            foreach(var item in ProducedOrders)
            {
                DailyProductionEntries.Add(new()
                {
                    IssueDate = item.OrderDetail.Order.IssueDate.Date,
                    CustomerName = item.OrderDetail.Order.Customer.Name,
                    JobNo = item.OrderDetail.Order.JobNo,
                    ProductType = item.OrderDetail.Product.Type,
                    UnitCode = item.OrderDetail.UnitCode,
                    ProductName = item.OrderDetail.Product.Name,
                    UnitCost = item.OrderDetail.UnitCost,
                    UnitPrice = item.OrderDetail.UnitPrice,
                    Quantity = item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity),
                    Cost = item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitCost,
                    Price = item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitPrice,
                    Profit = (item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitPrice) - (item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitCost),
                    ProfitRatio = ((item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitPrice) - (item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitCost)) / item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitCost,
                    CustomerTotalPrice = producedOrdersDB.GetAll(x => x.ProducedDate.Date == Date & x.OrderDetail.Order.ID == item.OrderDetail.Order.ID).ToList().Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate.Date == Date).Sum(x => x.ProducedOrderQuantity) * item.OrderDetail.UnitPrice
                });
            }
        }

        ProducedOrdersRepository producedOrdersDB = new();
        OrderDetailsRepository orderDetailsDB = new();

        private decimal _outgoing;
        public decimal Outgoing
        {
            get => _outgoing;
        }

        private ReportInterval _reportInterval;
        public ReportInterval Interval
        {
            get => _reportInterval;
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        List<ProducedOrder> ProducedOrders { get; set; } = [];
        public List<DailyProductionEntry> DailyProductionEntries { get; set; } = [];
    }
}
