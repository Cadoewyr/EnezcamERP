using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Order_Forms
{
    partial class Fire : Form
    {
        public Fire(OrderDetail[] orderDetails)
        {
            InitializeComponent();

            gbPaint.Paint += new PaintEventHandler(DrawFireVisualization);
            this.orderDetails = orderDetails;
        }

        decimal plateWidth = 3210, plateHeight = 2500, gWidth, gHeigth;
        OrderDetail[] orderDetails;

        // Yerleştirilemeyen camları tutmak için bir liste oluştur
        List<OrderDetail> nonPlacedGlasses = [];


        void DrawFireRatio(float totalGlassArea, Graphics g)
        {
            // Plakanın toplam alanı
            float plateArea = (float)plateWidth * (float)plateHeight;

            // Fire alanı: plakanın toplam alanından sadece yerleşen camların toplam alanını çıkar
            float fireArea = plateArea - totalGlassArea;

            // Fire oranı: fire alanının plaka alanına oranı, yüzde olarak hesaplanır
            float fireRatio = (fireArea / plateArea) * 100;  // Yüzde olarak fire oranı

            // Fire oranını sağ alt köşeye yerleştir
            string fireText = $"Toplam Fire: {fireRatio:F2}%";
            Font fireFont = new Font("Arial", 12);
            SizeF fireTextSize = g.MeasureString(fireText, fireFont);

            // Yazıyı sağ alt köşeye çiz (gbPaint sınırlarına göre ayarlama)
            float fireTextX = gbPaint.ClientSize.Width - fireTextSize.Width - 10;  // Sağdan 10 piksel boşluk
            float fireTextY = gbPaint.ClientSize.Height - fireTextSize.Height - 10; // Alttan 10 piksel boşluk
            g.DrawString(fireText, fireFont, Brushes.Black, new PointF(fireTextX, fireTextY));
        }
        private void DrawFireVisualization(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // GroupBox içindeki kullanılabilir alanı alalım (kenarlardan 10 piksel boşluk)
            float groupBoxWidth = gbPaint.ClientSize.Width - 20;
            float groupBoxHeight = gbPaint.ClientSize.Height - 20;

            // Plaka boyutlarını ölçeklemek için kullanılacak faktör
            float widthScaleFactor = groupBoxWidth / (float)plateWidth;
            float heightScaleFactor = groupBoxHeight / (float)plateHeight;
            float scaleFactor = Math.Min(widthScaleFactor, heightScaleFactor);  // En küçük ölçekleme faktörü

            // Ölçeklenmiş plaka boyutları
            float scaledPlateWidth = (float)plateWidth * scaleFactor;
            float scaledPlateHeight = (float)plateHeight * scaleFactor;

            // Plakayı ortalamak için başlangıç noktalarını hesapla
            float xOffset = (gbPaint.ClientSize.Width - scaledPlateWidth) / 2;
            float yOffset = (gbPaint.ClientSize.Height - scaledPlateHeight) / 2;

            // Plakayı çiz
            g.FillRectangle(Brushes.LightGray, new RectangleF(xOffset, yOffset, scaledPlateWidth, scaledPlateHeight));

            // Yerleştirilemeyen camları takip etmek için listeyi sıfırla
            nonPlacedGlasses = new List<OrderDetail>();

            // Camların yerleştirilmesi
            float totalGlassArea = PlaceAndDrawGlasses(g, xOffset, yOffset, scaleFactor, groupBoxWidth, groupBoxHeight);

            // Fire oranını çiz
            DrawFireRatio(totalGlassArea);
        }

        // Camları yerleştir ve çiz
        private float PlaceAndDrawGlasses(Graphics g, float xOffset, float yOffset, float scaleFactor, float maxWidth, float maxHeight)
        {
            float currentX = xOffset;
            float currentY = yOffset;
            float maxRowHeight = 0;
            float totalGlassArea = 0;

            bool useQuantity = cbUseQuantity.Checked;

            for (int i = 0; i < orderDetails.Length; i++)
            {
                float glassWidth = (float)orderDetails[i].Width * 1000;
                float glassHeight = (float)orderDetails[i].Height * 1000;

                int quantity = useQuantity ? orderDetails[i].Quantity : 1;
                int nonPlacedQuantity = quantity;

                for (int q = 0; q < quantity; q++)
                {
                    bool placed = TryPlaceGlass(g, orderDetails[i], ref currentX, ref currentY, ref maxRowHeight, glassWidth, glassHeight, scaleFactor, maxWidth, maxHeight, xOffset);

                    if (placed)
                    {
                        totalGlassArea += glassWidth * glassHeight;
                        nonPlacedQuantity--;
                    }
                }

                // Eğer yerleştirilemeyen cam adedi kaldıysa listeye ekle
                if (nonPlacedQuantity > 0)
                {
                    AddOrUpdateNonPlacedGlass(orderDetails[i], nonPlacedQuantity);
                }
            }

            return totalGlassArea;
        }

        // Cam yerleştirme ve çizim işlemi
        private bool TryPlaceGlass(Graphics g, OrderDetail orderDetail, ref float currentX, ref float currentY, ref float maxRowHeight, float glassWidth, float glassHeight, float scaleFactor, float maxWidth, float maxHeight, float xOffset)
        {
            float scaledGlassWidth = glassWidth * scaleFactor;
            float scaledGlassHeight = glassHeight * scaleFactor;

            bool placed = false;

            // İlk deneme: Camı döndürmeden yerleştir
            if (currentX + scaledGlassWidth <= maxWidth && currentY + scaledGlassHeight <= maxHeight)
            {
                DrawGlass(g, orderDetail, currentX, currentY, scaledGlassWidth, scaledGlassHeight);
                currentX += scaledGlassWidth;
                placed = true;
            }
            // İkinci deneme: Camı döndürerek yerleştir
            else if (currentX + scaledGlassHeight <= maxWidth && currentY + scaledGlassWidth <= maxHeight)
            {
                DrawGlass(g, orderDetail, currentX, currentY, scaledGlassHeight, scaledGlassWidth);
                currentX += scaledGlassHeight;
                placed = true;
            }

            if (placed)
            {
                maxRowHeight = Math.Max(maxRowHeight, scaledGlassHeight);
            }
            else
            {
                // Yeni satıra geç
                currentX = xOffset;  // İlk sütuna geri dön
                currentY += maxRowHeight;  // Y eksenini güncelle
                maxRowHeight = 0;  // Satır yüksekliğini sıfırla
            }

            return placed;
        }

        // Camı çizme
        private void DrawGlass(Graphics g, OrderDetail orderDetail, float x, float y, float width, float height)
        {
            g.FillRectangle(Brushes.Blue, new RectangleF(x, y, width, height));
            g.DrawRectangle(new Pen(Color.Black, 1), x, y, width, height);

            // Cam ölçüsünü ortada göster
            string glassSizeText = $"{(int)(orderDetail.Width * 1000)} x {(int)(orderDetail.Height * 1000)}";
            Font font = new Font("Arial", 8, FontStyle.Bold);
            SizeF textSize = g.MeasureString(glassSizeText, font);
            float textX = x + (width - textSize.Width) / 2;
            float textY = y + (height - textSize.Height) / 2;
            g.DrawString(glassSizeText, font, Brushes.White, new PointF(textX, textY));
        }

        // Fire oranını hesapla ve çiz
        private void DrawFireRatio(float totalGlassArea)
        {
            float plateArea = (float)plateWidth * (float)plateHeight;
            float fireArea = plateArea - totalGlassArea;
            float fireRatio = (fireArea / plateArea) * 100;

            // Fire oranını çiz
            string fireText = $"Toplam Fire: {fireRatio:F2}%";
            Font fireFont = new Font("Arial", 12);
            SizeF fireTextSize = gbPaint.CreateGraphics().MeasureString(fireText, fireFont);
            float fireTextX = gbPaint.ClientSize.Width - fireTextSize.Width - 10;
            float fireTextY = gbPaint.ClientSize.Height - fireTextSize.Height - 10;

            gbPaint.CreateGraphics().DrawString(fireText, fireFont, Brushes.Black, new PointF(fireTextX, fireTextY));
        }

        // Yerleştirilemeyen camları listeye ekleme ya da güncelleme
        private void AddOrUpdateNonPlacedGlass(OrderDetail orderDetail, int nonPlacedQuantity)
        {
            var existingGlass = nonPlacedGlasses.FirstOrDefault(x => x.Width == orderDetail.Width && x.Height == orderDetail.Height);

            if (existingGlass == null)
            {
                nonPlacedGlasses.Add(new OrderDetail
                {
                    Product = orderDetail.Product,
                    Width = orderDetail.Width,
                    Height = orderDetail.Height,
                    Quantity = nonPlacedQuantity
                });
            }
            else
            {
                existingGlass.Quantity += nonPlacedQuantity;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.plateWidth = nudWidth.Value;
            this.plateHeight = nudHeight.Value;

            gbPaint.Refresh();

            lvNonPlacedGlasses.Items.Clear();

            foreach (OrderDetail item in nonPlacedGlasses)
            {
                ListViewItem lvi = new()
                {
                    Text = item.Product.Code,
                };

                lvi.SubItems.Add($"{(int)(item.Width * 1000)} x {(int)(item.Height * 1000)}");
                lvi.SubItems.Add(item.Quantity.ToString());

                lvNonPlacedGlasses.Items.Add(lvi);
            }

            lvNonPlacedGlasses.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
