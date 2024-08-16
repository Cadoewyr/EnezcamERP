using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Order_Forms
{
    public partial class OrderDetailSpecs : Form
    {
        public OrderDetailSpecs(OrderDetail orderDetail)
        {
            InitializeComponent();

            this.orderDetail = orderDetail;
        }

        OrderDetail orderDetail { get; set; }

        void RefreshList()
        {
            lvOrderDetailsSpecs.Items.Clear();

            foreach (Spec spec in new SpecRepository().GetAll().OrderBy(x => x.Name).ToArray())
            {
                ListViewItem lvItem = new()
                {
                    Text = spec.Name,
                    Tag = spec,
                    Checked = orderDetail.Specs.Any(x => x.Spec.ID == spec.ID)
                };

                lvOrderDetailsSpecs.Items.Add(lvItem);
            }
        }

        private void OrderDetailSpecs_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            orderDetail.Specs.Clear();

            foreach (ListViewItem lvItem in lvOrderDetailsSpecs.CheckedItems)
            {
                orderDetail.Specs.Add(new OrderDetailSpec()
                {
                    OrderDetail = orderDetail,
                    Spec = lvItem.Tag as Spec
                });
            }

            RefreshList();

            (sender as Button).Enabled = false;
        }

        private void lvOrderDetailsSpecs_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
