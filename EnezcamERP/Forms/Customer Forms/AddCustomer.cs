using DAL.DTO.Entities;

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

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if (customer != null)
            {

            }
        }
    }
}
