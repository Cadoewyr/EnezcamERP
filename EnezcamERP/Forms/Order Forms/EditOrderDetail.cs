using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;

namespace EnezcamERP.Forms.Order_Forms
{
    public partial class EditOrderDetail : Form
    {
        public EditOrderDetail(Form parentForm, OrderDetail orderDetail)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.orderDetail = orderDetail;
            LoadForm(orderDetail);
        }

        Form parentForm;
        OrderDetail orderDetail;
        ProductRepository productRepository = new();
        OrderDetailsRepository orderDetailsRepository = new();

        void LoadProducts(Product[] products, Product selectedProduct)
        {
            ListView lv = lvProducts;
            products ??= productRepository.GetAll(txtSearch.Text.ToLower().Trim()).ToArray();
            lv.Items.Clear();

            foreach (var product in products)
            {
                ListViewItem lvi = new()
                {
                    Text = product.Name,
                    Tag = product
                };

                lvi.SubItems.Add(product.Code);
                lvi.SubItems.Add(product.Type.ToString());
                lvi.SubItems.Add(product.PriceHistory.LastCost.ToString("C2"));
                lvi.SubItems.Add(product.PriceHistory.LastPrice.ToString("C2"));
                lvi.SubItems.Add(product.IsCounting ? "Dahil" : "Dahil Değil");

                lv.Items.Add(lvi);
            }

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (ListViewItem item in lv.Items)
            {
                if (item.Tag as Product == selectedProduct)
                {
                    item.Selected = true;
                    break;
                }
            }
        }
        void LoadControls(OrderDetail orderDetail)
        {
            cbUnitCode.Items.Clear();
            cbUnitCode.Items.AddRange(Enum.GetNames(typeof(UnitCode)));
            cbUnitCode.SelectedIndex = cbUnitCode.Items.IndexOf(orderDetail.UnitCode.ToString());

            nudQuantity.Value = orderDetail.Quantity;
            nudQuantity.Minimum = orderDetail.ProducedQuantity;
            nudTaxRatio.Value = orderDetail.TaxRatio;
            nudDiscountRatio.Value = orderDetail.DiscountRatio;
            nudCost.Value = orderDetail.UnitCost;
            nudPrice.Value = orderDetail.UnitPrice;
            nudWidth.Value = orderDetail.Width * 1000;
            nudHeight.Value = orderDetail.Height * 1000;
        }
        void LoadForm(OrderDetail orderDetail)
        {
            LoadProducts(null, orderDetail.Product);
            LoadControls(orderDetail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                try
                {
                    orderDetail.Product = lvProducts.SelectedItems[0].Tag as Product;
                    orderDetail.UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text);
                    orderDetail.UnitCost = nudCost.Value;
                    orderDetail.UnitPrice = nudPrice.Value;
                    orderDetail.DiscountRatio = nudDiscountRatio.Value;
                    orderDetail.TaxRatio = nudTaxRatio.Value;
                    orderDetail.Width = nudWidth.Value / 1000;
                    orderDetail.Height = nudHeight.Value / 1000;

                    OrderDetail od = new()
                    {
                        Product = lvProducts.SelectedItems[0].Tag as Product,
                        UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text),
                        UnitCost = nudCost.Value,
                        UnitPrice = nudPrice.Value,
                        Width = nudWidth.Value / 1000,
                        Height = nudHeight.Value / 1000,
                        TaxRatio = nudTaxRatio.Value,
                        Order = orderDetail.Order ?? new Order(),
                        Quantity = (int)nudQuantity.Value,
                        DiscountRatio = nudDiscountRatio.Value,
                        ProducedOrders = orderDetail.ProducedOrders ?? [],
                        CreatedAt = orderDetail.CreatedAt,
                        ID = orderDetail.ID
                    };

                    if (cbUpdatePriceHistory.Checked)
                    {
                        od.Product.PriceHistory.LastCost = nudCost.Value;
                        od.Product.PriceHistory.LastPrice = nudPrice.Value;
                    }

                    if (cbUpdateSameProducts.Checked)
                    {
                        foreach (var item in od.Order.OrderDetails)
                        {
                            if (item.Product.ID == od.Product.ID)
                            {
                                item.UnitCost = nudCost.Value;
                                item.UnitPrice = nudPrice.Value;
                                item.DiscountRatio = nudDiscountRatio.Value;
                                item.TaxRatio = nudTaxRatio.Value;
                                item.UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text);
                            }
                        }
                    }

                    if (od.Order.JobNo <= 0 || od.Order.ID <= 0 || od.ID <= 0)
                    {
                        var oldEntity = orderDetail;
                        var entityType = typeof(OrderDetail);

                        foreach (var prop in entityType.GetProperties().Where(x => x.SetMethod != null))
                        {
                            if (prop.Name != "ID")
                                prop.SetValue(oldEntity, prop.GetValue(od));
                        }
                    }
                    else
                        orderDetailsRepository.Update(od, orderDetail.ID);

                    LoadForm(orderDetail);
                    (parentForm as AddUpdateOrder).RefreshOrderDetails(this.orderDetail.Order, null, ColumnHeaderAutoResizeStyle.HeaderSize);
                    (parentForm as AddUpdateOrder).UpdateOrderTotals(orderDetail.Order);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                nudCost.Value = (lvProducts.SelectedItems[0].Tag as Product).PriceHistory.LastCost;
                nudPrice.Value = (lvProducts.SelectedItems[0].Tag as Product).PriceHistory.LastPrice;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(null, orderDetail.Product);
        }

        private void btnGetCostAndPrice_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                //var res = orderDetailsRepository.GetAll(x => x.Width == nudWidth.Value / 1000 & x.Height == nudHeight.Value / 1000 & x.Product.ID == (lvProducts.SelectedItems[0].Tag as Product).ID)
                //.MaxBy(x => x.Order.IssueDate);

                //if (res != null)
                //{
                //    nudCost.Value = res.UnitCost;
                //    nudPrice.Value = res.UnitPrice;
                //}

                ProductPriceHistory form = new(lvProducts.SelectedItems[0].Tag as Product, nudCost.Value, nudPrice.Value);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    var res = form.Result;

                    nudCost.Value = res.Cost;
                    nudPrice.Value = res.Price;
                }
            }
            else
                MessageBox.Show("Herhangi bir ürün seçili değil.");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen ürün koduna ait aynı ölçülerle girilmiş en son siparişteki maliyet ve fiyatı getirir.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Value.ToString().Length + ((sender as NumericUpDown).ToString().Length - 1) / 3);
        }
    }
}
