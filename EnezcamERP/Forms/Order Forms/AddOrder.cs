using BL.Repositories;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnezcamERP.Forms.Order_Forms
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            InitializeForm();
            order = new();
        }

        void RefreshCustomers()
        {
            cbCustomers.Items.Clear();

            cbCustomers.Items.AddRange(customerDB.GetAll().ToArray());

            cbCustomers.DisplayMember = "Name";
        }
        void RefreshProducts(Product[]? products)
        {
            lbProducts.Items.Clear();

            if (products != null)
            {
                lbProducts.Items.AddRange(products);
            }
            else
            {
                lbProducts.Items.AddRange(productDB.GetAll().ToArray());
            }

            lbProducts.DisplayMember = "Name";
        }
        void RefreshUnitCode()
        {
            cbUnitCode.Items.Clear();

            cbUnitCode.Items.AddRange(Enum.GetNames(typeof(UnitCode)));

            cbUnitCode.SelectedIndex = 0;
        }

        void InitializeForm()
        {
            RefreshCustomers();
            RefreshProducts(null);
            RefreshUnitCode();
        }

        void UpdateOrderTotals(Order order)
        {
            txtTotalCost.Text = order.Cost.ToString();
            txtTotalPrice.Text = order.Price.ToString();
            txtProfit.Text = order.Profit.ToString();
            txtProfitPercentage.Text = order.ProfitPercentage.ToString();
        }

        GenericRepository<Customer> customerDB = new(EnzDBContext.GetInstance);
        GenericRepository<Order> orderDB = new(EnzDBContext.GetInstance);
        GenericRepository<Product> productDB = new(EnzDBContext.GetInstance);
        GenericRepository<OrderDetail> orderDetailDB = new(EnzDBContext.GetInstance);

        Order order;

        void RefreshOrderDetails(ColumnHeaderAutoResizeStyle columnHeaderAutoResizeStyle)
        {
            lvOrderDetails.Items.Clear();

            foreach (var item in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Tag = item,
                    Text = item.Product.Name
                };

                lvi.SubItems.Add(item.UnitCost.ToString());
                lvi.SubItems.Add(item.UnitPrice.ToString());
                lvi.SubItems.Add(item.UnitCode.ToString());
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.ProducedOrders.Sum(x => x.ProducedOrderCount).ToString());
                lvi.SubItems.Add((item.Quantity - item.ProducedOrders.Sum(x => x.ProducedOrderCount)).ToString());
                lvi.SubItems.Add(item.Cost.ToString());
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.Profit.ToString());
                lvi.SubItems.Add(item.ProfitPercentage.ToString());

                lvOrderDetails.Items.Add(lvi);
            }

            lvOrderDetails.AutoResizeColumns(columnHeaderAutoResizeStyle);
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItems.Count > 0)
            {
                OrderDetail od = new()
                {
                    Order = order,
                    Product = lbProducts.SelectedItem as Product,
                    UnitCost = nudCost.Value,
                    UnitPrice = nudPrice.Value,
                    Quantity = nudQuantity.Value,
                    UnitCode = (UnitCode)Enum.Parse(typeof(UnitCode), cbUnitCode.Text),
                };

                OrderDetailValidator odv = new();
                var res = odv.Validate(od);

                if (res.IsValid)
                {
                    order.OrderDetails.Add(od);
                    RefreshOrderDetails(ColumnHeaderAutoResizeStyle.HeaderSize);
                    ControlCleaner.Clear(gbAddProductDetail.Controls);
                    UpdateOrderTotals(order);
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
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                order.JobNo =  !string.IsNullOrEmpty(txtJobNo.Text) ? Convert.ToInt32(txtJobNo.Text.Trim()) : -1;
                order.Customer = cbCustomers.SelectedItem as Customer;
                order.IssueDate = dtpOrderDate.Value;
                order.DeliveryDate = dtpDeliveryDate.Value;

                OrderValidator ov = new();
                var res = ov.Validate(order);

                if (res.IsValid)
                {
                    orderDB.Add(order);
                    orderDB.Save();
                    orderDetailDB.Save();
                    this.Close();
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
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            RefreshProducts(productDB.GetAll((sender as TextBox).Text.ToLower().Trim()).ToArray());
        }
    }
}
