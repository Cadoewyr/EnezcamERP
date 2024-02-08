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
        public UpdateProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            FillControls();
        }

        GenericRepository<Product> productDB = new GenericRepository<Product>(EnzDBContext.GetInstance);
        Product product;

        void FillControls()
        {
            txtProductName.Text = product.Name;
            cbProductType.SelectedIndex = cbProductType.Items.IndexOf(product.Type.ToString());
        }

        private void ClearControls()
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();

                else if (control is CheckBox)
                    (control as ComboBox).SelectedIndex = 0;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product newProduct = new()
            {
                Name = txtProductName.Text,
                Type = Enum.Parse<ProductType>(cbProductType.SelectedText)
            };

            var res = new ProductValidator().Validate(newProduct);

            if (res.IsValid)
            {
                productDB.Update(newProduct, product.ID);
                productDB.Save();
                ControlCleaner.Clear(this.Controls);
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
