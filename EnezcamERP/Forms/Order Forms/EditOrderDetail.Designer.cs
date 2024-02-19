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
            nudTaxRatio = new NumericUpDown();
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
            clmProductType = new ColumnHeader();
            clmLastCost = new ColumnHeader();
            clmLastPrice = new ColumnHeader();
            clmIsCounting = new ColumnHeader();
            lblProduct = new Label();
            clmCode = new ColumnHeader();
            gbOrderDetail.SuspendLayout();
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
            gbOrderDetail.Controls.Add(nudTaxRatio);
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
            gbOrderDetail.Location = new Point(12, 12);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(793, 334);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(477, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(634, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Location = new Point(320, 258);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(151, 27);
            nudTaxRatio.TabIndex = 3;
            nudTaxRatio.ThousandsSeparator = true;
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(320, 235);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(83, 20);
            lblTaxRatio.TabIndex = 22;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 3;
            nudQuantity.Location = new Point(163, 258);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(151, 27);
            nudQuantity.TabIndex = 2;
            nudQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(163, 235);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 23;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(634, 257);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(151, 27);
            nudPrice.TabIndex = 5;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(634, 234);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 20);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(477, 258);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(151, 27);
            nudCost.TabIndex = 4;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(477, 236);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(58, 20);
            lblCost.TabIndex = 17;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(6, 257);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(151, 28);
            cbUnitCode.TabIndex = 1;
            cbUnitCode.SelectedIndexChanged += cbUnitCode_SelectedIndexChanged;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(6, 235);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(83, 20);
            lblUnitCode.TabIndex = 16;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductName0, clmCode, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(6, 57);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(779, 175);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.SelectedIndexChanged += lvProducts_SelectedIndexChanged;
            // 
            // clmProductName0
            // 
            clmProductName0.Text = "Ürün Adı";
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
            lblProduct.Location = new Point(6, 34);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(40, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Ürün";
            // 
            // clmCode
            // 
            clmCode.Text = "Ürün Kodu";
            // 
            // EditOrderDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(814, 355);
            Controls.Add(gbOrderDetail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditOrderDetail";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Detayı Güncelle";
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
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
    }
}