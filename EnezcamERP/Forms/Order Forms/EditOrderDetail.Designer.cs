namespace EnezcamERP.Forms.Order_Forms
{
    partial class EditOrderDetail
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
            gbOrderDetail = new GroupBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            nudHeight = new NumericUpDown();
            lblHeight = new Label();
            nudWidth = new NumericUpDown();
            lblWidth = new Label();
            cbUpdateSameProducts = new CheckBox();
            cbUpdatePriceHistory = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            nudDiscountRatio = new NumericUpDown();
            nudTaxRatio = new NumericUpDown();
            lblDiscountRatio = new Label();
            lblTaxRatio = new Label();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            nudPrice = new NumericUpDown();
            lblPrice = new Label();
            nudCost = new NumericUpDown();
            lblCost = new Label();
            cbUnitCode = new ComboBox();
            lblUnitCode = new Label();
            lvProducts = new ListView();
            clmProductName0 = new ColumnHeader();
            clmCode = new ColumnHeader();
            clmProductType = new ColumnHeader();
            clmLastCost = new ColumnHeader();
            clmLastPrice = new ColumnHeader();
            clmIsCounting = new ColumnHeader();
            lblProduct = new Label();
            gbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTaxRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            SuspendLayout();
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrderDetail.Controls.Add(lblSearch);
            gbOrderDetail.Controls.Add(txtSearch);
            gbOrderDetail.Controls.Add(nudHeight);
            gbOrderDetail.Controls.Add(lblHeight);
            gbOrderDetail.Controls.Add(nudWidth);
            gbOrderDetail.Controls.Add(lblWidth);
            gbOrderDetail.Controls.Add(cbUpdateSameProducts);
            gbOrderDetail.Controls.Add(cbUpdatePriceHistory);
            gbOrderDetail.Controls.Add(btnCancel);
            gbOrderDetail.Controls.Add(btnSave);
            gbOrderDetail.Controls.Add(nudDiscountRatio);
            gbOrderDetail.Controls.Add(nudTaxRatio);
            gbOrderDetail.Controls.Add(lblDiscountRatio);
            gbOrderDetail.Controls.Add(lblTaxRatio);
            gbOrderDetail.Controls.Add(nudQuantity);
            gbOrderDetail.Controls.Add(lblQuantity);
            gbOrderDetail.Controls.Add(nudPrice);
            gbOrderDetail.Controls.Add(lblPrice);
            gbOrderDetail.Controls.Add(nudCost);
            gbOrderDetail.Controls.Add(lblCost);
            gbOrderDetail.Controls.Add(cbUnitCode);
            gbOrderDetail.Controls.Add(lblUnitCode);
            gbOrderDetail.Controls.Add(lvProducts);
            gbOrderDetail.Controls.Add(lblProduct);
            gbOrderDetail.Location = new Point(10, 9);
            gbOrderDetail.Margin = new Padding(3, 2, 3, 2);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Padding = new Padding(3, 2, 3, 2);
            gbOrderDetail.Size = new Size(919, 250);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(659, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(25, 15);
            lblSearch.TabIndex = 29;
            lblSearch.Text = "Ara";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(692, 18);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.MaxLength = 200;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 23);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // nudHeight
            // 
            nudHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudHeight.Location = new Point(804, 196);
            nudHeight.Margin = new Padding(3, 2, 3, 2);
            nudHeight.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(107, 23);
            nudHeight.TabIndex = 8;
            nudHeight.ThousandsSeparator = true;
            nudHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(804, 178);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(56, 15);
            lblHeight.TabIndex = 25;
            lblHeight.Text = "Yükseklik";
            // 
            // nudWidth
            // 
            nudWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudWidth.Location = new Point(692, 196);
            nudWidth.Margin = new Padding(3, 2, 3, 2);
            nudWidth.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(107, 23);
            nudWidth.TabIndex = 7;
            nudWidth.ThousandsSeparator = true;
            nudWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(692, 178);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(48, 15);
            lblWidth.TabIndex = 27;
            lblWidth.Text = "Genişlik";
            // 
            // cbUpdateSameProducts
            // 
            cbUpdateSameProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbUpdateSameProducts.AutoSize = true;
            cbUpdateSameProducts.Location = new Point(137, 223);
            cbUpdateSameProducts.Margin = new Padding(3, 2, 3, 2);
            cbUpdateSameProducts.Name = "cbUpdateSameProducts";
            cbUpdateSameProducts.Size = new Size(144, 19);
            cbUpdateSameProducts.TabIndex = 10;
            cbUpdateSameProducts.Text = "Aynı Ürünleri Güncelle";
            cbUpdateSameProducts.UseVisualStyleBackColor = true;
            // 
            // cbUpdatePriceHistory
            // 
            cbUpdatePriceHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbUpdatePriceHistory.AutoSize = true;
            cbUpdatePriceHistory.Location = new Point(5, 223);
            cbUpdatePriceHistory.Margin = new Padding(3, 2, 3, 2);
            cbUpdatePriceHistory.Name = "cbUpdatePriceHistory";
            cbUpdatePriceHistory.Size = new Size(126, 19);
            cbUpdatePriceHistory.TabIndex = 9;
            cbUpdatePriceHistory.Text = "Son Fiyatı Güncelle";
            cbUpdatePriceHistory.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(692, 223);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 22);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(804, 223);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 22);
            btnSave.TabIndex = 12;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudDiscountRatio
            // 
            nudDiscountRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudDiscountRatio.Location = new Point(354, 196);
            nudDiscountRatio.Margin = new Padding(3, 2, 3, 2);
            nudDiscountRatio.Name = "nudDiscountRatio";
            nudDiscountRatio.Size = new Size(107, 23);
            nudDiscountRatio.TabIndex = 4;
            nudDiscountRatio.ThousandsSeparator = true;
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudTaxRatio.Location = new Point(241, 196);
            nudTaxRatio.Margin = new Padding(3, 2, 3, 2);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(107, 23);
            nudTaxRatio.TabIndex = 3;
            nudTaxRatio.ThousandsSeparator = true;
            // 
            // lblDiscountRatio
            // 
            lblDiscountRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDiscountRatio.AutoSize = true;
            lblDiscountRatio.Location = new Point(354, 178);
            lblDiscountRatio.Name = "lblDiscountRatio";
            lblDiscountRatio.Size = new Size(78, 15);
            lblDiscountRatio.TabIndex = 22;
            lblDiscountRatio.Text = "İskonto Oranı";
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(241, 178);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(65, 15);
            lblTaxRatio.TabIndex = 22;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudQuantity.Location = new Point(128, 196);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(107, 23);
            nudQuantity.TabIndex = 2;
            nudQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(128, 178);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(41, 15);
            lblQuantity.TabIndex = 23;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(580, 196);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(107, 23);
            nudPrice.TabIndex = 6;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(580, 178);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(467, 196);
            nudCost.Margin = new Padding(3, 2, 3, 2);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(107, 23);
            nudCost.TabIndex = 5;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCost.AutoSize = true;
            lblCost.Location = new Point(467, 178);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(46, 15);
            lblCost.TabIndex = 17;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(6, 196);
            cbUnitCode.Margin = new Padding(3, 2, 3, 2);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(116, 23);
            cbUnitCode.TabIndex = 1;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(6, 178);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(66, 15);
            lblUnitCode.TabIndex = 16;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductName0, clmCode, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(5, 43);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(909, 132);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.SelectedIndexChanged += lvProducts_SelectedIndexChanged;
            // 
            // clmProductName0
            // 
            clmProductName0.Text = "Ürün Adı";
            // 
            // clmCode
            // 
            clmCode.Text = "Ürün Kodu";
            // 
            // clmProductType
            // 
            clmProductType.Text = "Ürün Tipi";
            // 
            // clmLastCost
            // 
            clmLastCost.Text = "Son Maliyet";
            // 
            // clmLastPrice
            // 
            clmLastPrice.Text = "Son Fiyat";
            // 
            // clmIsCounting
            // 
            clmIsCounting.Text = "Toplam Miktara Dahil";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(5, 23);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(33, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Ürün";
            // 
            // EditOrderDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(936, 265);
            Controls.Add(gbOrderDetail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditOrderDetail";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Detayı Güncelle";
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTaxRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrderDetail;
        private Label lblProduct;
        private ListView lvProducts;
        private ColumnHeader clmProductName0;
        private ColumnHeader clmProductType;
        private ColumnHeader clmLastCost;
        private ColumnHeader clmLastPrice;
        private ColumnHeader clmIsCounting;
        private NumericUpDown nudTaxRatio;
        private Label lblTaxRatio;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private NumericUpDown nudPrice;
        private Label lblPrice;
        private NumericUpDown nudCost;
        private Label lblCost;
        private ComboBox cbUnitCode;
        private Label lblUnitCode;
        private Button btnCancel;
        private Button btnSave;
        private ColumnHeader clmCode;
        private NumericUpDown nudDiscountRatio;
        private Label lblDiscountRatio;
        private CheckBox cbUpdatePriceHistory;
        private NumericUpDown nudHeight;
        private Label lblHeight;
        private NumericUpDown nudWidth;
        private Label lblWidth;
        private Label lblSearch;
        private TextBox txtSearch;
        private CheckBox cbUpdateSameProducts;
    }
}