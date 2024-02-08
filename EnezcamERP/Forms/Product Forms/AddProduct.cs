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
        public AddProduct()
        {
            InitializeComponent();
            FillControls();
        }

        GenericRepository<Product> productDB = new GenericRepository<Product>(EnzDBContext.GetInstance);

        void FillControls()
        {
            cbProductType.Items.Clear();

            cbProductType.Items.AddRange(Enum.GetNames(typeof(ProductType)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new()
            {
                Name = txtProductName.Text,
                Type = Enum.Parse<ProductType>(cbProductType.SelectedText)
            };

            var res = new ProductValidator().Validate(p);

            if (res.IsValid)
            {
                productDB.Add(p);
                productDB.Save();
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
