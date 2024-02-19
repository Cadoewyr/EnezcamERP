using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;

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

            products ??= productRepository.GetAll().ToArray();

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
            nudCost.Value = orderDetail.UnitCost;
            nudPrice.Value = orderDetail.UnitPrice;
        }
        void LoadForm(OrderDetail orderDetail)
        {
            LoadProducts(null, orderDetail.Product);
            LoadControls(orderDetail);
        }

        private void cbUnitCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((UnitCode)Enum.Parse<UnitCode>((sender as ComboBox).Text) == UnitCode.AD)
                nudQuantity.DecimalPlaces = 0;
            else
                nudQuantity.DecimalPlaces = 3;
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
                    orderDetail.TaxRatio = nudTaxRatio.Value;

                    OrderDetail od = new()
                    {
                        Product = lvProducts.SelectedItems[0].Tag as Product,
                        UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text),
                        UnitCost = nudCost.Value,
                        UnitPrice = nudPrice.Value,
                        TaxRatio = nudTaxRatio.Value,
                        Order = orderDetail.Order,
                        Quantity = nudQuantity.Value,
                        ProducedOrders = orderDetail.ProducedOrders
                    };

                    var res = new OrderDetailValidator().Validate(od);

                    if (res.IsValid)
                    {
                        orderDetailsRepository.Update(od, orderDetail.ID);
                        LoadForm(orderDetail);
                        (parentForm as AddUpdateOrder).RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                        (parentForm as AddUpdateOrder).UpdateOrderTotals(orderDetail.Order);
                    }
                    else
                        ErrorStringify.Stringify(res.Errors);
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
    }
}
