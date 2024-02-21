namespace EnezcamERP.Forms.Order_Forms
{
    partial class AddUpdateOrder
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
            gbOrderHeader = new GroupBox();
            txtJobNo = new TextBox();
            dtpOrderDate = new DateTimePicker();
            dtpDeliveryDate = new DateTimePicker();
            cbCustomers = new ComboBox();
            lblOrderDate = new Label();
            lblDeliveryDate = new Label();
            lblCustomer = new Label();
            lblJobNo = new Label();
            gbOrderDetails = new GroupBox();
            gbOrderTotals = new GroupBox();
            txtPriceWithTax = new TextBox();
            lblPriceWithTax = new Label();
            txtProfitRatio = new TextBox();
            lblPercentage = new Label();
            txtProfit = new TextBox();
            lvlProfit = new Label();
            txtTotalQuantity = new TextBox();
            lblTotalQuantity = new Label();
            txtTotalPrice = new TextBox();
            lvlTotalPrice = new Label();
            txtTotalCost = new TextBox();
            lvlTotalOrderCost = new Label();
            btnCancel = new Button();
            btnSaveOrder = new Button();
            gbAddProductDetail = new GroupBox();
            lvProducts = new ListView();
            clmProductCode = new ColumnHeader();
            clmProductName0 = new ColumnHeader();
            clmProductType = new ColumnHeader();
            clmLastCost = new ColumnHeader();
            clmLastPrice = new ColumnHeader();
            clmIsCounting = new ColumnHeader();
            btnDeleteOrderDetail = new Button();
            btnAddOrderDetail = new Button();
            nudDiscountRatio = new NumericUpDown();
            lblDiscountRatio = new Label();
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
            txtSearchProduct = new TextBox();
            lblProducts = new Label();
            lvOrderDetails = new ListView();
            clmProductName = new ColumnHeader();
            clmUnitCost = new ColumnHeader();
            clmUnitPrice = new ColumnHeader();
            clmDiscountRatio = new ColumnHeader();
            clmTaxRatio = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmProductUnitCode = new ColumnHeader();
            clmProducedQuantity = new ColumnHeader();
            clmRemainingQuantity = new ColumnHeader();
            clmTotalCost = new ColumnHeader();
            clmTotalPrice = new ColumnHeader();
            clmTotalProfit = new ColumnHeader();
            clmTotalProfitPercentage = new ColumnHeader();
            gbOrderHeader.SuspendLayout();
            gbOrderDetails.SuspendLayout();
            gbOrderTotals.SuspendLayout();
            gbAddProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTaxRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            SuspendLayout();
            // 
            // gbOrderHeader
            // 
            gbOrderHeader.Controls.Add(txtJobNo);
            gbOrderHeader.Controls.Add(dtpOrderDate);
            gbOrderHeader.Controls.Add(dtpDeliveryDate);
            gbOrderHeader.Controls.Add(cbCustomers);
            gbOrderHeader.Controls.Add(lblOrderDate);
            gbOrderHeader.Controls.Add(lblDeliveryDate);
            gbOrderHeader.Controls.Add(lblCustomer);
            gbOrderHeader.Controls.Add(lblJobNo);
            gbOrderHeader.Location = new Point(10, 9);
            gbOrderHeader.Margin = new Padding(3, 2, 3, 2);
            gbOrderHeader.Name = "gbOrderHeader";
            gbOrderHeader.Padding = new Padding(3, 2, 3, 2);
            gbOrderHeader.Size = new Size(1082, 58);
            gbOrderHeader.TabIndex = 0;
            gbOrderHeader.TabStop = false;
            gbOrderHeader.Text = "Sipariş Bilgileri";
            // 
            // txtJobNo
            // 
            txtJobNo.Location = new Point(78, 26);
            txtJobNo.Margin = new Padding(3, 2, 3, 2);
            txtJobNo.MaxLength = 200;
            txtJobNo.Name = "txtJobNo";
            txtJobNo.Size = new Size(182, 23);
            txtJobNo.TabIndex = 0;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(610, 25);
            dtpOrderDate.Margin = new Padding(3, 2, 3, 2);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(182, 23);
            dtpOrderDate.TabIndex = 2;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new Point(896, 25);
            dtpDeliveryDate.Margin = new Padding(3, 2, 3, 2);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(182, 23);
            dtpDeliveryDate.TabIndex = 3;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(321, 25);
            cbCustomers.Margin = new Padding(3, 2, 3, 2);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(182, 23);
            cbCustomers.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(526, 28);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(72, 15);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "Sipariş Tarihi";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(812, 28);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(71, 15);
            lblDeliveryDate.TabIndex = 0;
            lblDeliveryDate.Text = "Teslim Tarihi";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(284, 28);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(28, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Cari";
            // 
            // lblJobNo
            // 
            lblJobNo.AutoSize = true;
            lblJobNo.Location = new Point(5, 28);
            lblJobNo.Name = "lblJobNo";
            lblJobNo.Size = new Size(60, 15);
            lblJobNo.TabIndex = 0;
            lblJobNo.Text = "Sipariş No";
            // 
            // gbOrderDetails
            // 
            gbOrderDetails.Controls.Add(gbOrderTotals);
            gbOrderDetails.Controls.Add(gbAddProductDetail);
            gbOrderDetails.Controls.Add(lvOrderDetails);
            gbOrderDetails.Location = new Point(10, 72);
            gbOrderDetails.Margin = new Padding(3, 2, 3, 2);
            gbOrderDetails.Name = "gbOrderDetails";
            gbOrderDetails.Padding = new Padding(3, 2, 3, 2);
            gbOrderDetails.Size = new Size(1082, 367);
            gbOrderDetails.TabIndex = 1;
            gbOrderDetails.TabStop = false;
            gbOrderDetails.Text = "Sipariş Detayı";
            // 
            // gbOrderTotals
            // 
            gbOrderTotals.Controls.Add(txtPriceWithTax);
            gbOrderTotals.Controls.Add(lblPriceWithTax);
            gbOrderTotals.Controls.Add(txtProfitRatio);
            gbOrderTotals.Controls.Add(lblPercentage);
            gbOrderTotals.Controls.Add(txtProfit);
            gbOrderTotals.Controls.Add(lvlProfit);
            gbOrderTotals.Controls.Add(txtTotalQuantity);
            gbOrderTotals.Controls.Add(lblTotalQuantity);
            gbOrderTotals.Controls.Add(txtTotalPrice);
            gbOrderTotals.Controls.Add(lvlTotalPrice);
            gbOrderTotals.Controls.Add(txtTotalCost);
            gbOrderTotals.Controls.Add(lvlTotalOrderCost);
            gbOrderTotals.Controls.Add(btnCancel);
            gbOrderTotals.Controls.Add(btnSaveOrder);
            gbOrderTotals.Location = new Point(788, 179);
            gbOrderTotals.Margin = new Padding(3, 2, 3, 2);
            gbOrderTotals.Name = "gbOrderTotals";
            gbOrderTotals.Padding = new Padding(3, 2, 3, 2);
            gbOrderTotals.Size = new Size(289, 183);
            gbOrderTotals.TabIndex = 2;
            gbOrderTotals.TabStop = false;
            gbOrderTotals.Text = "Sipariş Toplamları";
            // 
            // txtPriceWithTax
            // 
            txtPriceWithTax.Location = new Point(5, 131);
            txtPriceWithTax.Margin = new Padding(3, 2, 3, 2);
            txtPriceWithTax.MaxLength = 200;
            txtPriceWithTax.Name = "txtPriceWithTax";
            txtPriceWithTax.ReadOnly = true;
            txtPriceWithTax.Size = new Size(133, 23);
            txtPriceWithTax.TabIndex = 18;
            txtPriceWithTax.TabStop = false;
            // 
            // lblPriceWithTax
            // 
            lblPriceWithTax.AutoSize = true;
            lblPriceWithTax.Location = new Point(6, 114);
            lblPriceWithTax.Name = "lblPriceWithTax";
            lblPriceWithTax.Size = new Size(91, 15);
            lblPriceWithTax.TabIndex = 17;
            lblPriceWithTax.Text = "Vergi Dahil Fiyat";
            // 
            // txtProfitRatio
            // 
            txtProfitRatio.Location = new Point(144, 87);
            txtProfitRatio.Margin = new Padding(3, 2, 3, 2);
            txtProfitRatio.MaxLength = 200;
            txtProfitRatio.Name = "txtProfitRatio";
            txtProfitRatio.ReadOnly = true;
            txtProfitRatio.Size = new Size(133, 23);
            txtProfitRatio.TabIndex = 16;
            txtProfitRatio.TabStop = false;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(144, 70);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(56, 15);
            lblPercentage.TabIndex = 15;
            lblPercentage.Text = "Kar Oranı";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(144, 44);
            txtProfit.Margin = new Padding(3, 2, 3, 2);
            txtProfit.MaxLength = 200;
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(133, 23);
            txtProfit.TabIndex = 14;
            txtProfit.TabStop = false;
            // 
            // lvlProfit
            // 
            lvlProfit.AutoSize = true;
            lvlProfit.Location = new Point(143, 27);
            lvlProfit.Name = "lvlProfit";
            lvlProfit.Size = new Size(24, 15);
            lvlProfit.TabIndex = 13;
            lvlProfit.Text = "Kar";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(144, 131);
            txtTotalQuantity.Margin = new Padding(3, 2, 3, 2);
            txtTotalQuantity.MaxLength = 200;
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new Size(133, 23);
            txtTotalQuantity.TabIndex = 6;
            txtTotalQuantity.TabStop = false;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(145, 114);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(83, 15);
            lblTotalQuantity.TabIndex = 5;
            lblTotalQuantity.Text = "Toplam Miktar";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(5, 87);
            txtTotalPrice.Margin = new Padding(3, 2, 3, 2);
            txtTotalPrice.MaxLength = 200;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(133, 23);
            txtTotalPrice.TabIndex = 4;
            txtTotalPrice.TabStop = false;
            // 
            // lvlTotalPrice
            // 
            lvlTotalPrice.AutoSize = true;
            lvlTotalPrice.Location = new Point(5, 70);
            lvlTotalPrice.Name = "lvlTotalPrice";
            lvlTotalPrice.Size = new Size(32, 15);
            lvlTotalPrice.TabIndex = 3;
            lvlTotalPrice.Text = "Fiyat";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(5, 44);
            txtTotalCost.Margin = new Padding(3, 2, 3, 2);
            txtTotalCost.MaxLength = 200;
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(133, 23);
            txtTotalCost.TabIndex = 2;
            txtTotalCost.TabStop = false;
            // 
            // lvlTotalOrderCost
            // 
            lvlTotalOrderCost.AutoSize = true;
            lvlTotalOrderCost.Location = new Point(6, 27);
            lvlTotalOrderCost.Name = "lvlTotalOrderCost";
            lvlTotalOrderCost.Size = new Size(46, 15);
            lvlTotalOrderCost.TabIndex = 1;
            lvlTotalOrderCost.Text = "Maliyet";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(107, 157);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelOrder_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(194, 157);
            btnSaveOrder.Margin = new Padding(3, 2, 3, 2);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(82, 22);
            btnSaveOrder.TabIndex = 16;
            btnSaveOrder.Text = "Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // gbAddProductDetail
            // 
            gbAddProductDetail.Controls.Add(lvProducts);
            gbAddProductDetail.Controls.Add(btnDeleteOrderDetail);
            gbAddProductDetail.Controls.Add(btnAddOrderDetail);
            gbAddProductDetail.Controls.Add(nudDiscountRatio);
            gbAddProductDetail.Controls.Add(lblDiscountRatio);
            gbAddProductDetail.Controls.Add(nudTaxRatio);
            gbAddProductDetail.Controls.Add(lblTaxRatio);
            gbAddProductDetail.Controls.Add(nudQuantity);
            gbAddProductDetail.Controls.Add(lblQuantity);
            gbAddProductDetail.Controls.Add(nudPrice);
            gbAddProductDetail.Controls.Add(lblPrice);
            gbAddProductDetail.Controls.Add(nudCost);
            gbAddProductDetail.Controls.Add(lblCost);
            gbAddProductDetail.Controls.Add(cbUnitCode);
            gbAddProductDetail.Controls.Add(lblUnitCode);
            gbAddProductDetail.Controls.Add(txtSearchProduct);
            gbAddProductDetail.Controls.Add(lblProducts);
            gbAddProductDetail.Location = new Point(5, 179);
            gbAddProductDetail.Margin = new Padding(3, 2, 3, 2);
            gbAddProductDetail.Name = "gbAddProductDetail";
            gbAddProductDetail.Padding = new Padding(3, 2, 3, 2);
            gbAddProductDetail.Size = new Size(778, 183);
            gbAddProductDetail.TabIndex = 1;
            gbAddProductDetail.TabStop = false;
            gbAddProductDetail.Text = "Ürün Ekle";
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductCode, clmProductName0, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(5, 44);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(493, 111);
            lvProducts.TabIndex = 14;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.Click += lvProducts_Click;
            // 
            // clmProductCode
            // 
            clmProductCode.Text = "Ürün Kodu";
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
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.Location = new Point(503, 157);
            btnDeleteOrderDetail.Margin = new Padding(3, 2, 3, 2);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(132, 22);
            btnDeleteOrderDetail.TabIndex = 13;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Location = new Point(640, 157);
            btnAddOrderDetail.Margin = new Padding(3, 2, 3, 2);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(132, 22);
            btnAddOrderDetail.TabIndex = 14;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // nudDiscountRatio
            // 
            nudDiscountRatio.Location = new Point(640, 130);
            nudDiscountRatio.Margin = new Padding(3, 2, 3, 2);
            nudDiscountRatio.Name = "nudDiscountRatio";
            nudDiscountRatio.Size = new Size(132, 23);
            nudDiscountRatio.TabIndex = 12;
            nudDiscountRatio.ThousandsSeparator = true;
            // 
            // lblDiscountRatio
            // 
            lblDiscountRatio.AutoSize = true;
            lblDiscountRatio.Location = new Point(640, 113);
            lblDiscountRatio.Name = "lblDiscountRatio";
            lblDiscountRatio.Size = new Size(78, 15);
            lblDiscountRatio.TabIndex = 9;
            lblDiscountRatio.Text = "İskonto Oranı";
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Location = new Point(503, 130);
            nudTaxRatio.Margin = new Padding(3, 2, 3, 2);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(132, 23);
            nudTaxRatio.TabIndex = 9;
            nudTaxRatio.ThousandsSeparator = true;
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(503, 113);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(65, 15);
            lblTaxRatio.TabIndex = 9;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 3;
            nudQuantity.Location = new Point(503, 86);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(132, 23);
            nudQuantity.TabIndex = 8;
            nudQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(503, 69);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(41, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(640, 86);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(132, 23);
            nudPrice.TabIndex = 11;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(640, 69);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(640, 43);
            nudCost.Margin = new Padding(3, 2, 3, 2);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(132, 23);
            nudCost.TabIndex = 10;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(640, 26);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(46, 15);
            lblCost.TabIndex = 5;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(503, 43);
            cbUnitCode.Margin = new Padding(3, 2, 3, 2);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(133, 23);
            cbUnitCode.TabIndex = 7;
            cbUnitCode.SelectedIndexChanged += cbUnitCode_SelectedIndexChanged;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(503, 26);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(66, 15);
            lblUnitCode.TabIndex = 3;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(5, 158);
            txtSearchProduct.Margin = new Padding(3, 2, 3, 2);
            txtSearchProduct.MaxLength = 200;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(491, 23);
            txtSearchProduct.TabIndex = 6;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(5, 26);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(46, 15);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Ürünler";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.AllowColumnReorder = true;
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmUnitCost, clmUnitPrice, clmDiscountRatio, clmTaxRatio, clmQuantity, clmProductUnitCode, clmProducedQuantity, clmRemainingQuantity, clmTotalCost, clmTotalPrice, clmTotalProfit, clmTotalProfitPercentage });
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(5, 20);
            lvOrderDetails.Margin = new Padding(3, 2, 3, 2);
            lvOrderDetails.MultiSelect = false;
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(1072, 156);
            lvOrderDetails.TabIndex = 4;
            lvOrderDetails.UseCompatibleStateImageBehavior = false;
            lvOrderDetails.View = View.Details;
            lvOrderDetails.DoubleClick += lvOrderDetails_DoubleClick;
            // 
            // clmProductName
            // 
            clmProductName.Text = "Ürün Adı";
            // 
            // clmUnitCost
            // 
            clmUnitCost.Text = "Birim Maliyet";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.Text = "Birim Fiyat";
            // 
            // clmDiscountRatio
            // 
            clmDiscountRatio.Text = "İskonto Oranı";
            // 
            // clmTaxRatio
            // 
            clmTaxRatio.Text = "Vergi Oranı";
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Miktar";
            // 
            // clmProductUnitCode
            // 
            clmProductUnitCode.Text = "Birim Kodu";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretilen Miktar";
            // 
            // clmRemainingQuantity
            // 
            clmRemainingQuantity.Text = "Üretilecek Miktar";
            // 
            // clmTotalCost
            // 
            clmTotalCost.Text = "Toplam Maliyet";
            // 
            // clmTotalPrice
            // 
            clmTotalPrice.Text = "Toplam Fiyat";
            // 
            // clmTotalProfit
            // 
            clmTotalProfit.Text = "Toplam Kar";
            // 
            // clmTotalProfitPercentage
            // 
            clmTotalProfitPercentage.Text = "Toplam Kar Oranı";
            // 
            // AddUpdateOrder
            // 
            AcceptButton = btnSaveOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1103, 448);
            Controls.Add(gbOrderDetails);
            Controls.Add(gbOrderHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddUpdateOrder";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Oluştur";
            gbOrderHeader.ResumeLayout(false);
            gbOrderHeader.PerformLayout();
            gbOrderDetails.ResumeLayout(false);
            gbOrderTotals.ResumeLayout(false);
            gbOrderTotals.PerformLayout();
            gbAddProductDetail.ResumeLayout(false);
            gbAddProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTaxRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrderHeader;
        private Label lblJobNo;
        private ComboBox cbCustomers;
        private DateTimePicker dtpDeliveryDate;
        private Label lblDeliveryDate;
        private Label lblCustomer;
        private TextBox txtJobNo;
        private GroupBox gbOrderDetails;
        private ListView lvOrderDetails;
        private ColumnHeader clmProductName;
        private ColumnHeader clmProductUnitCode;
        private ColumnHeader clmUnitCost;
        private ColumnHeader clmUnitPrice;
        private ColumnHeader clmQuantity;
        private ColumnHeader clmProducedQuantity;
        private ColumnHeader clmRemainingQuantity;
        private ColumnHeader clmTotalCost;
        private ColumnHeader clmTotalPrice;
        private ColumnHeader clmTotalProfit;
        private ColumnHeader clmTotalProfitPercentage;
        private GroupBox gbAddProductDetail;
        private TextBox txtSearchProduct;
        private Label lblProducts;
        private Label lblUnitCode;
        private ComboBox cbUnitCode;
        private NumericUpDown nudCost;
        private Label lblCost;
        private NumericUpDown nudPrice;
        private Label lblPrice;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private Button btnAddOrderDetail;
        private DateTimePicker dtpOrderDate;
        private Label lblOrderDate;
        private GroupBox gbOrderTotals;
        private Button btnSaveOrder;
        private Label lvlTotalOrderCost;
        private TextBox txtTotalCost;
        private TextBox txtTotalPrice;
        private Label lvlTotalPrice;
        private TextBox txtTotalQuantity;
        private Label lblTotalQuantity;
        private TextBox txtProfitRatio;
        private Label lblPercentage;
        private TextBox txtProfit;
        private Label lvlProfit;
        private Button btnCancel;
        private Button btnDeleteOrderDetail;
        private ColumnHeader clmTaxRatio;
        private NumericUpDown nudTaxRatio;
        private Label lblTaxRatio;
        private TextBox txtPriceWithTax;
        private Label lblPriceWithTax;
        private ListView lvProducts;
        private ColumnHeader clmProductName0;
        private ColumnHeader clmProductType;
        private ColumnHeader clmLastCost;
        private ColumnHeader clmLastPrice;
        private ColumnHeader clmIsCounting;
        private ColumnHeader clmProductCode;
        private NumericUpDown nudDiscountRatio;
        private Label lblDiscountRatio;
        private ColumnHeader clmDiscountRatio;
    }
}