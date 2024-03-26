using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Customer_Forms
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer(Form parentForm, Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.parentForm = parentForm;
            FillControls();
        }

        CustomerRepository customerDB = new();
        Customer customer;
        Form parentForm;

        void FillControls()
        {
            txtCustomerName.Text = customer.Name;
            txtCountry.Text = customer.Country;
            txtCity.Text = customer.City;
            txtDescription.Text = customer.Description;
            txtAddress.Text = customer.Address;
            txtContactName.Text = customer.ContactName;
            txtContactPhone.Text = customer.ContactPhone;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new()
            {
                Name = txtCustomerName.Text.Trim().ToUpper(),
                Country = txtCountry.Text.Trim(),
                City = txtCity.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ContactName = txtContactName.Text.Trim(),
                ContactPhone = txtContactPhone.Text.Trim()
            };

            try
            {
                customerDB.Update(newCustomer, customer.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            (parentForm as FormMain).RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
            (sender as Button).Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlTextChanged(object sender, EventArgs e)
        {
            btnUpdateCustomer.Enabled = true;
        }
    }
}
