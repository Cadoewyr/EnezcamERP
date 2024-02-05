using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;

namespace EnezcamERP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        GenericRepository<Order> ordersDB = new(EnzDBContext.GetInstance);

        void FillList(ListView listView)
        {
            listView.Items.Clear();

            foreach (Order order in ordersDB.GetAll())
            {
                ListViewItem lvi = new()
                {
                    Text = order.JobNo.ToString()
                };
                lvi.SubItems.Add(order.Customer);
                lvi.SubItems.Add(order.IssueDate.ToShortDateString());
                lvi.SubItems.Add(order.ProductCount.ToString());
                lvi.SubItems.Add(order.ProducedProductCount.ToString());
                lvi.SubItems.Add(order.Price.ToString());
                lvi.SubItems.Add(order.ProducedPrice.ToString());
                lvi.SubItems.Add(order.Cost.ToString());
                lvi.SubItems.Add(order.ProducedCost.ToString());
                lvi.SubItems.Add(order.Profit.ToString());
                lvi.SubItems.Add(order.ProducedProfit.ToString());
                lvi.SubItems.Add(order.ProfitPercentage.ToString());
                lvi.SubItems.Add(order.ProducedProfitPercentage.ToString());

                lvi.Tag = order;

                lvOrders.Items.Add(lvi);
            }
            
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillList(lvOrders);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            FillList(lvOrders);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {


                FillList(lvOrders);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvOrders.SelectedItems.Count > 0) {
                ordersDB.Delete(lvOrders.SelectedItems[0].Tag as Order);
                ordersDB.Save();

                FillList(lvOrders);
            }
        }
    }
}
