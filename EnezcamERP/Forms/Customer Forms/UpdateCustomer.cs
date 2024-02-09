using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using System.Text;

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

        GenericRepository<Customer> customerDB = new(EnzDBContext.GetInstance);
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
                customerDB.Update(newCustomer, customer.ID);
                customerDB.Save();
                (parentForm as FormMain).RefreshCustomers(null, ColumnHeaderAutoResizeStyle.HeaderSize);
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
            btnUpdateCustomer.Enabled = true;
        }
    }
}
