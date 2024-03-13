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

            products ??= productDB.GetAll().ToArray();

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

            cbUnitCode.Items.AddRange(Enum.GetNames(typeof(UnitCode)));

            cbUnitCode.SelectedIndex = 0;
        }
        public void RefreshOrderDetails(ColumnHeaderAutoResizeStyle columnHeaderAutoResizeStyle)
        {
            lvOrderDetails.Items.Clear();

            ColumnHeader clmDiscountedUnitPrice = new()
            {
                Name = "clmDiscountedUnitPrice",
                Text = "İskontolu Birim Fiyat",
                DisplayIndex = 3
            };

            foreach (var item in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Tag = item,
                    Text = item.Product.Code
                };

                lvi.SubItems.Add(item.Product.Name);
                lvi.SubItems.Add(item.UnitCost.ToString("C2"));
                lvi.SubItems.Add(item.UnitPrice.ToString("C2"));
                if (order.OrderDetails.Any(x => x.DiscountRatio > 0))
                {
                    if (!lvOrderDetails.Columns.Contains(clmDiscountedUnitPrice))
                        lvOrderDetails.Columns.Insert(3, clmDiscountedUnitPrice);

                    lvi.SubItems.Add(item.FinalUnitPrice.ToString("C2"));
                }
                lvi.SubItems.Add((item.DiscountRatio / 100).ToString("P0"));
                lvi.SubItems.Add((item.TaxRatio / 100).ToString("P0"));
                lvi.SubItems.Add(item.Quantity.ToString("N3"));
                lvi.SubItems.Add(item.UnitCode.ToString());
                lvi.SubItems.Add(item.ProducedOrders.Sum(x => x.ProducedOrderQuantity).ToString("N3"));
                lvi.SubItems.Add((item.Quantity - item.ProducedOrders.Sum(x => x.ProducedOrderQuantity)).ToString("N3"));
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
            txtTotalQuantity.Text = string.Join(", ", order.ProductQuantity.Select(x => $"{x.Value.ToString(x.Key == UnitCode.M2 ? "N3" : "N0")} {x.Key}").ToArray());
            txtPriceWithTax.Text = order.PriceWithTax.ToString("C2");
        }
        void ClearNumericUpDownControls(params Control[] controls)
        {
            foreach (var control in controls)
            {
                (control as NumericUpDown).Value = 0;
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
                    TaxRatio = nudTaxRatio.Value
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

                RefreshProducts(null);
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                order.JobNo = !string.IsNullOrEmpty(txtJobNo.Text) ? Convert.ToInt32(txtJobNo.Text.Trim()) : -1;
                order.Customer = cbCustomers.SelectedItem as Customer;
                order.IssueDate = dtpOrderDate.Value.Date
                    .AddHours(DateTime.Now.Hour)
                    .AddMinutes(DateTime.Now.Minute)
                    .AddSeconds(DateTime.Now.Second)
                    .AddMilliseconds(DateTime.Now.Millisecond)
                    .AddMicroseconds(DateTime.Now.Microsecond);

                order.DeliveryDate = dtpDeliveryDate.Value.Date.AddDays(1).AddTicks(-1);

                try
                {
                    if (IsUpdate)
                        orderDB.Update(order, order.ID);
                    else
                        orderDB.Add(order);

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
            if (lvOrderDetails.SelectedItems.Count > 0)
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
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUnitCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((UnitCode)Enum.Parse<UnitCode>((sender as ComboBox).Text) == UnitCode.AD)
                nudQuantity.DecimalPlaces = 0;
            else
                nudQuantity.DecimalPlaces = 3;
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
    }
}
