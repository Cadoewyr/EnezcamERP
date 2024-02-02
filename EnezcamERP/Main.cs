using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EnezcamERP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        EnzDBContext db = new EnzDBContext();

        void RefreshList(ListView listView)
        {
            GenericRepository<Order> orders = new GenericRepository<Order>(db);

            listView.Items.Clear();
            listView.Columns.Clear();

            foreach(Order order in orders.GetAll())
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = order.JobNo.ToString();
                lvi.SubItems.Add(order.Customer);
                lvi.SubItems.Add(order.IssueDate.ToShortDateString());
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshList(lvOrders);
        }
    }
}
