using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using System.Text;

namespace EnezcamERP.Forms.Customer_Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        GenericRepository<Customer> customerDB = new(EnzDBContext.GetInstance);
        Form parentForm;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new()
            {
                Name = txtCustomerName.Text,
                Country = txtCountry.Text,
                City = txtCity.Text,
                Address = txtAddress.Text,
                Description = txtDescription.Text,
                ContactName = txtContactName.Text,
                ContactPhone = txtContactPhone.Text
            };

            var res = new CustomerValidator().Validate(customer);

            if (res.IsValid)
            {
                customerDB.Add(customer);
                customerDB.Save();
                ControlCleaner.Clear(this.Controls);
                (parentForm as FormMain).RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
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
