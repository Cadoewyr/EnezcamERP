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

        public OrderDetailSpecs(OrderDetail[] orderDetails)
        {
            InitializeComponent();

            this.orderDetails = orderDetails;
        }

        OrderDetail[] orderDetails { get; set; } = null;
        OrderDetail orderDetail { get; set; } = null;

        void RefreshList()
        {
            lvOrderDetailsSpecs.Items.Clear();

            if (orderDetail != null)
            {
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
            else if (orderDetails != null)
            {
                foreach (Spec spec in new SpecRepository().GetAll().OrderBy(x => x.Name).ToArray())
                {
                    ListViewItem lvItem = new()
                    {
                        Text = spec.Name,
                        Tag = spec,
                        Checked = false
                    };

                    lvOrderDetailsSpecs.Items.Add(lvItem);
                }
            }
        }
        void Update(OrderDetail orderDetail)
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
        }
        void Update(OrderDetail[] orderDetails)
        {
            foreach (OrderDetail orderDetail in orderDetails)
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
            }

            RefreshList();
        }

        private void OrderDetailSpecs_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (orderDetail != null)
                Update(orderDetail);
            else if (orderDetails != null)
                Update(orderDetails);

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
