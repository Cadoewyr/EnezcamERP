using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using EnezcamERP.Validators;
using System.Text;

namespace EnezcamERP.Forms.Customer_Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        public AddCustomer(Customer customer)
        {
            InitializeComponent();

            if (customer != null)
                this.customer = customer;
            else
                this.Close();
        }

        Customer customer;
        GenericRepository<Customer> customerDB = new(EnzDBContext.GetInstance);

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if (customer != null)
            {

            }
        }

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

            if(res.IsValid)
                customerDB.Add(customer);
            else
            {
                StringBuilder sb = new();

                foreach(var err in res.Errors)
                {
                    sb.AppendLine(err.ErrorMessage);
                }

                MessageBox.Show(sb.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
