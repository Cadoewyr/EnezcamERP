using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;

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

        ProductRepository productDB = new();

        Product product;
        Form parentForm;

        void RefreshProcessTypes()
        {
            cbProcessTypes.Items.Clear();
            cbProcessTypes.DataSource = Enum.GetValues(typeof(ProcessType));
            cbProcessTypes.SelectedIndex = cbProcessTypes.Items.IndexOf(product.Type);
        }

        void FillControls()
        {
            RefreshProcessTypes();

            txtProductName.Text = product.Name;
            txtCode.Text = product.Code;
            cbIsCounting.Checked = product.IsCounting;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product newProduct = new()
            {
                Name = txtProductName.Text.Trim(),
                Code = txtCode.Text.Trim(),
                Type = (ProcessType)Enum.Parse(typeof(ProcessType), cbProcessTypes.SelectedItem.ToString()),
                IsCounting = cbIsCounting.Checked
            };

            var res = new ProductValidator().Validate(newProduct);

            if (res.IsValid)
            {
                try
                {
                    productDB.Update(newProduct, product.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                (parentForm as FormMain).RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                (sender as Button).Enabled = false;
            }
            else
            {
                MessageBox.Show(ErrorStringify.Stringify(res.Errors));
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
