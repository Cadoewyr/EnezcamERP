using BL.Repositories.Repositories;
using BL.Validators.Validators;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;

namespace EnezcamERP.Forms.Order_Forms
{
    public partial class AddUpdateOrder : Form
    {
        public AddUpdateOrder(Order? order)
        {
            InitializeComponent();
            InitializeForm();
            this.order = order ?? new();

            if (order != null)
            {
                LoadOrder(order);
                IsUpdate = true;
            }
            else
                IsUpdate = false;
        }

        public void InitializeForm()
        {
            RefreshCustomers();
            RefreshProducts(null);
            RefreshUnitCode();
        }

        public void RefreshCustomers()
        {
            cbCustomers.Items.Clear();

            cbCustomers.Items.AddRange(customerDB.GetAll().ToArray());

            cbCustomers.DisplayMember = "Name";
        }
        public void RefreshProducts(Product[]? products)
        {
            lvProducts.Items.Clear();

            products ??= productDB.GetAll(txtSearchProduct.Text.Trim().ToLower()).ToArray();

            foreach (var product in products)
            {
                ListViewItem lvi = new()
                {
                    Text = product.Code,
                    Tag = product
                };

                lvi.SubItems.Add(product.Name);
                lvi.SubItems.Add(product.Type.ToString());
                lvi.SubItems.Add(product.PriceHistory.LastCost.ToString("C2"));
                lvi.SubItems.Add(product.PriceHistory.LastPrice.ToString("C2"));
                lvi.SubItems.Add(product.IsCounting ? "Dahil" : "Dahil Değil");

                lvProducts.Items.Add(lvi);
            }

            lvProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void RefreshUnitCode()
        {
            cbUnitCode.Items.Clear();
            cbUnitCode.Items.AddRange(Enum.GetNames(typeof(UnitCode)).ToArray().Reverse().ToArray());
            cbUnitCode.SelectedIndex = 0;
        }
        public void RefreshOrderDetails(ColumnHeaderAutoResizeStyle columnHeaderAutoResizeStyle)
        {
            lvOrderDetails.Items.Clear();

            ColumnHeader clmDiscountedUnitPrice = new()
            {
                Name = "clmDiscountedUnitPrice",
                Text = "İskontolu Birim Fiyat",
                DisplayIndex = 9
            };
            ColumnHeader clmDiscountRatio = new()
            {
                Name = "clmDiscountRatio",
                Text = "İskonto Oranı",
                DisplayIndex = 10
            };

            foreach (var item in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Tag = item,
                    Text = item.Product.Code
                };

                lvi.SubItems.Add(item.Product.Name);
                lvi.SubItems.Add(item.GetSizeString());
                lvi.SubItems.Add(item.UnitArea.ToString("N3"));
                lvi.SubItems.Add(item.TotalArea.ToString("N3"));
                lvi.SubItems.Add(item.Quantity.ToString("N0"));
                lvi.SubItems.Add(item.UnitCode.ToString());
                lvi.SubItems.Add(item.UnitCost.ToString("C2"));
                lvi.SubItems.Add(item.UnitPrice.ToString("C2"));
                if (order.OrderDetails.Any(x => x.DiscountRatio > 0))
                {
                    if (!lvOrderDetails.Columns.Contains(clmDiscountedUnitPrice))
                        lvOrderDetails.Columns.Insert(9, clmDiscountedUnitPrice);

                    if (!lvOrderDetails.Columns.Contains(clmDiscountRatio))
                        lvOrderDetails.Columns.Insert(10, clmDiscountRatio);

                    lvi.SubItems.Add(item.FinalUnitPrice.ToString("C2"));
                    lvi.SubItems.Add((item.DiscountRatio / 100).ToString("P0"));
                }
                lvi.SubItems.Add((item.TaxRatio / 100).ToString("P0"));
                lvi.SubItems.Add(item.GetProducedQuantityString());
                lvi.SubItems.Add(item.GetRemainingQuantityString());
                lvi.SubItems.Add(item.Cost.ToString("C2"));
                lvi.SubItems.Add(item.FinalPrice.ToString("C2"));
                lvi.SubItems.Add(item.Profit.ToString("C2"));
                lvi.SubItems.Add(item.ProfitRatio.ToString("P2"));

                lvOrderDetails.Items.Add(lvi);
            }

            lvOrderDetails.AutoResizeColumns(columnHeaderAutoResizeStyle);
        }
        public void LoadOrder(Order order)
        {
            this.Text = "Sipariş Güncelle";
            btnSaveOrder.Text = "Güncelle";

            txtJobNo.Text = order.JobNo.ToString();
            cbCustomers.SelectedIndex = cbCustomers.Items.IndexOf(order.Customer);
            dtpOrderDate.Value = order.IssueDate;
            dtpDeliveryDate.Value = order.DeliveryDate;

            UpdateOrderTotals(order);

            RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void UpdateOrderTotals(Order order)
        {
            txtTotalCost.Text = order.Cost.ToString("C2");
            txtTotalPrice.Text = order.Price.ToString("C2");
            txtProfit.Text = order.Profit.ToString("C2");
            txtProfitRatio.Text = order.ProfitRatio.ToString("P2");
            txtTotalQuantity.Text = order.GetQuantityString();
            txtPriceWithTax.Text = order.PriceWithTax.ToString("C2");
            txtProducedQuantity.Text = order.GetProducedQuantityString();
            txtRemainingQuantity.Text = order.GetRemainingQuantityString();
        }
        void ClearNumericUpDownControls(params Control[] controls)
        {
            foreach (var control in controls)
            {
                (control as NumericUpDown).Value = 1;
            }
        }

        CustomerRepository customerDB = new();
        OrderRepository orderDB = new();
        ProductRepository productDB = new();

        Order order;
        bool IsUpdate;

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                OrderDetail od = new()
                {
                    Order = order,
                    Product = lvProducts.SelectedItems[0].Tag as Product,
                    UnitCost = nudCost.Value,
                    UnitPrice = nudPrice.Value,
                    Quantity = nudQuantity.Value,
                    DiscountRatio = nudDiscountRatio.Value,
                    UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text),
                    TaxRatio = nudTaxRatio.Value,
                    Width = nudWidth.Value / 1000,
                    Height = nudHeight.Value / 1000
                };

                (lvProducts.SelectedItems[0].Tag as Product).PriceHistory.LastCost = nudCost.Value;
                (lvProducts.SelectedItems[0].Tag as Product).PriceHistory.LastPrice = nudPrice.Value;

                OrderDetailValidator odv = new();
                var res = odv.Validate(od);

                if (res.IsValid)
                {
                    order.OrderDetails.Add(od);
                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                    ClearNumericUpDownControls(nudCost, nudPrice, nudQuantity);
                    UpdateOrderTotals(order);
                }
                else
                    MessageBox.Show(ErrorStringify.Stringify(res.Errors));

                var selectedItem = lvProducts.SelectedIndices[0];
                RefreshProducts(null);
                lvProducts.Items[selectedItem].Selected = true;
                nudWidth.Focus();
            }
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                Order tempOrder = new()
                {
                    CreatedAt = order.CreatedAt,
                    Customer = cbCustomers.SelectedItem as Customer,
                    DeliveryDate = dtpDeliveryDate.Value.Date.AddDays(1).AddTicks(-1),
                    IssueDate = dtpOrderDate.Value.Date,
                    JobNo = !string.IsNullOrEmpty(txtJobNo.Text) ? Convert.ToInt32(txtJobNo.Text.Trim()) : -1,
                    OrderDetails = order.OrderDetails,
                    ID = order.ID
                };

                //order.JobNo = !string.IsNullOrEmpty(txtJobNo.Text) ? Convert.ToInt32(txtJobNo.Text.Trim()) : -1;
                //order.Customer = cbCustomers.SelectedItem as Customer;
                //order.IssueDate = dtpOrderDate.Value.Date;
                //order.DeliveryDate = dtpDeliveryDate.Value.Date.AddDays(1).AddTicks(-1);

                try
                {
                    if (IsUpdate)
                        orderDB.Update(tempOrder, order.ID);
                    else
                        orderDB.Add(tempOrder);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    if (!IsUpdate)
                        ControlCleaner.Clear(this.Controls);
                }
            }
        }
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            RefreshProducts(productDB.GetAll((sender as TextBox).Text.ToLower().Trim() ?? null).ToArray());
        }
        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.SelectedItems.Count > 0 & lvOrderDetails.CheckedItems.Count == 0)
            {
                if (order.OrderDetails.Count > 1)
                {
                    order.OrderDetails.Remove(lvOrderDetails.SelectedItems[0].Tag as OrderDetail);
                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                    UpdateOrderTotals(order);
                }
                else
                    MessageBox.Show("Siparişe ait en az bir kalem bulunmak zorunda.");
            }
            else if (lvOrderDetails.CheckedItems.Count > 0)
            {
                if (lvOrderDetails.CheckedItems.Count < order.OrderDetails.Count && MessageBox.Show("Seçilen ürünler silinecektir. Onaylıyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lvOrderDetails.CheckedItems)
                    {
                        order.OrderDetails.Remove(item.Tag as OrderDetail);
                    }
                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                    UpdateOrderTotals(order);
                }
                else
                    MessageBox.Show("Siparişe ait en az bir kalem bulunmak zorunda.");
            }
        }
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lvProducts_Click(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;

            if (lv.SelectedItems.Count > 0)
            {
                Product p = lv.SelectedItems[0].Tag as Product;

                if (p != null)
                {
                    nudCost.Value = p.PriceHistory.LastCost;
                    nudPrice.Value = p.PriceHistory.LastPrice;
                }

                this.Text = p.Code;
            }
        }
        private void lvOrderDetails_DoubleClick(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                EditOrderDetail form = new(this, (sender as ListView).SelectedItems[0].Tag as OrderDetail);
                form.ShowDialog();

                RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                ClearNumericUpDownControls(nudPrice, nudCost, nudQuantity);
                UpdateOrderTotals(order);
            }
        }
        private void cbCustomers_Leave(object sender, EventArgs e)
        {
            var control = (sender as ComboBox);

            if (!string.IsNullOrEmpty(control.Text))
            {
                foreach (var item in control.Items)
                {
                    if (item.ToString().Contains(control.Text.ToUpper()))
                    {
                        control.SelectedIndex = control.Items.IndexOf(item);
                        break;
                    }
                }
            }
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;

            if (lv.SelectedItems.Count > 0)
            {
                Product p = lv.SelectedItems[0].Tag as Product;

                if (p != null)
                {
                    nudCost.Value = p.PriceHistory.LastCost;
                    nudPrice.Value = p.PriceHistory.LastPrice;
                }

                this.Text = p.Code;
            }
        }
        private void lvOrderDetails_SelectedIndexAndCheckedChanged(object sender, ItemCheckedEventArgs e)
        {
            if ((sender as ListView).CheckedItems.Count > 0)
            {
                List<OrderDetail> orderDetails = [];

                foreach (ListViewItem item in (sender as ListView).CheckedItems)
                {
                    orderDetails.Add(item.Tag as OrderDetail);
                }

                Order tempOrder = new()
                {
                    OrderDetails = orderDetails
                };

                UpdateOrderTotals(tempOrder);
            }
            else
                UpdateOrderTotals(order);
        }
        private void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                try
                {
                    switch (e.KeyData)
                    {
                        case Keys.Delete:
                            if (lvOrderDetails.SelectedItems.Count > 0 & lvOrderDetails.CheckedItems.Count == 0)
                            {
                                if (order.OrderDetails.Count > 1)
                                {
                                    order.OrderDetails.Remove(lvOrderDetails.SelectedItems[0].Tag as OrderDetail);
                                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    UpdateOrderTotals(order);
                                }
                                else
                                    MessageBox.Show("Siparişe ait en az bir kalem bulunmak zorunda.");
                            }
                            else if (lvOrderDetails.CheckedItems.Count > 0)
                            {
                                if (lvOrderDetails.CheckedItems.Count < order.OrderDetails.Count && MessageBox.Show("Seçilen ürünler silinecektir. Onaylıyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    foreach (ListViewItem item in lvOrderDetails.CheckedItems)
                                    {
                                        order.OrderDetails.Remove(item.Tag as OrderDetail);
                                    }
                                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    UpdateOrderTotals(order);
                                }
                                else
                                    MessageBox.Show("Siparişe ait en az bir kalem bulunmak zorunda.");
                            }
                            break;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    item.Checked = true;
                }
            }
        }
        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    item.Checked = false;
                }
            }
        }
        private void checkSameProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    item.Checked = false;
                }

                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    if ((lvOrderDetails.SelectedItems[0].Tag as OrderDetail).Product.ID == (item.Tag as OrderDetail).Product.ID)
                        item.Checked = true;
                }
            }
        }
    }
}
