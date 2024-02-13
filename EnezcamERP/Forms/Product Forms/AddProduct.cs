using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;

namespace EnezcamERP.Forms.Product_Forms
{
    public partial class AddProduct : Form
    {
        public AddProduct(Form parentForm)
        {
            InitializeComponent();
            FillControls();
            this.parentForm = parentForm;
        }

        ProductRepository productDB = new();
        private Form parentForm;

        void RefreshProcessTypes()
        {
            cbProcessTypes.Items.Clear();
            cbProcessTypes.DataSource = Enum.GetValues(typeof(ProcessType));
        }

        void FillControls()
        {
            RefreshProcessTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new()
            {
                Name = txtProductName.Text,
                Type = (ProcessType)Enum.Parse(typeof(ProcessType), cbProcessTypes.SelectedItem.ToString()),
                IsCounting = cbIsCounting.Checked
            };

            var res = new ProductValidator().Validate(p);

            if (res.IsValid)
            {
                productDB.Add(p);
                (parentForm as FormMain).RefreshProducts(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                MessageBox.Show(ErrorStringify.Stringify(res.Errors));
            }
            ControlCleaner.Clear(this.Controls);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
