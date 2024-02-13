using BL.Repositories.Repositories;
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

        void RefreshCustomers()
        {
            cbCustomers.Items.Clear();

            cbCustomers.Items.AddRange(customerDB.GetAll().ToArray());

            cbCustomers.DisplayMember = "Name";
        }
        void RefreshProducts(Product[]? products)
        {
            lbProducts.Items.Clear();

            if (products != null)
                lbProducts.Items.AddRange(products);
            else
                lbProducts.Items.AddRange(productDB.GetAll().ToArray());

            lbProducts.DisplayMember = "Name";
        }
        void RefreshUnitCode()
        {
            cbUnitCode.Items.Clear();

            cbUnitCode.Items.AddRange(Enum.GetNames(typeof(UnitCode)));

            cbUnitCode.SelectedIndex = 0;
        }
        void RefreshOrderDetails(ColumnHeaderAutoResizeStyle columnHeaderAutoResizeStyle)
        {
            lvOrderDetails.Items.Clear();

            foreach (var item in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Tag = item,
                    Text = item.Product.Name
                };

                lvi.SubItems.Add(item.UnitCost.ToString("N2"));
                lvi.SubItems.Add(item.UnitPrice.ToString("N2"));
                lvi.SubItems.Add(item.UnitCode.ToString());
                lvi.SubItems.Add(item.Quantity.ToString("N2"));
                lvi.SubItems.Add(item.ProducedOrders.Sum(x => x.ProducedOrderCount).ToString("N2"));
                lvi.SubItems.Add((item.Quantity - item.ProducedOrders.Sum(x => x.ProducedOrderCount)).ToString("N2"));
                lvi.SubItems.Add(item.Cost.ToString("N2"));
                lvi.SubItems.Add(item.Price.ToString("N2"));
                lvi.SubItems.Add(item.Profit.ToString("N2"));
                lvi.SubItems.Add(item.ProfitRatio.ToString("P2"));

                lvOrderDetails.Items.Add(lvi);
            }

            lvOrderDetails.AutoResizeColumns(columnHeaderAutoResizeStyle);
        }
        void LoadOrder(Order order)
        {
            this.Text = "Sipariş Güncelle";
            btnSaveOrder.Text = "Güncelle";

            txtJobNo.Text = order.JobNo.ToString();
            cbCustomers.SelectedIndex = cbCustomers.Items.IndexOf(order.Customer);
            dtpOrderDate.Value = order.IssueDate;
            dtpDeliveryDate.Value = order.DeliveryDate;

            RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void InitializeForm()
        {
            RefreshCustomers();
            RefreshProducts(null);
            RefreshUnitCode();
        }

        void UpdateOrderTotals(Order order)
        {
            txtTotalCost.Text = order.Cost.ToString("N2");
            txtTotalPrice.Text = order.Price.ToString("N2");
            txtProfit.Text = order.Profit.ToString("N2");
            txtProfitRatio.Text = order.ProfitRatio.ToString("P2");
            txtTotalQuantity.Text = order.ProductQuantity.ToString("N2");
        }

        CustomerRepository customerDB = new();
        OrderRepository orderDB = new();
        ProductRepository productDB = new();

        Order order;
        bool IsUpdate;

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItems.Count > 0)
            {
                OrderDetail od = new()
                {
                    Order = order,
                    Product = lbProducts.SelectedItem as Product,
                    UnitCost = nudCost.Value,
                    UnitPrice = nudPrice.Value,
                    Quantity = nudQuantity.Value,
                    UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text),
                };

                (lbProducts.SelectedItem as Product).PriceHistory.LastCost = nudCost.Value;
                (lbProducts.SelectedItem as Product).PriceHistory.LastPrice = nudPrice.Value;

                OrderDetailValidator odv = new();
                var res = odv.Validate(od);

                if (res.IsValid)
                {
                    order.OrderDetails.Add(od);
                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                    ControlCleaner.Clear(gbAddProductDetail.Controls);
                    UpdateOrderTotals(order);
                }
                else
                    MessageBox.Show(ErrorStringify.Stringify(res.Errors));
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                OrderValidator ov = new();

                order.JobNo = !string.IsNullOrEmpty(txtJobNo.Text) ? Convert.ToInt32(txtJobNo.Text.Trim()) : -1;
                order.Customer = cbCustomers.SelectedItem as Customer;
                order.IssueDate = dtpOrderDate.Value;
                order.DeliveryDate = dtpDeliveryDate.Value;

                var res = ov.Validate(order);

                if (res.IsValid)
                {
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

                        if(!IsUpdate)
                            ControlCleaner.Clear(this.Controls);
                    }
                }
                else
                {
                    MessageBox.Show(ErrorStringify.Stringify(res.Errors));
                }
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            RefreshProducts(productDB.GetAll((sender as TextBox).Text.ToLower().Trim() ?? null).ToArray());
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItems.Count > 0)
            {
                Product p = lb.SelectedItems[0] as Product;

                if (p != null)
                {
                    nudCost.Value = p.PriceHistory.LastCost;
                    nudPrice.Value = p.PriceHistory.LastPrice;
                }
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.SelectedItems.Count > 0)
            {
                order.OrderDetails.Remove(lvOrderDetails.SelectedItems[0].Tag as OrderDetail);
                RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                UpdateOrderTotals(order);
            }
        }
    }
}
