using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Order_Forms
{
    partial class Fire : Form
    {
        public Fire(OrderDetail orderDetail)
        {
            InitializeComponent();

            gbPaint.Paint += new PaintEventHandler(DrawFireVisualization);
            this.orderDetail = orderDetail;
            gWidth = orderDetail.Width * 1000;
            gHeigth = orderDetail.Height * 1000;
        }

        decimal plateWidth = 3210, plateHeigth = 2500, gWidth, gHeigth;
        OrderDetail orderDetail;

        void DrawFireVisualization(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // GroupBox içindeki kullanılabilir alanı alalım
            float groupBoxWidth = gbPaint.ClientSize.Width - 20;  // Kenarlardan 10 piksel boşluk
            float groupBoxHeight = gbPaint.ClientSize.Height - 20;  // Kenarlardan 10 piksel boşluk

            // Plaka ve cam boyutlarını ölçeklemek için kullanılacak faktör
            float widthScaleFactor = groupBoxWidth / (float)plateWidth;
            float heightScaleFactor = groupBoxHeight / (float)plateHeigth;

            // Her iki eksende de en küçük ölçekleme faktörünü kullanarak orantılı küçültme
            float scaleFactor = Math.Min(widthScaleFactor, heightScaleFactor);

            // Ölçeklenmiş plaka boyutları
            float scaledPlateWidth = (float)plateWidth * scaleFactor;
            float scaledPlateHeight = (float)plateHeigth * scaleFactor;

            // Ölçeklenmiş cam boyutları
            float scaledCamWidth = (float)gWidth * scaleFactor;
            float scaledCamHeight = (float)gHeigth * scaleFactor;

            // Plakayı ve camı ortalamak için başlangıç noktalarını hesaplayalım
            float xOffset = (gbPaint.ClientSize.Width - scaledPlateWidth) / 2;  // X ekseninde ortalama
            float yOffset = (gbPaint.ClientSize.Height - scaledPlateHeight) / 2; // Y ekseninde ortalama

            // Plaka çizimi (gri dikdörtgen)
            g.FillRectangle(Brushes.LightGray, new RectangleF(xOffset, yOffset, scaledPlateWidth, scaledPlateHeight));

            // Cam çizimi (mavi dikdörtgen)
            g.FillRectangle(Brushes.Blue, new RectangleF(xOffset, yOffset, scaledCamWidth, scaledCamHeight));

            // Fire alanını vurgulamak için kenar çerçevesi (kırmızı çizgi ile gösterilecek)
            g.DrawRectangle(new Pen(Color.Red, 2), new RectangleF(xOffset, yOffset, scaledPlateWidth, scaledPlateHeight));

            // Fire oranını hesaplayalım
            float plateArea = (float)plateWidth * (float)plateHeigth;
            float camArea = (float)gWidth * (float)gHeigth;
            float fireArea = plateArea - camArea;
            float fireRatio = (fireArea / plateArea) * 100;  // Yüzde olarak fire oranı

            // Fire oranını sağ alt köşeye yerleştirelim
            string fireText = $"Fire: {fireRatio:F2}%";
            Font font = new Font("Arial", 12);
            SizeF textSize = g.MeasureString(fireText, font);

            // Yazıyı sağ alt köşeye çizelim (gbPaint sınırlarına göre ayarlama)
            float textX = gbPaint.ClientSize.Width - textSize.Width - 10;  // Sağdan 10 piksel boşluk
            float textY = gbPaint.ClientSize.Height - textSize.Height - 10; // Alttan 10 piksel boşluk
            g.DrawString(fireText, font, Brushes.Black, new PointF(textX, textY));
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.plateWidth = nudWidth.Value;
            this.plateHeigth = nudHeight.Value;

            gbPaint.Refresh();
        }
    }
}
