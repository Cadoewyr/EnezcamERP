using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using EnezcamERP.Validators;

namespace EnezcamERP.Forms.Customer_Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        CustomerRepository customerDB = new();
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
                try
                {
                    customerDB.Add(customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                ControlCleaner.Clear(this.Controls);
                (parentForm as FormMain).RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
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
    }
}
