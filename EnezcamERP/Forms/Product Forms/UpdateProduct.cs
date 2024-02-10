using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;
using System.Text;

namespace EnezcamERP.Forms.Product_Forms
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct(Form parentForm, Product product)
        {
            InitializeComponent();
            this.product = product;
            this.parentForm = parentForm;
            FillControls();
        }

        GenericRepository<Product> productDB = new(EnzDBContext.GetInstance);
        Product product;
        Form parentForm;

        void FillControls()
        {
            cbProductType.Items.Clear();
            cbProductType.DataSource = Enum.GetValues(typeof(ProductType));
            cbProductType.SelectedIndex = cbProductType.Items.IndexOf(product.Type);

            txtProductName.Text = product.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product newProduct = new()
            {
                Name = txtProductName.Text,
                Type = (ProductType)Enum.Parse(typeof(ProductType), cbProductType.SelectedItem.ToString())
            };

            var res = new ProductValidator().Validate(newProduct);

            if (res.IsValid)
            {
                productDB.Update(newProduct, product.ID);
                productDB.Save();
                (parentForm as FormMain).RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                (sender as Button).Enabled = false;
            }
            else
            {
                StringBuilder sb = new();

                foreach (var err in res.Errors)
                {
                    sb.AppendLine(err.ErrorMessage);
                }

                MessageBox.Show(sb.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlTextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }
    }
}
