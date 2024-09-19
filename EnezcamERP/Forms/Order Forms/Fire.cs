using DAL.DTO.Entities;
using System.Drawing.Drawing2D;

namespace EnezcamERP.Forms.Order_Forms
{
    partial class Fire : Form
    {
        public Fire(OrderDetail[] orderDetails)
        {
            InitializeComponent();

            this.orderDetails = orderDetails;
        }

        int plateWidth = 3210, plateHeight = 2500, gWidth, gHeigth;
        OrderDetail[] orderDetails;

        // Yerleştirilemeyen camları tutmak için bir liste oluştur
        List<OrderDetail> nonPlacedGlasses = [];

        private Bitmap CreatePlakaBitmap(int plateWidth, int plateHeight)
        {
            // Gerçek plaka boyutlarına göre bir bitmap oluşturuyoruz
            Bitmap bitmap = new Bitmap(plateWidth, plateHeight);

            // Bitmap çözünürlüğünü artırıyoruz
            bitmap.SetResolution(300, 300);  // Yüksek çözünürlük

            // Bitmap üzerine çizim yapmak için Graphics nesnesi oluşturuyoruz
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Yüksek kalite çizim modları
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Plakayı dolduruyoruz (gri renk)
                g.FillRectangle(Brushes.LightGray, new Rectangle(0, 0, plateWidth, plateHeight));

                // Camları çiziyoruz
                PlaceAndDrawGlassesOnBitmap(g, plateWidth, plateHeight);
            }

            return bitmap;
        }

        private void PlaceAndDrawGlassesOnBitmap(Graphics g, int plateWidth, int plateHeight)
        {
            decimal currentX = 0;
            decimal currentY = 0;
            decimal maxRowHeight = 0;

            bool useQuantity = cbUseQuantity.Checked;

            for (int i = 0; i < orderDetails.Length; i++)
            {
                decimal glassWidth = orderDetails[i].Width * 1000;  // Gerçek cam genişliği
                decimal glassHeight = orderDetails[i].Height * 1000;  // Gerçek cam yüksekliği

                int quantity = useQuantity ? orderDetails[i].Quantity : 1;
                int nonPlacedGlassQuantity = quantity;

                for (int q = 0; q < quantity; q++)
                {
                    // Camları yerleştiriyoruz
                    bool placed = TryPlaceGlassOnBitmap(g, orderDetails[i], ref currentX, ref currentY, ref maxRowHeight, glassWidth, glassHeight, plateWidth, plateHeight);

                    if (!placed)
                    {
                        // Cam yerleştirilemezse işlemi durdurabiliriz
                        break;
                    }
                    else
                        nonPlacedGlassQuantity--;
                }

                if(nonPlacedGlassQuantity > 0)
                    AddOrUpdateNonPlacedGlasses(orderDetails[i], nonPlacedGlassQuantity);
            }
        }

        // Camları bitmap üzerine yerleştirme fonksiyonu
        private bool TryPlaceGlassOnBitmap(Graphics g, OrderDetail orderDetail, ref decimal currentX, ref decimal currentY, ref decimal maxRowHeight, decimal glassWidth, decimal glassHeight, int plateWidth, int plateHeight)
        {
            bool placed = false;

            // İlk deneme: Camı döndürmeden yerleştir
            if (currentX + glassWidth <= plateWidth && currentY + glassHeight <= plateHeight)
            {
                // Camı çiziyoruz
                DrawGlassOnBitmap(g, orderDetail, currentX, currentY, glassWidth, glassHeight, plateWidth, plateHeight);
                currentX += glassWidth;  // X ekseninde ilerliyoruz
                placed = true;
            }
            // İkinci deneme: Camı döndürerek yerleştir
            else if (currentX + glassHeight <= plateWidth && currentY + glassWidth <= plateHeight)
            {
                // Camı döndürerek çiziyoruz
                DrawGlassOnBitmap(g, orderDetail, currentX, currentY, glassHeight, glassWidth, plateWidth, plateHeight);
                currentX += glassHeight;  // Döndürülmüş cam için X ekseni güncellemesi
                placed = true;
            }

            if (placed)
            {
                // maxRowHeight, yerleştirilen camın yüksekliği kadar olmalı
                maxRowHeight = Math.Max(maxRowHeight, glassHeight);
            }
            else
            {
                // Eğer cam satıra sığmadıysa yeni satıra geçiyoruz
                currentX = 0;  // Satır başlangıcına dönüyoruz
                currentY += maxRowHeight;  // Y eksenini bir satır aşağıya indiriyoruz

                // maxRowHeight sıfırlanmalı çünkü yeni satırdayız
                maxRowHeight = glassHeight;

                // Yeni satırda yerleştirmeyi tekrar deniyoruz
                if (currentX + glassWidth <= plateWidth && currentY + glassHeight <= plateHeight)
                {
                    DrawGlassOnBitmap(g, orderDetail, currentX, currentY, glassWidth, glassHeight, plateWidth, plateHeight);
                    currentX += glassWidth;  // X ekseninde ilerliyoruz
                    placed = true;
                }
                else if (currentX + glassHeight <= plateWidth && currentY + glassWidth <= plateHeight)
                {
                    DrawGlassOnBitmap(g, orderDetail, currentX, currentY, glassHeight, glassWidth, plateWidth, plateHeight);
                    currentX += glassHeight;  // Döndürülmüş cam için X ekseni güncellemesi
                    placed = true;
                }
            }

            return placed;
        }

        void AddOrUpdateNonPlacedGlasses(OrderDetail orderDetail, int nonPlacedGlassQuantity)
        {
            if (nonPlacedGlasses.Any(x => x.Width == orderDetail.Width && x.Height == orderDetail.Height))
            {
                nonPlacedGlasses.Find(x => x.Width == orderDetail.Width && x.Height == orderDetail.Height).Quantity += nonPlacedGlassQuantity;
            }
            else
            {
                nonPlacedGlasses.Add(new OrderDetail()
                {
                    Quantity = nonPlacedGlassQuantity,
                    Width = orderDetail.Width,
                    Height = orderDetail.Height,
                    Product = orderDetail.Product
                });
            }
        }

        private void DrawGlassOnBitmap(Graphics g, OrderDetail orderDetail, decimal x, decimal y, decimal width, decimal height, int plateWidth, int plateHeight)
        {
            // Dinamik olarak çizgi kalınlığı ayarlayalım
            float lineWidth = Math.Max(1, (float)(Math.Min(plateWidth, plateHeight) / 500.0));  // Plaka boyutlarına göre çizgi kalınlığı

            // Camı mavi renkte çiziyoruz
            g.FillRectangle(Brushes.Blue, new RectangleF((float)x, (float)y, (float)width, (float)height));

            // Camın kenarlarını siyah renkle dinamik çizgi kalınlığı ile çiziyoruz
            g.DrawRectangle(new Pen(Color.Black, lineWidth), (float)x, (float)y, (float)width, (float)height);

            // Camın boyutlarına göre yazı boyutunu ayarlayalım
            float fontSize = (float)Math.Min(width, height) / 5.0f;  // Cam boyutlarına göre yazı boyutu ayarlıyoruz

            // Eğer yazı boyutu çok küçükse, minimum bir yazı boyutu belirleyelim
            fontSize = Math.Max(fontSize, 8);  // Minimum yazı boyutu: 8

            // Camın ölçüsünü ortada gösteriyoruz
            string glassSizeText = $"{(int)(orderDetail.Width * 1000)} x {(int)(orderDetail.Height * 1000)}";
            Font font = new Font("Arial", fontSize, FontStyle.Bold);
            SizeF textSize = g.MeasureString(glassSizeText, font);

            // Yazıyı camın ortasına yerleştiriyoruz, taşmayı önlemek için camın boyutlarını kontrol ediyoruz
            if ((decimal)textSize.Width > width || (decimal)textSize.Height > height)
            {
                // Eğer yazı camdan taşıyorsa, font boyutunu biraz küçültelim
                float scaleFactor = Math.Min((float)width / textSize.Width, (float)height / textSize.Height);
                fontSize *= scaleFactor;  // Font boyutunu küçültüyoruz
                font = new Font("Arial", fontSize, FontStyle.Bold);
                textSize = g.MeasureString(glassSizeText, font);  // Yeni boyutla ölçüyoruz
            }

            // Yazıyı ortalayarak yerleştiriyoruz
            decimal textX = (decimal)x + ((decimal)width - (decimal)textSize.Width) / 2;
            decimal textY = (decimal)y + ((decimal)height - (decimal)textSize.Height) / 2;

            g.DrawString(glassSizeText, font, Brushes.White, new PointF((float)textX, (float)textY));
        }

        private void ShowBitmapInGroupBox(Bitmap bitmap)
        {
            // PictureBox oluşturuyoruz
            PictureBox pictureBox = new PictureBox
            {
                Image = bitmap,
                SizeMode = PictureBoxSizeMode.Zoom,  // Görüntüyü orantılı şekilde sığdırıyoruz
                Dock = DockStyle.Fill
            };

            // PictureBox'ı GroupBox içine yerleştiriyoruz
            gbPaint.Controls.Clear();
            gbPaint.Controls.Add(pictureBox);
        }

        private void DrawVisualization()
        {
            // Yerleştirilemeyen camlar listesini sıfırlıyoruz
            nonPlacedGlasses.Clear();

            // Gerçek plaka boyutlarıyla bir bitmap oluşturuyoruz
            Bitmap plakaBitmap = CreatePlakaBitmap(plateWidth, plateHeight);

            // Bitmap'i GroupBox'a sığacak şekilde gösteriyoruz
            ShowBitmapInGroupBox(plakaBitmap);

            // Burada nonPlacedGlasses listesini formda bir ListView'e aktarabilirsiniz
            UpdateListViewWithNonPlacedGlasses();
        }

        // nonPlacedGlasses listesini ListView'e ekleme işlemi
        private void UpdateListViewWithNonPlacedGlasses()
        {
            lvNonPlacedGlasses.Items.Clear();  // Mevcut öğeleri temizliyoruz

            foreach (var glass in nonPlacedGlasses)
            {
                ListViewItem lvi = new(new string[]
                {
                    glass.Product.Code,
                    $"{(int)(glass.Width * 1000)} x {(int)(glass.Height * 1000)}",
                    glass.Quantity.ToString()
                });

                lvNonPlacedGlasses.Items.Add(lvi);  // Her camı ListView'e ekliyoruz
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.plateWidth = (int)nudWidth.Value;
            this.plateHeight = (int)nudHeight.Value;

            DrawVisualization();

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
