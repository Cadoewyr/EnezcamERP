using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Order_Forms
{
    public partial class ProductPriceHistory : Form
    {
        public ProductPriceHistory(OrderDetail orderDetail)
        {
            InitializeComponent();

            GetPriceHistory(orderDetail);
            RefreshList();
        }

        void GetPriceHistory(OrderDetail orderDetail)
        {
            OrderDetailsRepository orderDetailsRepository = new();

            var res = orderDetailsRepository.GetAll()
            .Where(x => x.Product.Code == orderDetail.Product.Code ||
                       (x.Width == orderDetail.Width || x.Width == orderDetail.Height) &&
                       (x.Height == orderDetail.Width || x.Height == orderDetail.Height))
            .AsEnumerable()
            .DistinctBy(x => x.CreatedAt.Date)
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => new
            {
                x.CreatedAt,
                x.Product,
                x.Width,
                x.Height,
                x.UnitCost,
                x.UnitPrice
            })
            .ToList();

            foreach (var item in res)
            {
                //if(!PriceHistoryResults.Exists(x=>x.Cost == item.UnitCost & x.Price == item.UnitPrice & x.Date.Date == item.CreatedAt.Date & x.Product.ID == item.Product.ID))
                //{
                PriceHistoryResults.Add(new PriceHistory()
                {
                    Cost = item.UnitCost,
                    Price = item.UnitPrice,
                    Product = item.Product,
                    Date = item.CreatedAt,
                    Width = item.Width,
                    Height = item.Height
                });
                //}
            }
        }
        void RefreshList()
        {
            lvPriceHistory.Items.Clear();

            foreach (var item in PriceHistoryResults)
            {
                ListViewItem lvItem = new()
                {
                    Tag = item
                };

                lvItem.Text = item.Date.ToShortDateString();

                lvItem.SubItems.Add(item.Product.Code);
                lvItem.SubItems.Add(item.Product.Name);
                lvItem.SubItems.Add($"{item.Width} * {item.Height}");
                lvItem.SubItems.Add(item.Cost.ToString("C2"));
                lvItem.SubItems.Add(item.Price.ToString("C2"));

                lvPriceHistory.Items.Add(lvItem);
            }

            lvPriceHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public class PriceHistory()
        {
            public DateTime Date { get; set; }
            public Product Product { get; set; }
            public decimal Cost { get; set; }
            public decimal Price { get; set; }
            public decimal Width { get; set; }
            public decimal Height { get; set; }
        }

        List<PriceHistory> PriceHistoryResults = [];

        public PriceHistory Result = new();

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvPriceHistory.SelectedItems.Count > 0)
            {
                var priceHistory = lvPriceHistory.SelectedItems[0].Tag as PriceHistory;

                this.DialogResult = DialogResult.OK;
                Result = priceHistory;
            }
        }
    }
}
