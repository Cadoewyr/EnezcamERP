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
            cbUpdateSameProductPrices = new CheckBox();
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
            gbOrderDetail.Controls.Add(cbUpdateSameProductPrices);
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
            gbOrderDetail.Location = new Point(11, 12);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(1050, 334);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(753, 27);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(32, 20);
            lblSearch.TabIndex = 29;
            lblSearch.Text = "Ara";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(791, 24);
            txtSearch.MaxLength = 200;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 27);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // nudHeight
            // 
            nudHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudHeight.Location = new Point(919, 261);
            nudHeight.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(122, 27);
            nudHeight.TabIndex = 8;
            nudHeight.ThousandsSeparator = true;
            nudHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(919, 238);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(68, 20);
            lblHeight.TabIndex = 25;
            lblHeight.Text = "Yükseklik";
            // 
            // nudWidth
            // 
            nudWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudWidth.Location = new Point(791, 261);
            nudWidth.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(122, 27);
            nudWidth.TabIndex = 7;
            nudWidth.ThousandsSeparator = true;
            nudWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(791, 238);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(60, 20);
            lblWidth.TabIndex = 27;
            lblWidth.Text = "Genişlik";
            // 
            // cbUpdateSameProductPrices
            // 
            cbUpdateSameProductPrices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbUpdateSameProductPrices.AutoSize = true;
            cbUpdateSameProductPrices.Location = new Point(168, 297);
            cbUpdateSameProductPrices.Name = "cbUpdateSameProductPrices";
            cbUpdateSameProductPrices.Size = new Size(298, 24);
            cbUpdateSameProductPrices.TabIndex = 10;
            cbUpdateSameProductPrices.Text = "Listedeki Aynı Ürünlerin Fiyatını Güncelle";
            cbUpdateSameProductPrices.UseVisualStyleBackColor = true;
            // 
            // cbUpdatePriceHistory
            // 
            cbUpdatePriceHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbUpdatePriceHistory.AutoSize = true;
            cbUpdatePriceHistory.Location = new Point(6, 297);
            cbUpdatePriceHistory.Name = "cbUpdatePriceHistory";
            cbUpdatePriceHistory.Size = new Size(156, 24);
            cbUpdatePriceHistory.TabIndex = 9;
            cbUpdatePriceHistory.Text = "Son Fiyatı Güncelle";
            cbUpdatePriceHistory.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(790, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(919, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudDiscountRatio
            // 
            nudDiscountRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudDiscountRatio.Location = new Point(405, 261);
            nudDiscountRatio.Name = "nudDiscountRatio";
            nudDiscountRatio.Size = new Size(122, 27);
            nudDiscountRatio.TabIndex = 4;
            nudDiscountRatio.ThousandsSeparator = true;
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudTaxRatio.Location = new Point(275, 261);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(122, 27);
            nudTaxRatio.TabIndex = 3;
            nudTaxRatio.ThousandsSeparator = true;
            // 
            // lblDiscountRatio
            // 
            lblDiscountRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDiscountRatio.AutoSize = true;
            lblDiscountRatio.Location = new Point(405, 238);
            lblDiscountRatio.Name = "lblDiscountRatio";
            lblDiscountRatio.Size = new Size(97, 20);
            lblDiscountRatio.TabIndex = 22;
            lblDiscountRatio.Text = "İskonto Oranı";
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(275, 238);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(83, 20);
            lblTaxRatio.TabIndex = 22;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudQuantity.Location = new Point(146, 261);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(122, 27);
            nudQuantity.TabIndex = 2;
            nudQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(146, 238);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 23;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(663, 261);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(122, 27);
            nudPrice.TabIndex = 6;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(663, 238);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 20);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(534, 261);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(122, 27);
            nudCost.TabIndex = 5;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCost.AutoSize = true;
            lblCost.Location = new Point(534, 238);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(58, 20);
            lblCost.TabIndex = 17;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(7, 261);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(132, 28);
            cbUnitCode.TabIndex = 1;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(7, 238);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(83, 20);
            lblUnitCode.TabIndex = 16;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductName0, clmCode, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(6, 57);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(1038, 175);
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
            lblProduct.Location = new Point(6, 31);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(40, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Ürün";
            // 
            // EditOrderDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1070, 353);
            Controls.Add(gbOrderDetail);
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
        private CheckBox cbUpdateSameProductPrices;
    }
}