using BL.Report.Enums;
using BL.Reports;
using BL.Reports.ProductionReports;
using BL.Reports.SalesReports;
using BL.Repositories.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Forms.Customer_Forms;
using EnezcamERP.Forms.DataGridColumnHeaderTemplates;
using EnezcamERP.Forms.Order_Forms;
using EnezcamERP.Forms.Produced_Product_Forms;
using EnezcamERP.Forms.Product_Forms;
using EnezcamERP.Forms.Yearly_Report_Cost_Form;

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

            var items = orders ?? (!string.IsNullOrEmpty(txtSearchOrder.Text) ? ordersDB.GetAll(txtSearchOrder.Text.Trim().ToLower()).Where(x => x.IsDone == cbIsDone.Checked | x.IsDone == false).Skip(50 * (PageNumber - 1)).Take(50) : ordersDB.GetAll().Where(x => x.IsDone == cbIsDone.Checked | x.IsDone == false).Skip(50 * (PageNumber - 1)).Take(50));

            if (cbDateFilter.Checked)
            {
                if (rbOrderDate.Checked)
                    items = ordersDB.GetAll(x => x.IssueDate >= mcDateFilter.SelectionStart.Date & x.IssueDate <= mcDateFilter.SelectionEnd.Date.AddDays(1).AddTicks(-1)).Skip(50 * (PageNumber - 1)).Take(50);
                else if (rbCompletedDate.Checked)
                    items = ordersDB.GetAll().AsEnumerable().Where(x => x.IsDone && x.CompletedDate >= mcDateFilter.SelectionStart.Date && x.CompletedDate <= mcDateFilter.SelectionEnd.Date.AddDays(1).AddTicks(-1)).Skip(50 * (PageNumber - 1)).Take(50).ToList();
                else if (rbDeliveryDate.Checked)
                    items = ordersDB.GetAll(x => x.DeliveryDate >= mcDateFilter.SelectionStart.Date & x.DeliveryDate <= mcDateFilter.SelectionEnd.Date.AddDays(1).AddTicks(-1)).Skip(50 * (PageNumber - 1)).Take(50);
            }

            List<ListViewItem> lviList = [];

            foreach (var item in items)
            {
                ListViewItem lvi = new()
                {
                    Text = item.JobNo.ToString(),
                    Tag = item,
                    UseItemStyleForSubItems = false
                };

                Color color;

                if (item.ProducedProductQuantity.Sum(x => x.Value) == 0)
                    color = Color.MediumVioletRed;
                else if (item.ProducedProductQuantity.Sum(x => x.Value) > 0 && !item.IsDone)
                    color = Color.MediumPurple;
                else if (item.IsDone)
                    color = Color.Green;
                else
                    color = Color.Black;

                lvi.SubItems.Add(item.Customer.Name);
                lvi.SubItems.Add(item.IssueDate.ToShortDateString());
                lvi.SubItems.Add(item.DeliveryDate.ToShortDateString());
                lvi.SubItems.Add(item.GetQuantityString());
                lvi.SubItems.Add(item.GetProducedQuantityString()).ForeColor = color;
                lvi.SubItems.Add(item.GetRemainingQuantityString()).ForeColor = color;
                lvi.SubItems.Add(item.Price.ToString("C2"));
                lvi.SubItems.Add(item.OrderDetails.Sum(x => x.FinalPriceWithTax).ToString("C2"));
                lvi.SubItems.Add(item.Profit.ToString("C2"));
                lvi.SubItems.Add(item.ProfitRatio.ToString("P2"));
                lvi.SubItems.Add(item.IsDone ? "Tamamlandý" : "Üretimde");
                lvi.SubItems.Add(item.IsDone & item.CompletedDate.HasValue ? item.CompletedDate.Value.ToShortDateString() : string.Empty);

                lviList.Add(lvi);
            }

            listView.Items.AddRange(lviList.ToArray());

            if (columnHeaderAutoResizeStyle != null)
                listView.AutoResizeColumns(columnHeaderAutoResizeStyle.Value);

            CheckExpiredOrders(false);
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
                lvi.SubItems.Add(ordersDB.GetAll(x => x.Customer.ID == item.ID).Sum(x => x.Price).ToString("C2"));

                listView.Items.Add(lvi);
            }

            if (columnHeaderAutoResizeStyle != null)
                listView.AutoResizeColumns(columnHeaderAutoResizeStyle.Value);
        }
        public void InitialReportForm()
        {
            MonthlyOutgoingsRepository monthlyOutgoingsRepository = new();

            if (monthlyOutgoingsRepository.GetByDate(dtpDate.Value.Year, dtpDate.Value.Month) != null)
                nudOutgoing.Value = monthlyOutgoingsRepository.GetByDate(dtpDate.Value.Year, dtpDate.Value.Month).Outgoing;
        }
        public void CheckExpiredOrders(bool checkListViewItems)
        {
            foreach (ListViewItem item in lvOrders.CheckedItems)
            {
                item.Checked = false;
            }

            int i = 0;

            foreach (ListViewItem item in lvOrders.Items)
            {
                if ((item.Tag as Order).DeliveryDate.Date <= DateTime.Now.Date && !(item.Tag as Order).IsDone)
                {
                    if (checkListViewItems)
                        item.Checked = true;
                    i++;
                }
            }

            btnExpiredOrders.Text = $"{i} gecikmiþ sipariþ";
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
                case ReportInterval.Yearly:
                    string[] months = ["Ocak", "Þubat", "Mart", "Nisan", "Mayýs", "Haziran", "Temmuz", "Aðustos", "Eylül", "Ekim", "Kasým", "Aralýk"];

                    foreach (var item in Template.DateRangedProduction)
                    {
                        dataGrid.Columns.Add(item.Key, item.Value);
                    }

                    var res = from item in report.DailyProductionReports
                              group item by item.Date.Month;

                    foreach (var group in res)
                    {
                        decimal profit = 0, profitRatioWithOutgoing = 0;
                        decimal gProfit = group.Sum(x => x.Profit), gCost = group.Sum(x => x.Cost), gPrice = group.Sum(x => x.Price), gCostWithoutOutgoing = group.Sum(x => x.CostWithOutgoing);

                        if (gProfit > 0 & gCost > 0)
                            profit = gProfit / gCost;

                        if (gPrice > 0 & gCostWithoutOutgoing > 0)
                            profitRatioWithOutgoing = (gPrice - gCostWithoutOutgoing) / gCostWithoutOutgoing;

                        dataGrid.Rows.Add(
                            months[group.Key - 1],
                            group.Sum(x => x.Price).ToString("C2"),
                            group.Sum(x => x.Cost).ToString("C2"),
                            group.Sum(x => x.Profit).ToString("C2"),
                            profit.ToString("P2"),
                            group.Sum(x => x.Outgoing).ToString("C2"),
                            group.Sum(x => x.CostWithOutgoing).ToString("C2"),
                            group.Sum(x => x.ProfitWithoutOutgoing).ToString("C2"),
                            profitRatioWithOutgoing.ToString("P2")
                            );
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

            txtPrice.Text = report.Price.ToString("C2");
            txtPriceTax.Text = report.PriceTax.ToString("C2");
            txtPriceWithTax.Text = report.PriceWithTax.ToString("C2");

            txtCost.Text = report.Cost.ToString("C2");
            txtCostTax.Text = report.CostTax.ToString("C2");
            txtCostWithTax.Text = report.CostWithTax.ToString("C2");

            txtProfit.Text = report.Profit.ToString("C2");
            txtOutgoing.Text = report.Outgoing.ToString("C2");
            txtProfitWithoutOutgoing.Text = report.ProfitWithoutOutgoing.ToString("C2");

            txtProfitMargin.Text = report.ProfitMargin.ToString("P2");
            txtProfitRatio.Text = report.ProfitRatioAfterOutgoing.ToString("P2");

            txtProducedQuantity.Text = report.GetProducedQuantityString();
            txtProcessQuantity.Text = report.GetProcessedQuantityString();
            txtStockQuantity.Text = report.GetStockQuantityString();
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
                case ReportInterval.Yearly:
                    string[] months = ["Ocak", "Þubat", "Mart", "Nisan", "Mayýs", "Haziran", "Temmuz", "Aðustos", "Eylül", "Ekim", "Kasým", "Aralýk"];

                    foreach (var item in Template.DateRangedProduction)
                    {
                        dataGrid.Columns.Add(item.Key, item.Value);
                    }

                    var res = from item in report.DailySalesReports
                              group item by item.Date.Month;

                    foreach (var group in res)
                    {
                        decimal profit = 0, profitRatioWithOutgoing = 0;
                        decimal gProfit = group.Sum(x => x.Profit), gCost = group.Sum(x => x.Cost), gPrice = group.Sum(x => x.Price), gCostWithoutOutgoing = group.Sum(x => x.CostWithOutgoing);

                        if (gProfit > 0 & gCost > 0)
                            profit = gProfit / gCost;

                        if (gPrice > 0 & gCostWithoutOutgoing > 0)
                            profitRatioWithOutgoing = (gPrice - gCostWithoutOutgoing) / gCostWithoutOutgoing;


                        if (group.Sum(x => x.Profit) > 0 & group.Sum(x => x.Cost) > 0)
                            profit = group.Sum(x => x.Profit) / group.Sum(x => x.Cost);

                        if (group.Sum(x => x.Price) > 0 & group.Sum(x => x.CostWithOutgoing) > 0)
                            profitRatioWithOutgoing = (group.Sum(x => x.Price) - group.Sum(x => x.CostWithOutgoing)) / group.Sum(x => x.CostWithOutgoing);

                        dataGrid.Rows.Add(
                            months[group.Key - 1],
                            group.Sum(x => x.Price).ToString("C2"),
                            group.Sum(x => x.Cost).ToString("C2"),
                            group.Sum(x => x.Profit).ToString("C2"),
                            profit.ToString("P2"),
                            group.Sum(x => x.Outgoing).ToString("C2"),
                            group.Sum(x => x.CostWithOutgoing).ToString("C2"),
                            group.Sum(x => x.ProfitWithoutOutgoing).ToString("C2"),
                            profitRatioWithOutgoing.ToString("P2")
                            );
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

            txtPrice.Text = report.Price.ToString("C2");
            txtPriceTax.Text = report.PriceTax.ToString("C2");
            txtPriceWithTax.Text = report.PriceWithTax.ToString("C2");

            txtCost.Text = report.Cost.ToString("C2");
            txtCostTax.Text = report.CostTax.ToString("C2");
            txtCostWithTax.Text = report.CostWithTax.ToString("C2");

            txtProfit.Text = report.Profit.ToString("C2");
            txtOutgoing.Text = report.Outgoing.ToString("C2");
            txtProfitWithoutOutgoing.Text = report.ProfitWithoutOutgoing.ToString("C2");

            txtProfitMargin.Text = report.ProfitRatio.ToString("P2");
            txtProfitRatio.Text = report.ProfitRatioAfterOutgoing.ToString("P2");

            txtProducedQuantity.Text = report.GetProduceQuantityString();
            txtProcessQuantity.Text = report.GetProcessQuantityString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitialLists(ColumnHeaderAutoResizeStyle.HeaderSize);
            CheckExpiredOrders(false);
            InitialReportForm();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime now = DateTime.Now;
            bool isEndOfWeek = now.DayOfWeek == DayOfWeek.Friday;

            DateTime lastDayOfMonth = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));

            if (lastDayOfMonth.DayOfWeek == DayOfWeek.Saturday || lastDayOfMonth.DayOfWeek == DayOfWeek.Sunday)
                lastDayOfMonth = lastDayOfMonth.AddDays(-(lastDayOfMonth.DayOfWeek == DayOfWeek.Saturday ? 1 : 2));

            bool isEndOfMonth = now.Date == lastDayOfMonth.Date;

            DateTime lastDayOfYear = new DateTime(now.Year, 12, 31);

            if (lastDayOfYear.DayOfWeek == DayOfWeek.Saturday || lastDayOfYear.DayOfWeek == DayOfWeek.Sunday)
                lastDayOfYear = lastDayOfYear.AddDays(-(lastDayOfYear.DayOfWeek == DayOfWeek.Saturday ? 1 : 2));

            bool isEndOfYear = now.Date == lastDayOfYear.Date;

            string[] reports = { "Yýllýk", "Aylýk", "Haftalýk" };

            List<string> selectedStrings = [];
            string questionString = " rapor almak ister misiniz?";
            string message = string.Empty;

            if (isEndOfWeek)
                selectedStrings.Add(reports[2]);
            if (isEndOfMonth)
                selectedStrings.Add(reports[1]);
            if (isEndOfYear)
                selectedStrings.Add(reports[0]);

            message = string.Join(", ", selectedStrings.ToArray()).ToString() + questionString;

            //Capitalize first letter
            message = char.ToUpper(message[0]) + message.Substring(1).ToLower();

            if (isEndOfYear || isEndOfMonth || isEndOfWeek)
            {
                DialogResult result = MessageBox.Show(message, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        //Order controls
        #region
        int _pageNumber = 1;
        int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                if (value >= 1 & value <= 999)
                {
                    _pageNumber = value;
                    lblPageNumber.Text = value.ToString();
                }
            }
        }

        void AddOrder()
        {
            AddUpdateOrder form = new(null);
            form.ShowDialog();
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void UpdateOrder()
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                AddUpdateOrder form = new(lvOrders.SelectedItems[0].Tag as Order);
                form.ShowDialog();
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        void DeleteOrder()
        {
            if (lvOrders.SelectedItems.Count > 0 & lvOrders.CheckedItems.Count == 0)
            {
                try
                {
                    if (MessageBox.Show("Sipariþ silinecek. Onaylýyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (ListViewItem item in lvOrders.SelectedItems)
                        {
                            ordersDB.Delete(item.Tag as Order);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (lvOrders.CheckedItems.Count > 0 && MessageBox.Show("Seçilen sipariþler silinecektir. Onaylýyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (ListViewItem item in lvOrders.CheckedItems)
                    {
                        ordersDB.Delete(item.Tag as Order);
                    }
                    RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        void EditProducedOrders()
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                EditProducedOrders form = new(this, lvOrders.SelectedItems[0].Tag as Order);
                form.ShowDialog();
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        void FillOrdersTotal()
        {
            if (lvOrders.SelectedItems.Count > 0 & lvOrders.CheckedItems.Count == 0)
            {
                txtTotalQuantity.Text = (lvOrders.SelectedItems[0].Tag as Order).GetQuantityString();
                txtTotalProducedQuantity.Text = (lvOrders.SelectedItems[0].Tag as Order).GetProducedQuantityString();
                txtTotalRemainingQuantity.Text = (lvOrders.SelectedItems[0].Tag as Order).GetRemainingQuantityString();

                txtTotalCost.Text = (lvOrders.SelectedItems[0].Tag as Order).Cost.ToString("C2");
                txtTotalPrice.Text = (lvOrders.SelectedItems[0].Tag as Order).Price.ToString("C2");
                txtTotalPriceWithTax.Text = (lvOrders.SelectedItems[0].Tag as Order).PriceWithTax.ToString("C2");
            }
            else if (lvOrders.CheckedItems.Count > 0)
            {
                Order tempOrder = new();

                foreach (ListViewItem item in lvOrders.CheckedItems)
                {
                    tempOrder.OrderDetails.AddRange((item.Tag as Order).OrderDetails.ToArray());
                }

                txtTotalQuantity.Text = tempOrder.GetQuantityString();
                txtTotalProducedQuantity.Text = tempOrder.GetProducedQuantityString();
                txtTotalRemainingQuantity.Text = tempOrder.GetRemainingQuantityString();

                txtTotalCost.Text = tempOrder.Cost.ToString("C2");
                txtTotalPrice.Text = tempOrder.Price.ToString("C2");
                txtTotalPriceWithTax.Text = tempOrder.PriceWithTax.ToString("C2");
            }
            else if (lvOrders.SelectedItems.Count == 0 & lvOrders.CheckedItems.Count == 0)
            {
                txtTotalQuantity.Text =
                txtTotalProducedQuantity.Text =
                txtTotalRemainingQuantity.Text =
                txtTotalCost.Text =
                txtTotalPrice.Text =
                txtTotalPriceWithTax.Text = string.Empty;
            }
        }
        private void checkDateFilter()
        {
            if (!cbIsDone.Checked)
                cbIsDone.Checked = cbDateFilter.Checked & rbCompletedDate.Checked;
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
        }
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            UpdateOrder();
        }
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }
        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            RefreshOrders(ordersDB.GetAll(txtSearchOrder.Text.Trim().ToLower()).Where(x => x.IsDone == cbIsDone.Checked | x.IsDone == false).Skip(50 * (PageNumber - 1)).Take(50).ToArray(), ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void cbIsDone_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btnEditProducedOrders_Click(object sender, EventArgs e)
        {
            EditProducedOrders();
        }
        private void cbDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            checkDateFilter();

            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            mcDateFilter.Enabled = cbDateFilter.Checked;
            rbOrderDate.Enabled = cbDateFilter.Checked;
            rbCompletedDate.Enabled = cbDateFilter.Checked;
            rbDeliveryDate.Enabled = cbDateFilter.Checked;
        }
        private void mcDateFilter_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (cbDateFilter.Checked)
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void DateFilterSettingsChanged(object sender, EventArgs e)
        {
            checkDateFilter();

            if (cbDateFilter.Checked)
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillOrdersTotal();
        }
        private void lvOrders_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            FillOrdersTotal();
        }
        private void txtSearchOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                e.Handled = true;
            }
        }
        private void btnExpiredOrders_Click(object sender, EventArgs e)
        {
            CheckExpiredOrders(true);
        }

        //Pagination controls
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            PageNumber = 1;
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            PageNumber -= 1;
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PageNumber += 1;
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)ordersDB.TotalCount() / 50);
            PageNumber = totalPages;
            RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        //Tool strip controls
        #region
        private void cmsOrders_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = lvOrders.SelectedItems.Count == 0;
        }
        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder();
        }
        private void updateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrder();
        }
        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }
        private void productionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProducedOrders();
        }
        private void completeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((lvOrders.SelectedItems.Count > 0 & lvOrders.CheckedItems.Count == 0) && MessageBox.Show("Seçilen sipariþler tamamlanacak. Onaylýyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvOrders.SelectedItems)
                {
                    Order order = item.Tag as Order;

                    foreach (var orderDetail in order.OrderDetails)
                    {
                        if (orderDetail.RemainingToProduceQuantity > 0)
                        {
                            orderDetail.ProducedOrders.Add(new()
                            {
                                IsStock = false,
                                OrderDetail = orderDetail,
                                ProducedDate = DateTime.Now,
                                ProducedOrderQuantity = orderDetail.RemainingToProduceQuantity
                            });
                        }
                    }
                }

                EnzDBContext.GetInstance.SaveChanges();
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else if (lvOrders.CheckedItems.Count > 0 && MessageBox.Show("Seçilen sipariþler tamamlanacak. Onaylýyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvOrders.CheckedItems)
                {
                    Order order = item.Tag as Order;

                    foreach (var orderDetail in order.OrderDetails)
                    {
                        if (orderDetail.RemainingToProduceQuantity > 0)
                        {
                            orderDetail.ProducedOrders.Add(new()
                            {
                                IsStock = false,
                                OrderDetail = orderDetail,
                                ProducedDate = DateTime.Now,
                                ProducedOrderQuantity = orderDetail.RemainingToProduceQuantity
                            });
                        }
                    }
                }
                EnzDBContext.GetInstance.SaveChanges();
                RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvOrders.Items)
            {
                item.Checked = true;
            }
        }
        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvOrders.CheckedItems)
            {
                item.Checked = false;
            }
        }
        private void selectSameCustomersOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvOrders.Items)
                {
                    item.Checked = (lvOrders.SelectedItems[0].Tag as Order).Customer.ID == (item.Tag as Order).Customer.ID;
                }
            }
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

            if (!string.IsNullOrEmpty(control.Text.Trim()))
            {
                var res = productsDB.GetAll(control.Text.Trim().ToLower());
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
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            var interval = rbDaily.Checked ? ReportInterval.Daily : (rbWeekly.Checked ? ReportInterval.Weekly : (rbMonthly.Checked ? ReportInterval.Monthly : (rbYearly.Checked ? ReportInterval.Yearly : ReportInterval.Daily)));

            if (interval == ReportInterval.Yearly)
            {
                FormYearlyReportCosts form = new(dtpDate.Value.Year);
                form.ShowDialog();
            }

            if (rbProduction.Checked)
                FillProductionReport(dgReport, (DateRangedProductionReport)ReportCreator<DateRangedProductionReport>.Create(dtpDate.Value.Date, interval, nudOutgoing.Value, cbCalculateAllInterval.Checked, cbIsOvertime.Checked));
            else if (rbSales.Checked)
                FillSalesReport(dgReport, (DateRangedSalesReport)ReportCreator<DateRangedSalesReport>.Create(dtpDate.Value.Date, interval, nudOutgoing.Value, cbCalculateAllInterval.Checked, cbIsOvertime.Checked));

            if (!cbIsOvertime.Checked & new MonthlyOutgoingsRepository().GetByDate(dtpDate.Value.Year, dtpDate.Value.Month) != null)
                new MonthlyOutgoingsRepository().Update(new()
                {
                    Year = dtpDate.Value.Year,
                    Month = dtpDate.Value.Month,
                    Outgoing = nudOutgoing.Value
                }, new MonthlyOutgoingsRepository().GetByDate(dtpDate.Value.Year, dtpDate.Value.Month).ID);

            else if (!cbCalculateAllInterval.Checked)
                new MonthlyOutgoingsRepository().Add(new()
                {
                    Year = dtpDate.Value.Year,
                    Month = dtpDate.Value.Month,
                    Outgoing = nudOutgoing.Value
                });

            (sender as Button).Enabled = true;
        }

        private void btnCopyTable_Click(object sender, EventArgs e)
        {
            if (dgReport.Rows.Count > 0)
            {
                dgReport.SelectAll();
                Clipboard.SetDataObject(dgReport.GetClipboardContent());
                dgReport.ClearSelection();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (new MonthlyOutgoingsRepository().GetByDate((sender as DateTimePicker).Value.Year, (sender as DateTimePicker).Value.Month) != null)
                nudOutgoing.Value = new MonthlyOutgoingsRepository().GetByDate((sender as DateTimePicker).Value.Year, (sender as DateTimePicker).Value.Month).Outgoing;
        }

        private void cbIsOvertime_CheckedChanged(object sender, EventArgs e)
        {
            decimal outgoing = new MonthlyOutgoingsRepository().GetByDate(dtpDate.Value.Year, dtpDate.Value.Month).Outgoing;

            if (!(sender as CheckBox).Checked)
                nudOutgoing.Value = outgoing == null ? 0 : outgoing;
        }
        #endregion

        //General controls
        #region
        private void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                var obj = (sender as ListView).SelectedItems[0].Tag;

                try
                {
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
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        #endregion

        private void btnUpdatePriceHistory_Click(object sender, EventArgs e)
        {
            List<Product> products = [];

            foreach (ListViewItem item in lvProducts.CheckedItems)
            {
                var product = item.Tag as Product;
                var orderDetails = new OrderDetailsRepository().GetAll(x => x.Product.ID == product.ID).ToList();
                var today = DateTime.Now;

                var closestOrder = orderDetails.OrderBy(x => Math.Abs((x.CreatedAt.Date - today).TotalDays)).FirstOrDefault();

                if (closestOrder != null)
                {
                    product.PriceHistory.LastCost = closestOrder.Cost;
                    product.PriceHistory.LastPrice = closestOrder.Price;
                }
            }

            RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}