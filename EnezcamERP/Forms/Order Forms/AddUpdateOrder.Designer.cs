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
            txtProducedQuantity = new TextBox();
            lblProducedQuantity = new Label();
            txtPriceWithTax = new TextBox();
            lblPriceWithTax = new Label();
            txtProfitRatio = new TextBox();
            lblPercentage = new Label();
            txtProfit = new TextBox();
            txtRemainingQuantity = new TextBox();
            lvlProfit = new Label();
            lblRemainingQuantity = new Label();
            txtTotalQuantity = new TextBox();
            lblTotalQuantity = new Label();
            txtTotalPrice = new TextBox();
            lvlTotalPrice = new Label();
            txtTotalCost = new TextBox();
            lvlTotalOrderCost = new Label();
            btnCancel = new Button();
            btnSaveOrder = new Button();
            gbAddProductDetail = new GroupBox();
            lblSearch = new Label();
            lvProducts = new ListView();
            clmProductCode = new ColumnHeader();
            clmProductName0 = new ColumnHeader();
            clmProductType = new ColumnHeader();
            clmLastCost = new ColumnHeader();
            clmLastPrice = new ColumnHeader();
            clmIsCounting = new ColumnHeader();
            btnDeleteOrderDetail = new Button();
            btnAddOrderDetail = new Button();
            nudHeight = new NumericUpDown();
            lblHeight = new Label();
            nudDiscountRatio = new NumericUpDown();
            nudWidth = new NumericUpDown();
            lblDiscountRatio = new Label();
            lblWidth = new Label();
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
            clmProductCode1 = new ColumnHeader();
            clmProductName1 = new ColumnHeader();
            clmSize = new ColumnHeader();
            clmUnitArea = new ColumnHeader();
            clmTotalArea = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmProductUnitCode = new ColumnHeader();
            clmUnitCost = new ColumnHeader();
            clmUnitPrice = new ColumnHeader();
            clmTaxRatio = new ColumnHeader();
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
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTaxRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            SuspendLayout();
            // 
            // gbOrderHeader
            // 
            gbOrderHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            gbOrderHeader.Size = new Size(1223, 58);
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
            cbCustomers.Leave += cbCustomers_Leave;
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
            gbOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrderDetails.Controls.Add(gbOrderTotals);
            gbOrderDetails.Controls.Add(gbAddProductDetail);
            gbOrderDetails.Controls.Add(lvOrderDetails);
            gbOrderDetails.Location = new Point(10, 72);
            gbOrderDetails.Margin = new Padding(3, 2, 3, 2);
            gbOrderDetails.Name = "gbOrderDetails";
            gbOrderDetails.Padding = new Padding(3, 2, 3, 2);
            gbOrderDetails.Size = new Size(1223, 481);
            gbOrderDetails.TabIndex = 1;
            gbOrderDetails.TabStop = false;
            gbOrderDetails.Text = "Sipariş Detayı";
            // 
            // gbOrderTotals
            // 
            gbOrderTotals.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gbOrderTotals.Controls.Add(txtProducedQuantity);
            gbOrderTotals.Controls.Add(lblProducedQuantity);
            gbOrderTotals.Controls.Add(txtPriceWithTax);
            gbOrderTotals.Controls.Add(lblPriceWithTax);
            gbOrderTotals.Controls.Add(txtProfitRatio);
            gbOrderTotals.Controls.Add(lblPercentage);
            gbOrderTotals.Controls.Add(txtProfit);
            gbOrderTotals.Controls.Add(txtRemainingQuantity);
            gbOrderTotals.Controls.Add(lvlProfit);
            gbOrderTotals.Controls.Add(lblRemainingQuantity);
            gbOrderTotals.Controls.Add(txtTotalQuantity);
            gbOrderTotals.Controls.Add(lblTotalQuantity);
            gbOrderTotals.Controls.Add(txtTotalPrice);
            gbOrderTotals.Controls.Add(lvlTotalPrice);
            gbOrderTotals.Controls.Add(txtTotalCost);
            gbOrderTotals.Controls.Add(lvlTotalOrderCost);
            gbOrderTotals.Controls.Add(btnCancel);
            gbOrderTotals.Controls.Add(btnSaveOrder);
            gbOrderTotals.Location = new Point(928, 241);
            gbOrderTotals.Margin = new Padding(3, 2, 3, 2);
            gbOrderTotals.Name = "gbOrderTotals";
            gbOrderTotals.Padding = new Padding(3, 2, 3, 2);
            gbOrderTotals.Size = new Size(289, 232);
            gbOrderTotals.TabIndex = 2;
            gbOrderTotals.TabStop = false;
            gbOrderTotals.Text = "Sipariş Toplamları";
            // 
            // txtProducedQuantity
            // 
            txtProducedQuantity.Location = new Point(5, 176);
            txtProducedQuantity.Margin = new Padding(3, 2, 3, 2);
            txtProducedQuantity.MaxLength = 200;
            txtProducedQuantity.Name = "txtProducedQuantity";
            txtProducedQuantity.ReadOnly = true;
            txtProducedQuantity.Size = new Size(133, 23);
            txtProducedQuantity.TabIndex = 18;
            txtProducedQuantity.TabStop = false;
            // 
            // lblProducedQuantity
            // 
            lblProducedQuantity.AutoSize = true;
            lblProducedQuantity.Location = new Point(5, 159);
            lblProducedQuantity.Name = "lblProducedQuantity";
            lblProducedQuantity.Size = new Size(43, 15);
            lblProducedQuantity.TabIndex = 17;
            lblProducedQuantity.Text = "Üretim";
            // 
            // txtPriceWithTax
            // 
            txtPriceWithTax.Location = new Point(5, 130);
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
            lblPriceWithTax.Location = new Point(5, 113);
            lblPriceWithTax.Name = "lblPriceWithTax";
            lblPriceWithTax.Size = new Size(91, 15);
            lblPriceWithTax.TabIndex = 17;
            lblPriceWithTax.Text = "Vergi Dahil Fiyat";
            // 
            // txtProfitRatio
            // 
            txtProfitRatio.Location = new Point(143, 86);
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
            lblPercentage.Location = new Point(143, 69);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(56, 15);
            lblPercentage.TabIndex = 15;
            lblPercentage.Text = "Kar Oranı";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(143, 44);
            txtProfit.Margin = new Padding(3, 2, 3, 2);
            txtProfit.MaxLength = 200;
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(133, 23);
            txtProfit.TabIndex = 14;
            txtProfit.TabStop = false;
            // 
            // txtRemainingQuantity
            // 
            txtRemainingQuantity.Location = new Point(143, 176);
            txtRemainingQuantity.Margin = new Padding(3, 2, 3, 2);
            txtRemainingQuantity.MaxLength = 200;
            txtRemainingQuantity.Name = "txtRemainingQuantity";
            txtRemainingQuantity.ReadOnly = true;
            txtRemainingQuantity.Size = new Size(133, 23);
            txtRemainingQuantity.TabIndex = 6;
            txtRemainingQuantity.TabStop = false;
            // 
            // lvlProfit
            // 
            lvlProfit.AutoSize = true;
            lvlProfit.Location = new Point(143, 26);
            lvlProfit.Name = "lvlProfit";
            lvlProfit.Size = new Size(24, 15);
            lvlProfit.TabIndex = 13;
            lvlProfit.Text = "Kar";
            // 
            // lblRemainingQuantity
            // 
            lblRemainingQuantity.AutoSize = true;
            lblRemainingQuantity.Location = new Point(143, 159);
            lblRemainingQuantity.Name = "lblRemainingQuantity";
            lblRemainingQuantity.Size = new Size(73, 15);
            lblRemainingQuantity.TabIndex = 5;
            lblRemainingQuantity.Text = "Kalan Miktar";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(143, 130);
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
            lblTotalQuantity.Location = new Point(143, 113);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(83, 15);
            lblTotalQuantity.TabIndex = 5;
            lblTotalQuantity.Text = "Toplam Miktar";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(5, 86);
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
            lvlTotalPrice.Location = new Point(5, 69);
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
            lvlTotalOrderCost.Location = new Point(5, 26);
            lvlTotalOrderCost.Name = "lvlTotalOrderCost";
            lvlTotalOrderCost.Size = new Size(46, 15);
            lvlTotalOrderCost.TabIndex = 1;
            lvlTotalOrderCost.Text = "Maliyet";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(5, 200);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 22);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelOrder_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(143, 200);
            btnSaveOrder.Margin = new Padding(3, 2, 3, 2);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(132, 22);
            btnSaveOrder.TabIndex = 18;
            btnSaveOrder.Text = "Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // gbAddProductDetail
            // 
            gbAddProductDetail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddProductDetail.Controls.Add(lblSearch);
            gbAddProductDetail.Controls.Add(lvProducts);
            gbAddProductDetail.Controls.Add(btnDeleteOrderDetail);
            gbAddProductDetail.Controls.Add(btnAddOrderDetail);
            gbAddProductDetail.Controls.Add(nudHeight);
            gbAddProductDetail.Controls.Add(lblHeight);
            gbAddProductDetail.Controls.Add(nudDiscountRatio);
            gbAddProductDetail.Controls.Add(nudWidth);
            gbAddProductDetail.Controls.Add(lblDiscountRatio);
            gbAddProductDetail.Controls.Add(lblWidth);
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
            gbAddProductDetail.Location = new Point(5, 241);
            gbAddProductDetail.Margin = new Padding(3, 2, 3, 2);
            gbAddProductDetail.Name = "gbAddProductDetail";
            gbAddProductDetail.Padding = new Padding(3, 2, 3, 2);
            gbAddProductDetail.Size = new Size(917, 232);
            gbAddProductDetail.TabIndex = 1;
            gbAddProductDetail.TabStop = false;
            gbAddProductDetail.Text = "Ürün Ekle";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(5, 133);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(25, 15);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Ara";
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductCode, clmProductName0, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(5, 43);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(903, 85);
            lvProducts.TabIndex = 5;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.SelectedIndexChanged += lvProducts_SelectedIndexChanged;
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
            btnDeleteOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteOrderDetail.Location = new Point(675, 200);
            btnDeleteOrderDetail.Margin = new Padding(3, 2, 3, 2);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(114, 22);
            btnDeleteOrderDetail.TabIndex = 15;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrderDetail.Location = new Point(794, 200);
            btnAddOrderDetail.Margin = new Padding(3, 2, 3, 2);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(114, 22);
            btnAddOrderDetail.TabIndex = 16;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // nudHeight
            // 
            nudHeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudHeight.Location = new Point(675, 175);
            nudHeight.Margin = new Padding(3, 2, 3, 2);
            nudHeight.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(114, 23);
            nudHeight.TabIndex = 13;
            nudHeight.ThousandsSeparator = true;
            nudHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(675, 158);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(56, 15);
            lblHeight.TabIndex = 9;
            lblHeight.Text = "Yükseklik";
            // 
            // nudDiscountRatio
            // 
            nudDiscountRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudDiscountRatio.Location = new Point(437, 175);
            nudDiscountRatio.Margin = new Padding(3, 2, 3, 2);
            nudDiscountRatio.Name = "nudDiscountRatio";
            nudDiscountRatio.Size = new Size(114, 23);
            nudDiscountRatio.TabIndex = 11;
            nudDiscountRatio.ThousandsSeparator = true;
            // 
            // nudWidth
            // 
            nudWidth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudWidth.Location = new Point(556, 175);
            nudWidth.Margin = new Padding(3, 2, 3, 2);
            nudWidth.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(114, 23);
            nudWidth.TabIndex = 12;
            nudWidth.ThousandsSeparator = true;
            nudWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDiscountRatio
            // 
            lblDiscountRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscountRatio.AutoSize = true;
            lblDiscountRatio.Location = new Point(437, 158);
            lblDiscountRatio.Name = "lblDiscountRatio";
            lblDiscountRatio.Size = new Size(78, 15);
            lblDiscountRatio.TabIndex = 9;
            lblDiscountRatio.Text = "İskonto Oranı";
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(556, 158);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(48, 15);
            lblWidth.TabIndex = 9;
            lblWidth.Text = "Genişlik";
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudTaxRatio.Location = new Point(319, 175);
            nudTaxRatio.Margin = new Padding(3, 2, 3, 2);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(114, 23);
            nudTaxRatio.TabIndex = 10;
            nudTaxRatio.ThousandsSeparator = true;
            nudTaxRatio.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(319, 158);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(65, 15);
            lblTaxRatio.TabIndex = 9;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudQuantity.Location = new Point(794, 175);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(114, 23);
            nudQuantity.TabIndex = 14;
            nudQuantity.ThousandsSeparator = true;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(794, 158);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(41, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(200, 175);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(114, 23);
            nudPrice.TabIndex = 9;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(200, 158);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(81, 175);
            nudCost.Margin = new Padding(3, 2, 3, 2);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(114, 23);
            nudCost.TabIndex = 8;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCost.AutoSize = true;
            lblCost.Location = new Point(81, 158);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(46, 15);
            lblCost.TabIndex = 5;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(3, 174);
            cbUnitCode.Margin = new Padding(3, 2, 3, 2);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(73, 23);
            cbUnitCode.TabIndex = 7;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(3, 158);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(66, 15);
            lblUnitCode.TabIndex = 3;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchProduct.Location = new Point(38, 132);
            txtSearchProduct.Margin = new Padding(3, 2, 3, 2);
            txtSearchProduct.MaxLength = 200;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(870, 23);
            txtSearchProduct.TabIndex = 6;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lblProducts
            // 
            lblProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(5, 25);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(46, 15);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Ürünler";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.AllowColumnReorder = true;
            lvOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductCode1, clmProductName1, clmSize, clmUnitArea, clmTotalArea, clmQuantity, clmProductUnitCode, clmUnitCost, clmUnitPrice, clmTaxRatio, clmProducedQuantity, clmRemainingQuantity, clmTotalCost, clmTotalPrice, clmTotalProfit, clmTotalProfitPercentage });
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(6, 20);
            lvOrderDetails.Margin = new Padding(3, 2, 3, 2);
            lvOrderDetails.MultiSelect = false;
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(1211, 217);
            lvOrderDetails.TabIndex = 4;
            lvOrderDetails.UseCompatibleStateImageBehavior = false;
            lvOrderDetails.View = View.Details;
            lvOrderDetails.DoubleClick += lvOrderDetails_DoubleClick;
            lvOrderDetails.KeyDown += ListView_KeyDown;
            // 
            // clmProductCode1
            // 
            clmProductCode1.Text = "Ürün Kodu";
            // 
            // clmProductName1
            // 
            clmProductName1.Text = "Ürün Adı";
            // 
            // clmSize
            // 
            clmSize.Text = "Boyut";
            // 
            // clmUnitArea
            // 
            clmUnitArea.Text = "Birim Alan";
            // 
            // clmTotalArea
            // 
            clmTotalArea.Text = "Toplam Alan";
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Miktar";
            // 
            // clmProductUnitCode
            // 
            clmProductUnitCode.Text = "Birim Kodu";
            // 
            // clmUnitCost
            // 
            clmUnitCost.Text = "Birim Maliyet";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.Text = "Birim Fiyat";
            // 
            // clmTaxRatio
            // 
            clmTaxRatio.Text = "Vergi Oranı";
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
            AcceptButton = btnAddOrderDetail;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1246, 564);
            Controls.Add(gbOrderDetails);
            Controls.Add(gbOrderHeader);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1250, 550);
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
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
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
        private ColumnHeader clmProductCode1;
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
        private ColumnHeader clmProductName1;
        private NumericUpDown nudHeight;
        private Label lblHeight;
        private NumericUpDown nudWidth;
        private Label lblWidth;
        private TextBox txtProducedQuantity;
        private Label lblProducedQuantity;
        private TextBox txtRemainingQuantity;
        private Label lblRemainingQuantity;
        private ColumnHeader clmSize;
        private ColumnHeader clmUnitArea;
        private ColumnHeader clmTotalArea;
        private Label lblSearch;
    }
}