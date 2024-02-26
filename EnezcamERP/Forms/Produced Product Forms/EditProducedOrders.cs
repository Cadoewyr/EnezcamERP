using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;
using System.Text;

namespace EnezcamERP.Forms.Produced_Product_Forms
{
    public partial class EditProducedOrders : Form
    {
        public EditProducedOrders(Form parentForm, Order order)
        {
            InitializeComponent();
            this.order = order;
            this.parentForm = parentForm;
            gbOrderDetail.Text += $" ({order.JobNo} - {order.Customer.Name})";
            dtpProduceDate.Value = DateTime.Now.Date;

            RefreshOrderDetails();
        }

        private Order order;
        private Form parentForm;
        ProducedOrdersRepository producedOrdersRepository = new();
        OrderRepository orderRepository = new();

        void RefreshOrderDetailTotals(OrderDetail? orderDetail)
        {
            if (orderDetail != null)
            {
                txtProductName.Text = orderDetail.Product.Name;
                txtQuantity.Text = orderDetail.Quantity.ToString(orderDetail.UnitCode == UnitCode.M2 ? "N3" : "N0");
                txtProducedQuantity.Text = orderDetail.ProducedQuantity.ToString(orderDetail.UnitCode == UnitCode.M2 ? "N3" : "N0");
                txtRemainigQuantity.Text = orderDetail.RemainingToProduceQuantity.ToString(orderDetail.UnitCode == UnitCode.M2 ? "N3" : "N0");

                if (orderDetail.RemainingToProduceQuantity == 0)
                {
                    btnAddProducedQuantity.Enabled = false;
                    nudProducedQuantity.Value = 0;
                    nudProducedQuantity.Maximum = 0;
                    nudProducedQuantity.Enabled = false;
                }
                else
                {
                    btnAddProducedQuantity.Enabled = true;
                    nudProducedQuantity.Value = 0;
                    nudProducedQuantity.Maximum = orderDetail.RemainingToProduceQuantity;
                    nudProducedQuantity.Enabled = true;
                }

                nudProducedQuantity.DecimalPlaces = orderDetail.UnitCode == UnitCode.M2 ? 3 : 0;
            }
            else
                ControlCleaner.Clear(this.Controls);
        }
        void RefreshOrderDetails()
        {
            ListView listView = lvOrderDetails;
            listView.Items.Clear();

            foreach (var od in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Text = od.Product.Name,
                    Tag = od
                };

                lvi.SubItems.Add(od.Product.Code);
                lvi.SubItems.Add(od.UnitCost.ToString("C2"));
                lvi.SubItems.Add(od.UnitPrice.ToString("C2"));
                lvi.SubItems.Add(od.UnitCode.ToString());
                lvi.SubItems.Add(od.Quantity.ToString(od.UnitCode == UnitCode.M2 ? "N3" : "N0"));
                lvi.SubItems.Add(od.ProducedQuantity.ToString(od.UnitCode == UnitCode.M2 ? "N3" : "N0"));
                lvi.SubItems.Add(od.RemainingToProduceQuantity.ToString(od.UnitCode == UnitCode.M2 ? "N3" : "N0"));

                listView.Items.Add(lvi);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void RefreshProduceHistory(IEnumerable<ProducedOrder> producedOrders)
        {
            ListView listView = lvProduceHistory;
            listView.Items.Clear();

            foreach (var item in producedOrders.OrderBy(x => x.ProducedDate))
            {
                ListViewItem lvi = new()
                {
                    Text = item.ProducedDate.ToShortDateString(),
                    Tag = item
                };

                lvi.SubItems.Add(item.ProducedOrderQuantity.ToString("N3"));
                lvi.SubItems.Add((item.OrderDetail.Quantity - item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate <= item.ProducedDate).Sum(x => x.ProducedOrderQuantity)).ToString("N3"));

                listView.Items.Add(lvi);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void RefreshAll()
        {
            var currentOrderDetailID = (lvOrderDetails.SelectedItems[0].Tag as OrderDetail).ID;

            RefreshOrderDetails();

            foreach (ListViewItem item in lvOrderDetails.Items)
            {
                if ((item.Tag as OrderDetail).ID == currentOrderDetailID)
                    item.Selected = true;
            }

            RefreshProduceHistory(order.OrderDetails.First(x => x == lvOrderDetails.SelectedItems[0].Tag as OrderDetail).ProducedOrders);
            RefreshOrderDetailTotals(lvOrderDetails.SelectedItems[0].Tag as OrderDetail);
        }

        private void btnAddProducedOrder_Click(object sender, EventArgs e)
        {
            dtpProduceDate.Value = dtpProduceDate.Value.Date
                .AddHours(DateTime.Now.Hour)
                .AddMinutes(DateTime.Now.Minute)
                .AddSeconds(DateTime.Now.Second)
                .AddMilliseconds(DateTime.Now.Millisecond)
                .AddMicroseconds(DateTime.Now.Microsecond);
                
            if (lvOrderDetails.SelectedItems.Count > 0)
            {
                try
                {
                    ProducedOrder po = new()
                    {
                        ProducedDate = dtpProduceDate.Value,
                        OrderDetail = lvOrderDetails.SelectedItems[0].Tag as OrderDetail,
                        ProducedOrderQuantity = nudProducedQuantity.Value
                    };

                    var res = new ProducedOrderValidator().Validate(po);

                    if (res.IsValid)
                    {
                        var selectedOrderDetail = lvOrderDetails.SelectedItems[0].Tag as OrderDetail;
                        order.OrderDetails.Where(x => x == selectedOrderDetail).First().ProducedOrders.Add(po);
                        orderRepository.Update(order, order.ID);
                        (parentForm as FormMain).RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                    else
                        MessageBox.Show(ErrorStringify.Stringify(res.Errors));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshAll();
            }
        }

        private void btnDeleteProducedOrder_Click(object sender, EventArgs e)
        {
            if (lvProduceHistory.SelectedItems.Count > 0)
            {
                try
                {
                    producedOrdersRepository.Delete(lvProduceHistory.SelectedItems[0].Tag as ProducedOrder);
                    (parentForm as FormMain).RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshAll();
            }
        }

        private void lvOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                RefreshProduceHistory(((sender as ListView).SelectedItems[0].Tag as OrderDetail).ProducedOrders);
                RefreshOrderDetailTotals((sender as ListView).SelectedItems[0].Tag as OrderDetail);
            }
        }

        private void gbOrderDetail_Enter(object sender, EventArgs e)
        {

        }
    }
}
