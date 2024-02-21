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
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTaxRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            SuspendLayout();
            // 
            // gbOrderDetail
            // 
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
            gbOrderDetail.Size = new Size(694, 250);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(467, 223);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 22);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(580, 223);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 22);
            btnSave.TabIndex = 8;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudDiscountRatio
            // 
            nudDiscountRatio.Location = new Point(354, 196);
            nudDiscountRatio.Margin = new Padding(3, 2, 3, 2);
            nudDiscountRatio.Name = "nudDiscountRatio";
            nudDiscountRatio.Size = new Size(107, 23);
            nudDiscountRatio.TabIndex = 4;
            nudDiscountRatio.ThousandsSeparator = true;
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Location = new Point(241, 196);
            nudTaxRatio.Margin = new Padding(3, 2, 3, 2);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(107, 23);
            nudTaxRatio.TabIndex = 3;
            nudTaxRatio.ThousandsSeparator = true;
            // 
            // lblDiscountRatio
            // 
            lblDiscountRatio.AutoSize = true;
            lblDiscountRatio.Location = new Point(354, 179);
            lblDiscountRatio.Name = "lblDiscountRatio";
            lblDiscountRatio.Size = new Size(78, 15);
            lblDiscountRatio.TabIndex = 22;
            lblDiscountRatio.Text = "İskonto Oranı";
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(241, 178);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(65, 15);
            lblTaxRatio.TabIndex = 22;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 3;
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
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(128, 179);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(41, 15);
            lblQuantity.TabIndex = 23;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
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
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(580, 179);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
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
            lblCost.AutoSize = true;
            lblCost.Location = new Point(467, 179);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(46, 15);
            lblCost.TabIndex = 17;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(6, 196);
            cbUnitCode.Margin = new Padding(3, 2, 3, 2);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(116, 23);
            cbUnitCode.TabIndex = 1;
            cbUnitCode.SelectedIndexChanged += cbUnitCode_SelectedIndexChanged;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(6, 179);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(66, 15);
            lblUnitCode.TabIndex = 16;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductName0, clmCode, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(5, 43);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(682, 132);
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
            lblProduct.Location = new Point(5, 26);
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
            ClientSize = new Size(712, 266);
            Controls.Add(gbOrderDetail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EditOrderDetail";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Detayı Güncelle";
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
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
    }
}