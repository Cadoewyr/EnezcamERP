namespace EnezcamERP.Forms.Order_Forms
{
    partial class ProductPriceHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvPriceHistory = new ListView();
            Date = new ColumnHeader();
            clmCode = new ColumnHeader();
            clmName = new ColumnHeader();
            Cost = new ColumnHeader();
            Price = new ColumnHeader();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // lvPriceHistory
            // 
            lvPriceHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvPriceHistory.Columns.AddRange(new ColumnHeader[] { Date, clmCode, clmName, Cost, Price });
            lvPriceHistory.FullRowSelect = true;
            lvPriceHistory.GridLines = true;
            lvPriceHistory.Location = new Point(12, 12);
            lvPriceHistory.MultiSelect = false;
            lvPriceHistory.Name = "lvPriceHistory";
            lvPriceHistory.Size = new Size(1114, 510);
            lvPriceHistory.TabIndex = 0;
            lvPriceHistory.UseCompatibleStateImageBehavior = false;
            lvPriceHistory.View = View.Details;
            // 
            // Date
            // 
            Date.Text = "Tarih";
            // 
            // clmCode
            // 
            clmCode.Text = "Ürün Kodu";
            // 
            // clmName
            // 
            clmName.Text = "Ürün Adı";
            // 
            // Cost
            // 
            Cost.Text = "Maliyet";
            // 
            // Price
            // 
            Price.Text = "Tutar";
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelect.Location = new Point(12, 528);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(1114, 29);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Seç";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // ProductPriceHistory
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 564);
            Controls.Add(btnSelect);
            Controls.Add(lvPriceHistory);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductPriceHistory";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Fiyat Geçmişi";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvPriceHistory;
        private Button btnSelect;
        private ColumnHeader clmCode;
        private ColumnHeader clmName;
        private ColumnHeader Cost;
        private ColumnHeader Price;
        private ColumnHeader Date;
    }
}