using BL.Report.Enums;
using BL.Reports;
using BL.Reports.ProductionReports;
using BL.Reports.SalesReports;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Forms.Customer_Forms;
using EnezcamERP.Forms.DataGridColumnHeaderTemplates;
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

            var items = orders ?? ordersDB.GetAll(txtSearchOrder.Text.Trim().ToLower());

            if (cbDateFilter.Checked)
            {
                if (rbOrderDate.Checked)
                    items = items.Where(x => x.IssueDate >= mcDateFilter.SelectionStart.Date & x.IssueDate <= mcDateFilter.SelectionEnd.Date.AddDays(1).AddTicks(-1));
                else if (rbCompletedDate.Checked)
                    items = items.Where(x => x.IsDone & x.CompletedDate >= mcDateFilter.SelectionStart.Date & x.CompletedDate <= mcDateFilter.SelectionEnd.Date.AddDays(1).AddTicks(-1));
            }

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
                lvi.SubItems.Add(item.OrderDetails.Sum(x => x.FinalPriceWithTax).ToString("C2"));
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

            var items = products ?? productsDB.GetAll(txtSearchProduct.Text);

            foreach (var item in items)
            {
                ListViewItem lvi = new()
                {
                    Text = item.Name,
                    Tag = item
                };

                lvi.SubItems.Add(item.Code);
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

            var items = customers ?? customersDB.GetAll(txtSearchCustomer.Text);

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

        void FillProductionReport(DataGridView dataGrid, DateRangedProductionReport report)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            switch (report.Interval)
            {
                case ReportInterval.Daily:
                    foreach (var item in Template.DailyProduction)
                    {
                        dataGrid.Columns.Add(item.Key, item.Value);
                    }

                    foreach (var item in report.DailyProductionReports)
                    {
                        foreach (var r in item.DailyProductionEntries)
                        {
                            dataGrid.Rows.Add(
                                r.IssueDate.ToShortDateString(),
                                r.CustomerName,
                                r.JobNo.ToString(),
                                r.ProductName,
                                r.ProductType.ToString(),
                                r.Quantity.ToString("N3"),
                                r.UnitCode.ToString(),
                                r.FinalUnitPrice.ToString("C2"),
                                r.FinalPrice.ToString("C2"),
                                item.GetCustomerTotal(r.JobNo).ToString("C2"),
                                r.UnitCost.ToString("C2"),
                                r.Cost.ToString("C2"),
                                r.Profit.ToString("C2"),
                                r.ProfitRatio.ToString("P0")
                                );
                        }
                    }
                    break;
                default:
                    foreach (var item in Template.DateRangedProduction)
                    {
                        dataGrid.Columns.Add(item.Key, item.Value);
                    }

                    foreach (var r in report.DailyProductionReports)
                    {
                        dataGrid.Rows.Add(
                            r.Date.ToShortDateString(),
                            r.Price.ToString("C2"),
                            r.Cost.ToString("C2"),
                            r.Profit.ToString("C2"),
                            r.ProfitRatio.ToString("P2"),
                            r.Outgoing.ToString("C2"),
                            r.CostWithOutgoing.ToString("C2"),
                            r.ProfitWithoutOutgoing.ToString("C2"),
                            r.ProfitRatioWithOutgoing.ToString("P2")
                            );
                    }
                    break;
            }
        }
        void FillSalesReport(DataGridView dataGrid, DateRangedSalesReport report)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            switch (report.Interval)
            {
                case ReportInterval.Daily:
                    foreach (var item in Template.DailySales)
                    {
                        dataGrid.Columns.Add(item.Key, item.Value);
                    }

                    foreach (var item in report.DailySalesReports)
                    {
                        foreach (var r in item.DailySalesEntries)
                        {
                            dataGrid.Rows.Add(
                                r.IssueDate.ToShortDateString(),
                                r.CustomerName,
                                r.JobNo.ToString(),
                                r.ProductName,
                                (r.TaxRatio / 100).ToString("P0"),
                                r.Quantity.ToString("N3"),
                                r.UnitCode.ToString(),
                                r.FinalUnitPrice.ToString("C2"),
                                r.FinalPrice.ToString("C2"),
                                item.GetCustomerTotal(r.JobNo).ToString("C2"),
                                r.UnitCost.ToString("C2"),
                                r.Cost.ToString("C2"),
                                r.Profit.ToString("C2"),
                                r.ProfitRatio.ToString("P0")
                                );
                        }
                    }
                    break;
                default:
                    foreach (var item in Template.DateRangedSales)
                    {
                        dataGrid.Columns.Add(item.Key, item.Value);
                    }

                    foreach (var r in report.DailySalesReports)
                    {
                        dataGrid.Rows.Add(
                            r.Date.ToShortDateString(),
                            r.Price.ToString("C2"),
                            r.Cost.ToString("C2"),
                            r.Profit.ToString("C2"),
                            r.ProfitRatio.ToString("P2"),
                            r.Outgoing.ToString("C2"),
                            r.CostWithOutgoing.ToString("C2"),
                            r.ProfitWithoutOutgoing.ToString("C2"),
                            r.ProfitRatioWithOutgoing.ToString("P2")
                            );
                    }
                    break;
            }
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
            RefreshOrders(ordersDB.GetAll(txtSearchOrder.Text).ToArray(), ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
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
            rbOrderDate.Enabled = cbDateFilter.Checked;
            rbCompletedDate.Enabled = cbDateFilter.Checked;
        }

        private void mcDateFilter_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (cbDateFilter.Checked)
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                var obj = (sender as ListView).SelectedItems[0].Tag;

                switch (e.KeyData)
                {
                    case Keys.Delete:
                        if (obj is Product)
                        {
                            productsDB.Delete(obj as Product);
                            RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        else if (obj is Customer)
                        {
                            customersDB.Delete(obj as Customer);
                            RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        else if (obj is Order)
                        {
                            ordersDB.Delete(obj as Order);
                            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        break;
                }
            }
        }

        private void DateFilterSettingsChanged(object sender, EventArgs e)
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

        //Report controls
        #region
        private void btnCreateProductionReport_Click(object sender, EventArgs e)
        {
            var interval = rbDaily.Checked ? ReportInterval.Daily : (rbWeekly.Checked ? ReportInterval.Weekly : (rbMonthly.Checked ? ReportInterval.Monthly : (rbYearly.Checked ? ReportInterval.Yearly : ReportInterval.Daily)));

            if (rbProduction.Checked)
                FillProductionReport(dgReport, (DateRangedProductionReport)ReportCreator<DateRangedProductionReport>.Create(dtpDate.Value.Date, interval, nudOutgoing.Value));
            else if (rbSales.Checked)
                FillSalesReport(dgReport, (DateRangedSalesReport)ReportCreator<DateRangedSalesReport>.Create(dtpDate.Value.Date, interval, nudOutgoing.Value));
        }

        private void btnCopyTable_Click(object sender, EventArgs e)
        {
            dgReport.SelectAll();
            Clipboard.SetDataObject(dgReport.GetClipboardContent());
            dgReport.ClearSelection();
        }
        #endregion
    }
}
