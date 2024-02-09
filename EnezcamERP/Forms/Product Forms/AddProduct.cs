using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;
using System.Text;

namespace EnezcamERP.Forms.Product_Forms
{
    public partial class AddProduct : Form
    {
        public AddProduct(Form parentForm)
        {
            InitializeComponent();
            FillControls();
            this.ParentForm = parentForm;
        }

        GenericRepository<Product> productDB = new GenericRepository<Product>(EnzDBContext.GetInstance);
        private Form ParentForm;

        void FillControls()
        {
            cbProductType.Items.Clear();

            cbProductType.DataSource = Enum.GetValues(typeof(ProductType));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new()
            {
                Name = txtProductName.Text,
                Type = (ProductType)Enum.Parse(typeof(ProductType), cbProductType.SelectedItem.ToString())
            };

            var res = new ProductValidator().Validate(p);

            if (res.IsValid)
            {
                productDB.Add(p);
                productDB.Save();
                (ParentForm as FormMain).RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                ControlCleaner.Clear(this.Controls);
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
    }
}
