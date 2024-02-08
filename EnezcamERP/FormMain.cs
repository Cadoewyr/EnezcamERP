using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Forms.Customer_Forms;
using EnezcamERP.Forms.Product_Forms;

namespace EnezcamERP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        GenericRepository<Order> ordersDB = new(EnzDBContext.GetInstance);
        GenericRepository<Product> productsDB = new(EnzDBContext.GetInstance);
        GenericRepository<Customer> customersDB = new(EnzDBContext.GetInstance);

        public void RefreshOrders(ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            ListView listView = lvOrders;
            listView.Items.Clear();

            foreach (var item in ordersDB.GetAll())
            {
                ListViewItem lvi = new()
                {
                    Text = item.JobNo.ToString(),
                    Tag = item
                };

                lvi.SubItems.Add(item.Customer.Name);
                lvi.SubItems.Add(item.IssueDate.ToShortDateString());
                lvi.SubItems.Add(item.ProductCount.ToString());
                lvi.SubItems.Add(item.ProducedProductCount.ToString());
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.ProducedPrice.ToString());
                lvi.SubItems.Add(item.Cost.ToString());
                lvi.SubItems.Add(item.ProducedCost.ToString());
                lvi.SubItems.Add(item.Profit.ToString());
                lvi.SubItems.Add(item.ProducedProfit.ToString());
                lvi.SubItems.Add(item.ProfitPercentage.ToString());
                lvi.SubItems.Add(item.ProducedProfitPercentage.ToString());

                listView.Items.Add(lvi);
            }
        }
        public void RefreshProducts(ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            ListView listView = lvProducts;
            listView.Items.Clear();

            foreach (var item in productsDB.GetAll())
            {
                ListViewItem lvi = new()
                {
                    Text = item.Name,
                    Tag = item
                };

                lvi.SubItems.Add(item.Type.ToString());

                listView.Items.Add(lvi);
            }
        }
        public void RefreshCustomers(ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            ListView listView = lvCustomers;
            listView.Items.Clear();

            foreach (var item in customersDB.GetAll())
            {
                ListViewItem lvi = new()
                {
                    Text = item.Name,
                    Tag = item
                };

                lvi.SubItems.Add(item.Country);
                lvi.SubItems.Add(item.City);
                lvi.SubItems.Add(item.Description);
                lvi.SubItems.Add(item.ContactName);
                lvi.SubItems.Add(item.ContactPhone);

                listView.Items.Add(lvi);
            }

            if (columnHeaderAutoResizeStyle != null)
                listView.AutoResizeColumns(columnHeaderAutoResizeStyle.Value);
        }

        void InitialLists(ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            RefreshOrders(columnHeaderAutoResizeStyle);
            RefreshProducts(columnHeaderAutoResizeStyle);
            RefreshCustomers(columnHeaderAutoResizeStyle);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitialLists(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Order buttons
        #region
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            RefreshOrders(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                RefreshOrders(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                ordersDB.Delete(lvOrders.SelectedItems[0].Tag as Order);
                ordersDB.Save();

                RefreshOrders(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        #endregion

        //Product buttons
        //Done
        #region
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new(this);
            form.ShowDialog();
            RefreshProducts(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                UpdateProduct form = new(this, lvProducts.SelectedItems[0].Tag as Product);
                form.ShowDialog();
                RefreshProducts(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(lvProducts.SelectedItems.Count > 0)
            {
                productsDB.Delete(lvProducts.SelectedItems[0].Tag as Product);
                productsDB.Save();
                RefreshProducts(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshStock_Click(object sender, EventArgs e)
        {
            RefreshProducts(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        //Customer buttons
        //Done
        #region
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer form = new();
            form.ShowDialog();
            RefreshCustomers(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                UpdateCustomer form = new(lvCustomers.SelectedItems[0].Tag as Customer);
                form.ShowDialog();
                RefreshCustomers(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                customersDB.Delete(lvCustomers.SelectedItems[0].Tag as Customer);
                customersDB.Save();
                RefreshCustomers(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            RefreshCustomers(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion
    }
}
