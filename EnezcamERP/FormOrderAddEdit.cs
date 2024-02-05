using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;

namespace EnezcamERP
{
    public partial class FormOrderAddEdit : Form
    {
        public FormOrderAddEdit()
        {
            InitializeComponent();
        }

        public FormOrderAddEdit(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        Order order;
        GenericRepository<OrderDetail> orderDetailDB = new(EnzDBContext.GetInstance);
        bool isChanged = false;

        void FillList(Order order)
        {
            lvOrderDetails.Items.Clear();

            foreach (var orderDetail in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Text = orderDetail.Product.Name
                };

                lvi.SubItems.Add(orderDetail.Product.Type.ToString());
                lvi.SubItems.Add(orderDetail.UnitCode.ToString());
                lvi.SubItems.Add(orderDetail.Quantity.ToString());
                lvi.SubItems.Add(orderDetail.TotalCost.ToString());
                lvi.SubItems.Add(orderDetail.TotalProfit.ToString());

                lvi.Tag = orderDetail;

                lvOrderDetails.Items.Add(lvi);
            }

            lvOrderDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvOrderDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void FillControls(Order order)
        {
            if (order != null)
            {
                txtJobNo.Text = order.JobNo.ToString();
                txtCustomer.Text = order.Customer;
                dtpIssueDate.Value = order.IssueDate;
                txtTotalPrice.Text = order.Price.ToString();
                txtTotalCost.Text = order.Cost.ToString();
                txtProfit.Text = order.Profit.ToString();
                txtProfitPercentage.Text = order.ProfitPercentage.ToString();
                txtTotalCount.Text = order.OrderDetails.Sum(x => x.Quantity).ToString();
                txtTotalProduced.Text = order.OrderDetails.Sum(x => x.ProducedOrders.Sum(w => w.ProducedOrderCount)).ToString();

                FillList(order);
            }
        }

        private void FormOrderAddEdit_Shown(object sender, EventArgs e)
        {
            if (order != null)
                FillControls(order);
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.SelectedItems.Count > 0)
            {
                OrderDetail od = lvOrderDetails.SelectedItems[0].Tag as OrderDetail;

                if (od != null)
                {
                    orderDetailDB.Delete(od);

                    FillControls(order);
                }
            }
        }

        private void btnEditOrderDetail_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.SelectedItems.Count > 0)
            {
                FormOrderDetailAddEdit form = new(lvOrderDetails.SelectedItems[0].Tag as OrderDetail);
                form.ShowDialog(this);

                FillControls(order);
            }
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            FormOrderDetailAddEdit form = new(order);
            form.ShowDialog(this);

            FillControls(order);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (isChanged)
                orderDetailDB.Save();
        }

        private void Changed(object sender, EventArgs e)
        {
            isChanged = true;
        }
    }
}
