using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using System.Data;
using System.Text;

namespace EnezcamERP
{
    public partial class FormOrderDetailAddEdit : Form
    {
        public FormOrderDetailAddEdit()
        {
            InitializeComponent();
        }

        public FormOrderDetailAddEdit(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        public FormOrderDetailAddEdit(OrderDetail orderDetail)
        {
            InitializeComponent();
            this.orderDetail = orderDetail;
        }

        Order order;
        OrderDetail orderDetail;

        GenericRepository<OrderDetail> orderDetailDB = new(EnzDBContext.GetInstance);
        GenericRepository<Product> productDB = new(EnzDBContext.GetInstance);
        GenericRepository<ProducedOrder> producedOrderDB = new(EnzDBContext.GetInstance);


        void FillList(ListView listView)
        {
            listView.Items.Clear();

            if (orderDetail != null)
            {
                foreach (var item in orderDetail.ProducedOrders)
                {
                    ListViewItem lvi = new()
                    {
                        Text = item.ProducedDate.ToShortDateString()
                    };

                    lvi.SubItems.Add(item.OrderDetail.Product.Name);
                    lvi.SubItems.Add(item.OrderDetail.Quantity.ToString());
                    lvi.SubItems.Add(item.OrderDetail.ProducedOrders.Sum(x => x.ProducedOrderCount).ToString());
                    lvi.SubItems.Add((item.OrderDetail.Quantity - item.OrderDetail.ProducedOrders.Sum(x => x.ProducedOrderCount)).ToString());

                    lvi.Tag = item;
                }
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void FillControls()
        {
            cbProduct.DisplayMember = "Name";
            cbProduct.Items.AddRange(productDB.GetAll().ToArray());
            if (orderDetail != null)
            {
                if (cbProduct.Items.Count > 0)
                {
                    cbProduct.SelectedIndex = cbProduct.Items.IndexOf(orderDetail.Product);
                }

                cbUnitCode.Items.AddRange(Enum.GetNames(typeof(UnitCode)).ToArray());
                nudQuantity.Value = orderDetail.Quantity;
                nudPrice.Value = orderDetail.UnitPrice;
                nudCost.Value = orderDetail.UnitCost;
            }

            FillList(lvProduceHistory);
        }

        private void FormOrderDetailAddEdit_Load(object sender, EventArgs e)
        {
            FillControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Done
        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            sb.Append($"{orderDetail.Order.JobNo} numaralı siparişe ait {orderDetail.Product}|{orderDetail.Quantity} sipariş detayı silinecektir?");
            sb.AppendLine("Onaylıyor musunuz?");

            if (MessageBox.Show(sb.ToString(), $"{orderDetail.Order.JobNo}|{orderDetail.ID}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                orderDetailDB.Delete(orderDetail);
                orderDetailDB.Save();
                this.Close();
            }
        }

        //Done
        private void btnSaveOrderDetail_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem != null)
            {
                orderDetail.Product = cbProduct.SelectedItem as Product;
                orderDetail.UnitPrice = nudPrice.Value;
                orderDetail.UnitCost = nudCost.Value;
                orderDetail.Quantity = nudQuantity.Value;
                orderDetail.UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbProduct.SelectedItem.ToString());
                orderDetailDB.Save();
            }
        }

        //Done
        private void btnAddProduceHistory_Click(object sender, EventArgs e)
        {
            producedOrderDB.Add(new ProducedOrder()
            {
                ProducedDate = dtpIssueDateAdd.Value,
                ProducedOrderCount = nudProducedCountAdd.Value
            });
        }

        //Done
        private void lvProduceHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                var po = (sender as ListView).Tag as ProducedOrder;

                dtpIssueDateEdit.Value = po.ProducedDate;
                nudProducedCountEdit.Value = po.ProducedOrderCount;
            }
        }

        //Done
        private void btnDeleteProduceHistory_Click(object sender, EventArgs e)
        {
            if (lvProduceHistory.SelectedItems.Count > 0)
            {
                producedOrderDB.Delete(orderDetail.ProducedOrders.Where(x => x == (lvProduceHistory.SelectedItems[0].Tag as ProducedOrder)).FirstOrDefault());
                producedOrderDB.Save();
            }
        }

        //Done
        private void btnSaveProduceHistory_Click(object sender, EventArgs e)
        {
            if (lvProduceHistory.SelectedItems.Count > 0)
            {
                var od = lvProduceHistory.SelectedItems[0].Tag as ProducedOrder;

                od.ProducedDate = dtpIssueDateEdit.Value;
                od.ProducedOrderCount = od.ProducedOrderCount;

                producedOrderDB.Save();
            }
        }
    }
}
