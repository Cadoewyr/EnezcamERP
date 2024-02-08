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

        void RefreshOrders(ListView listView, ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
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
        void RefreshProducts(ListView listView, ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
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
        void RefreshCustomers(ListView listView, ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
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
            RefreshOrders(lvOrders, columnHeaderAutoResizeStyle);
            RefreshProducts(lvProducts, columnHeaderAutoResizeStyle);
            RefreshCustomers(lvCustomers, columnHeaderAutoResizeStyle);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            InitialLists(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        //Order buttons
        #region
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            RefreshOrders(lvOrders, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                RefreshOrders(lvOrders, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                ordersDB.Delete(lvOrders.SelectedItems[0].Tag as Order);
                ordersDB.Save();

                RefreshOrders(lvOrders, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        #endregion

        //Product buttons
        //Done
        #region
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new();
            form.ShowDialog();
            RefreshProducts(lvProducts, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                UpdateProduct form = new(lvProducts.SelectedItems[0].Tag as Product);
                form.ShowDialog();
                RefreshProducts(lvProducts, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(lvProducts.SelectedItems.Count > 0)
            {
                productsDB.Delete(lvProducts.SelectedItems[0].Tag as Product);
                productsDB.Save();
                RefreshProducts(lvProducts, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshStock_Click(object sender, EventArgs e)
        {
            RefreshProducts(lvProducts, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        //Customer buttons
        //Done
        #region
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer form = new();
            form.ShowDialog();
            RefreshCustomers(lvCustomers, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                UpdateCustomer form = new(lvCustomers.SelectedItems[0].Tag as Customer);
                form.ShowDialog();
                RefreshCustomers(lvCustomers, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                customersDB.Delete(lvCustomers.SelectedItems[0].Tag as Customer);
                customersDB.Save();
                RefreshCustomers(lvCustomers, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            RefreshCustomers(lvCustomers, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion



        
    }
}
