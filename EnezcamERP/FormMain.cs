using BL.Report.Enums;
using BL.Reports;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Forms.Customer_Forms;
using EnezcamERP.Forms.Order_Forms;
using EnezcamERP.Forms.Produced_Product_Forms;
using EnezcamERP.Forms.Product_Forms;

namespace EnezcamERP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        OrderRepository ordersDB = new();
        ProductRepository productsDB = new();
        CustomerRepository customersDB = new();

        public void RefreshOrders(ICollection<Order>? orders, ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            ListView listView = lvOrders;
            listView.Items.Clear();

            var items = orders ?? (cbDateFilter.Checked ? ordersDB.GetAll(x => (x.IssueDate >= mcDateFilter.SelectionStart & x.IssueDate <= mcDateFilter.SelectionEnd)) : ordersDB.GetAll());

            foreach (var item in items.Where(x => x.IsDone == cbIsDone.Checked | x.IsDone == false))
            {
                ListViewItem lvi = new()
                {
                    Text = item.JobNo.ToString(),
                    Tag = item
                };

                lvi.SubItems.Add(item.Customer.Name);
                lvi.SubItems.Add(item.IssueDate.ToShortDateString());
                lvi.SubItems.Add(string.Join(", ", item.ProductQuantity.Select(x => $"{x.Value.ToString(x.Key == UnitCode.M2 ? "N3" : "N0")} {x.Key}").ToArray()));
                lvi.SubItems.Add(string.Join(", ", item.ProducedProductQuantity.Select(x => $"{x.Value.ToString(x.Key == UnitCode.M2 ? "N3" : "N0")} {x.Key}").ToArray()));
                lvi.SubItems.Add(item.Cost.ToString("C2"));
                lvi.SubItems.Add(item.Price.ToString("C2"));
                lvi.SubItems.Add(item.OrderDetails.Sum(x => x.PriceWithTax).ToString("C2"));
                lvi.SubItems.Add(item.Profit.ToString("C2"));
                lvi.SubItems.Add(item.ProfitRatio.ToString("P2"));
                lvi.SubItems.Add(item.IsDone ? "Tamamlandý" : "Üretimde");

                listView.Items.Add(lvi);
            }

            if (columnHeaderAutoResizeStyle != null)
                listView.AutoResizeColumns(columnHeaderAutoResizeStyle.Value);
        }
        public void RefreshProducts(ICollection<Product>? products, ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            ListView listView = lvProducts;
            listView.Items.Clear();

            var items = products ?? productsDB.GetAll();

            foreach (var item in items)
            {
                ListViewItem lvi = new()
                {
                    Text = item.Name,
                    Tag = item
                };

                lvi.SubItems.Add(item.Type.ToString());
                lvi.SubItems.Add(item.IsCounting == true ? "Evet" : "Hayýr");
                lvi.SubItems.Add(item.PriceHistory.LastCost.ToString("C2"));
                lvi.SubItems.Add(item.PriceHistory.LastPrice.ToString("C2"));
                lvi.SubItems.Add(item.PriceHistory.LastProfit.ToString("C2"));
                lvi.SubItems.Add(item.PriceHistory.LastProfitRatio.ToString("P2"));

                listView.Items.Add(lvi);
            }

            if (columnHeaderAutoResizeStyle != null)
                listView.AutoResizeColumns(columnHeaderAutoResizeStyle.Value);
        }
        public void RefreshCustomers(ICollection<Customer>? customers, ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            ListView listView = lvCustomers;
            listView.Items.Clear();

            var items = customers ?? customersDB.GetAll();

            foreach (var item in items)
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
                lvi.SubItems.Add(item.Address);

                listView.Items.Add(lvi);
            }

            if (columnHeaderAutoResizeStyle != null)
                listView.AutoResizeColumns(columnHeaderAutoResizeStyle.Value);
        }

        void InitialLists(ColumnHeaderAutoResizeStyle? columnHeaderAutoResizeStyle)
        {
            RefreshOrders(null, columnHeaderAutoResizeStyle);
            RefreshProducts(null, columnHeaderAutoResizeStyle);
            RefreshCustomers(null, columnHeaderAutoResizeStyle);
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            InitialLists(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Order controls
        #region
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddUpdateOrder form = new(null);
            form.ShowDialog();
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                AddUpdateOrder form = new(lvOrders.SelectedItems[0].Tag as Order);
                form.ShowDialog();
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                try
                {
                    ordersDB.Delete(lvOrders.SelectedItems[0].Tag as Order);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void cbIsDone_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnEditProducedOrders_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                EditProducedOrders form = new(this, lvOrders.SelectedItems[0].Tag as Order);
                form.ShowDialog();
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void cbDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            mcDateFilter.Enabled = cbDateFilter.Checked;
        }

        private void mcDateFilter_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (cbDateFilter.Checked)
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        //Product controls
        #region
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new(this);
            form.ShowDialog();
            RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                UpdateProduct form = new(this, lvProducts.SelectedItems[0].Tag as Product);
                form.ShowDialog();
                RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                try
                {
                    productsDB.Delete(lvProducts.SelectedItems[0].Tag as Product);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshStock_Click(object sender, EventArgs e)
        {
            RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            var control = (sender as TextBox);

            if (!string.IsNullOrEmpty(control.Text))
            {
                var res = productsDB.GetAll(control.Text.ToLower());
                RefreshProducts(res.ToArray(), ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
                RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        //Customer controls
        #region
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer form = new(this);
            form.ShowDialog();
            RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                UpdateCustomer form = new(this, lvCustomers.SelectedItems[0].Tag as Customer);
                form.ShowDialog();
                RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count > 0)
            {
                try
                {
                    customersDB.Delete(lvCustomers.SelectedItems[0].Tag as Customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            var control = (sender as TextBox);

            if (!string.IsNullOrEmpty(control.Text))
            {
                var res = customersDB.GetAll(control.Text.ToLower());
                RefreshCustomers(res.ToArray(), ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
                RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        //Production report controls
        #region
        private void btnCreateProductionReport_Click(object sender, EventArgs e)
        {
            dgReport.Rows.Clear();
            dgReport.Columns.Clear();

            var report = ReportCreator.CreateDailyReport(rbSales.Checked ? ReportType.Sales : ReportType.Production, dtpDate.Value.Date, 64046);

            dgReport.Columns.Add("clmDate", "Tarih");
            dgReport.Columns.Add("clmCustomerName", "Cari Adý");
            dgReport.Columns.Add("clmJobNo", "Sipariþ No");
            dgReport.Columns.Add("clmProductName", "Ürün Adý");
            dgReport.Columns.Add("clmProcessType", "Tür");
            dgReport.Columns.Add("clmQuantity", "Miktar");
            dgReport.Columns.Add("clmUnitCode", "Birim");
            dgReport.Columns.Add("clmUnitPrice", "Birim Fiyat");
            dgReport.Columns.Add("clmPrice", "Fiyat");
            dgReport.Columns.Add("clmCustomerTotal", "Cari Toplam Tutarý");
            dgReport.Columns.Add("clmUnitCost", "Birim Maliyet");
            dgReport.Columns.Add("clmCost", "Maliyet");
            dgReport.Columns.Add("clmProfit", "Kar");
            dgReport.Columns.Add("clmProfitRatio", "Kar Oraný");

            foreach (var order in report.Orders)
            {
                foreach (var orderDetail in order.OrderDetails)
                {
                    dgReport.Rows.Add(
                        order.IssueDate.ToShortDateString(),
                        order.Customer.Name,
                        order.JobNo.ToString(),
                        orderDetail.Product.Name,
                        orderDetail.Product.Type.ToString(),
                        orderDetail.Quantity.ToString("N3"),
                        orderDetail.UnitCode.ToString(),
                        orderDetail.UnitPrice.ToString("C2"),
                        orderDetail.Price.ToString("C2"),
                        order.Price.ToString("C2"),
                        orderDetail.UnitCost.ToString("N2"),
                        orderDetail.Cost.ToString("C2"),
                        orderDetail.Profit.ToString("C2"),
                        orderDetail.ProfitRatio.ToString("P0")
                        );
                }
            }
        }
        #endregion


    }
}
