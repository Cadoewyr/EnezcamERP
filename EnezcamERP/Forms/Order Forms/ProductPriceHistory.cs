using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Order_Forms
{
    public partial class ProductPriceHistory : Form
    {
        public ProductPriceHistory(Product? product, decimal cost, decimal price)
        {
            InitializeComponent();

            if (product == null)
                this.Close();

            this.product = product;
            this.cost = cost;
            this.price = price;

            GetPriceHistory();
            RefreshList();
        }

        async void GetPriceHistory()
        {
            OrderDetailsRepository orderDetailsRepository = new();
            var res = orderDetailsRepository.GetAll(x => x.Product.Code == product.Code | x.Product.Name == product.Name | x.UnitPrice == price | x.UnitCost == cost).DistinctBy(x => x.CreatedAt.Date).OrderByDescending(x => x.CreatedAt);

            foreach (var item in res)
            {
                //if(!PriceHistoryResults.Exists(x=>x.Cost == item.UnitCost & x.Price == item.UnitPrice & x.Date.Date == item.CreatedAt.Date & x.Product.ID == item.Product.ID))
                //{
                PriceHistoryResults.Add(new PriceHistory()
                {
                    Cost = item.UnitCost,
                    Price = item.UnitPrice,
                    Product = item.Product,
                    Date = item.CreatedAt
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
        }

        Product product;
        decimal cost, price;
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
