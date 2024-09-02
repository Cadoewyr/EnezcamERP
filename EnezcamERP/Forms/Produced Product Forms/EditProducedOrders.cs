using BL.Repositories.Repositories;
using BL.Validators.Validators;
using DAL.DTO.Context;
using DAL.DTO.Entities;
using DAL.DTO.Entities.Enums;
using EnezcamERP.Validators;

namespace EnezcamERP.Forms.Produced_Product_Forms
{
    public partial class EditProducedOrders : Form
    {
        public EditProducedOrders(Form parentForm, Order order)
        {
            InitializeComponent();
            this.order = order;
            this.parentForm = parentForm;
            gbOrderDetail.Text += $" ({order.JobNo} - {order.Customer.Name})";
            dtpProduceDate.Value = DateTime.Now.Date;

            RefreshOrderDetails();
        }

        private Order order;
        private Form parentForm;
        ProducedOrdersRepository producedOrdersRepository = new();
        OrderRepository orderRepository = new();

        void RefreshOrderDetailTotals(OrderDetail? orderDetail)
        {
            if (orderDetail != null)
            {
                txtProductName.Text = orderDetail.Product.Name;
                txtQuantity.Text = orderDetail.GetQuantityString();
                txtProducedQuantity.Text = orderDetail.GetProducedQuantityString();
                txtRemainigQuantity.Text = orderDetail.GetRemainingQuantityString();

                if (orderDetail.RemainingToProduceQuantity == 0)
                {
                    btnAddProducedQuantity.Enabled = false;
                    nudProducedQuantity.Value = 0;
                    nudProducedQuantity.Maximum = 0;
                    nudProducedQuantity.Enabled = false;
                }
                else
                {
                    btnAddProducedQuantity.Enabled = true;
                    nudProducedQuantity.Value = 0;
                    nudProducedQuantity.Maximum = orderDetail.RemainingToProduceQuantity;
                    nudProducedQuantity.Enabled = true;
                }
            }
            else
                ControlCleaner.Clear(this.Controls);
        }
        void RefreshOrderDetailsTotals(OrderDetail[] orderDetails)
        {
            if (orderDetails.Length > 0)
            {
                Order tempOrder = new();
                tempOrder.OrderDetails = orderDetails.ToList();

                txtProductName.Text = string.Empty;
                txtQuantity.Text = tempOrder.GetQuantityString();
                txtProducedQuantity.Text = tempOrder.GetProducedQuantityString();
                txtRemainigQuantity.Text = tempOrder.GetRemainingQuantityString();
            }
        }
        void RefreshOrderDetails()
        {
            ListView listView = lvOrderDetails;
            listView.Items.Clear();

            foreach (var item in order.OrderDetails)
            {
                ListViewItem lvi = new()
                {
                    Text = item.Product.Name,
                    Tag = item,
                    UseItemStyleForSubItems = false
                };

                Color color;

                if (item.ProducedQuantity == 0)
                    color = Color.MediumVioletRed;
                else if (item.ProducedQuantity > 0 && item.ProducedQuantity < item.Quantity)
                    color = Color.MediumPurple;
                else if (item.ProducedQuantity == item.Quantity)
                    color = Color.Green;
                else
                    color = Color.Black;

                lvi.SubItems.Add(item.Product.Code);
                lvi.SubItems.Add(item.UnitCost.ToString("C2"));
                lvi.SubItems.Add(item.UnitPrice.ToString("C2"));
                lvi.SubItems.Add($"{item.Width.ToString("N3")} * {item.Height.ToString("N3")}");
                lvi.SubItems.Add(item.UnitArea.ToString("N3"));
                lvi.SubItems.Add(item.UnitCode.ToString());
                lvi.SubItems.Add(item.GetQuantityString());
                lvi.SubItems.Add(item.GetProducedQuantityString()).ForeColor = color;
                lvi.SubItems.Add(item.GetRemainingQuantityString()).ForeColor = color;

                listView.Items.Add(lvi);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void RefreshProduceHistory(IEnumerable<ProducedOrder> producedOrders)
        {
            ListView listView = lvProduceHistory;
            listView.Items.Clear();

            foreach (var item in producedOrders.OrderBy(x => x.ProducedDate))
            {
                ListViewItem lvi = new()
                {
                    Text = item.ProducedDate.ToShortDateString(),
                    Tag = item
                };

                var producedQuantity = item.ProducedOrderQuantity.ToString("N0");
                var remainigQuantity = (item.OrderDetail.Quantity - item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate <= item.ProducedDate).Sum(x => x.ProducedOrderQuantity)).ToString("N0");
                var producedArea = item.ProducedOrderArea.ToString("N3");
                var remainingArea = (item.OrderDetail.TotalArea - item.OrderDetail.ProducedOrders.Where(x => x.ProducedDate <= item.ProducedDate).Sum(x => x.ProducedOrderArea)).ToString("N3");

                lvi.SubItems.Add(item.OrderDetail.Product.Code);
                lvi.SubItems.Add($"{producedQuantity} {UnitCode.AD}, {producedArea} {UnitCode.M2}");
                lvi.SubItems.Add($"{remainigQuantity} {UnitCode.AD}, {remainingArea} {UnitCode.M2}");
                lvi.SubItems.Add(item.IsStock ? "Stok" : "Üretim");
                lvi.SubItems.Add(item.IsOvertime ? "Evet" : "Hayır");

                listView.Items.Add(lvi);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void RefreshAll()
        {
            int currentOrderDetailID;

            if (lvOrderDetails.SelectedItems.Count > 0)
                currentOrderDetailID = (lvOrderDetails.SelectedItems[0].Tag as OrderDetail).ID;
            else
                currentOrderDetailID = (lvOrderDetails.Items[0].Tag as OrderDetail).ID;

            RefreshOrderDetails();

            foreach (ListViewItem item in lvOrderDetails.Items)
            {
                if ((item.Tag as OrderDetail).ID == currentOrderDetailID)
                    item.Selected = true;
            }

            if (!cbListAllProductionHistory.Checked & lvOrderDetails.SelectedItems.Count > 0 & lvOrderDetails.CheckedItems.Count == 0)
            {
                RefreshProduceHistory(order.OrderDetails.First(x => x == lvOrderDetails.SelectedItems[0].Tag as OrderDetail).ProducedOrders);
                RefreshOrderDetailTotals(lvOrderDetails.SelectedItems[0].Tag as OrderDetail);
            }
            else if (!cbListAllProductionHistory.Checked & lvOrderDetails.CheckedItems.Count > 0)
            {
                List<OrderDetail> orderDetails = [];

                foreach (ListViewItem item in lvOrderDetails.CheckedItems)
                {
                    orderDetails.Add(item.Tag as OrderDetail);
                }

                RefreshProduceHistory(orderDetails.SelectMany(x => x.ProducedOrders).OrderBy(x => x.ProducedDate));
                RefreshOrderDetailsTotals(orderDetails.ToArray());
            }
            else if (cbListAllProductionHistory.Checked)
            {
                List<OrderDetail> orderDetails = [];

                foreach (ListViewItem item in lvOrderDetails.CheckedItems)
                {
                    orderDetails.Add(item.Tag as OrderDetail);
                }

                RefreshProduceHistory(order.OrderDetails.SelectMany(x => x.ProducedOrders).OrderBy(x => x.ProducedDate));
                RefreshOrderDetailsTotals(orderDetails.ToArray());
            }


        }

        private void btnAddProducedOrder_Click(object sender, EventArgs e)
        {
            dtpProduceDate.Value = dtpProduceDate.Value.Date
                .AddHours(DateTime.Now.Hour)
                .AddMinutes(DateTime.Now.Minute)
                .AddSeconds(DateTime.Now.Second)
                .AddMilliseconds(DateTime.Now.Millisecond)
                .AddMicroseconds(DateTime.Now.Microsecond);

            if (lvOrderDetails.SelectedItems.Count > 0 & lvOrderDetails.CheckedItems.Count == 0 & nudProducedQuantity.Value > 0)
            {
                try
                {
                    ProducedOrder po = new()
                    {
                        ProducedDate = dtpProduceDate.Value,
                        OrderDetail = lvOrderDetails.SelectedItems[0].Tag as OrderDetail,
                        ProducedOrderQuantity = (int)nudProducedQuantity.Value,
                        IsStock = cbIsStock.Checked,
                        IsOvertime = cbOvertime.Checked
                    };

                    var selectedOrderDetail = lvOrderDetails.SelectedItems[0].Tag as OrderDetail;

                    if (selectedOrderDetail.RemainingToProduceQuantity >= po.ProducedOrderQuantity)
                    {
                        var res = GenericValidator<ProducedOrder>.Validate(po);

                        if (res.IsValid)
                        {
                            order.OrderDetails.Where(x => x == selectedOrderDetail).First().ProducedOrders.Add(po);
                            orderRepository.Update(order, order.ID);
                        }
                        else
                            MessageBox.Show(ErrorStringify.Stringify(res.Errors));
                    }
                    else
                        MessageBox.Show("Üretim miktarı kalan üretim miktarından daha fazla olamaz.");

                    (parentForm as FormMain).RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshAll();
            }
        }
        private void btnDeleteProducedOrder_Click(object sender, EventArgs e)
        {
            if (lvProduceHistory.SelectedItems.Count > 0 & lvOrderDetails.CheckedItems.Count == 0)
            {
                try
                {
                    producedOrdersRepository.Delete(lvProduceHistory.SelectedItems[0].Tag as ProducedOrder);
                    (parentForm as FormMain).RefreshOrders(null, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { RefreshAll(); }
            }
            else if (lvOrderDetails.CheckedItems.Count > 0)
            {
                if (MessageBox.Show("Tüm üretim geçmişi silinecek. Onaylıyor musunuz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        List<ProducedOrder> producedOrders = [];


                        foreach (var item in lvOrderDetails.CheckedItems)
                        {
                            producedOrders.AddRange(((item as ListViewItem).Tag as OrderDetail).ProducedOrders.ToArray());
                        }

                        foreach (var producedOrder in producedOrders)
                        {
                            producedOrdersRepository.Delete(producedOrder);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { RefreshAll(); }
                }
            }
        }
        private void lvOrderDetails_SelectedIndexChangedAndChecked(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0 & !cbListAllProductionHistory.Checked & (sender as ListView).CheckedItems.Count == 0)
            {
                RefreshProduceHistory(((sender as ListView).SelectedItems[0].Tag as OrderDetail).ProducedOrders);
                RefreshOrderDetailTotals((sender as ListView).SelectedItems[0].Tag as OrderDetail);
            }

            if ((sender as ListView).CheckedItems.Count > 0 & !cbListAllProductionHistory.Checked & (sender as ListView).CheckedItems.Count > 0)
            {
                btnAddProducedQuantity.Enabled = false;
                btnMultipleComplete.Enabled = true;
                nudProducedQuantity.Enabled = false;

                List<OrderDetail> orderDetails = [];

                foreach (ListViewItem item in (sender as ListView).CheckedItems)
                {
                    orderDetails.Add(item.Tag as OrderDetail);
                }

                RefreshProduceHistory(orderDetails.SelectMany(x => x.ProducedOrders).OrderBy(x => x.ProducedDate));
                RefreshOrderDetailsTotals(orderDetails.ToArray());
            }
            else
            {
                btnAddProducedQuantity.Enabled = true;
                btnMultipleComplete.Enabled = false;
                nudProducedQuantity.Enabled = true;
            }
        }
        private void btnMultipleComplete_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.CheckedItems.Count > 0)
            {
                dtpProduceDate.Value = dtpProduceDate.Value.Date
                .AddHours(DateTime.Now.Hour)
                .AddMinutes(DateTime.Now.Minute)
                .AddSeconds(DateTime.Now.Second)
                .AddMilliseconds(DateTime.Now.Millisecond)
                .AddMicroseconds(DateTime.Now.Microsecond);

                try
                {
                    foreach (ListViewItem item in lvOrderDetails.CheckedItems)
                    {
                        var od = (item.Tag as OrderDetail);

                        if (od.RemainingToProduceQuantity > 0)
                        {
                            od.ProducedOrders.Add(new()
                            {
                                IsStock = cbIsStock.Checked,
                                IsOvertime = cbOvertime.Checked,
                                OrderDetail = od,
                                ProducedDate = dtpProduceDate.Value,
                                ProducedOrderQuantity = od.RemainingToProduceQuantity,
                                CreatedAt = DateTime.Now
                            });
                        }
                    }
                    EnzDBContext.GetInstance.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    RefreshAll();
                }
            }
        }
        private void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
            {
                var obj = (sender as ListView).SelectedItems[0].Tag;

                try
                {
                    switch (e.KeyData)
                    {
                        case Keys.Delete:
                            producedOrdersRepository.Delete(obj as ProducedOrder);
                            RefreshAll();
                            break;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    item.Checked = true;
                }
            }
        }
        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.Items.Count > 0)
            {
                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    item.Checked = false;
                }
            }
        }
        private void checkSameProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOrderDetails.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    item.Checked = false;
                }

                foreach (ListViewItem item in lvOrderDetails.Items)
                {
                    if ((lvOrderDetails.SelectedItems[0].Tag as OrderDetail).Product.ID == (item.Tag as OrderDetail).Product.ID)
                        item.Checked = true;
                }
            }
        }

        private void cbListAllProductionHistory_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Enabled)
            {
                RefreshProduceHistory(order.OrderDetails.SelectMany(x => x.ProducedOrders).OrderBy(x => x.ProducedDate));
                RefreshOrderDetailsTotals(order.OrderDetails.ToArray());
            }
            else
                lvOrderDetails_SelectedIndexChangedAndChecked(lvProduceHistory, e);
        }
    }
}
