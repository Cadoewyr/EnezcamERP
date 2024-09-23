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
            components = new System.ComponentModel.Container();
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
            btnColumnSettings = new Button();
            btnUpdateOrderDetailsSpecs = new Button();
            btnUpdateLastCostPrice = new Button();
            lblSearchOrderDetail = new Label();
            txtSearchOrderDetail = new TextBox();
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
            cmsAddUpdate = new ContextMenuStrip(components);
            checkAllToolStripMenuItem = new ToolStripMenuItem();
            checkSameProductsToolStripMenuItem = new ToolStripMenuItem();
            uncheckAllToolStripMenuItem = new ToolStripMenuItem();
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
            cmsAddUpdate.SuspendLayout();
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
            gbOrderHeader.Location = new Point(11, 12);
            gbOrderHeader.Name = "gbOrderHeader";
            gbOrderHeader.Size = new Size(1404, 77);
            gbOrderHeader.TabIndex = 0;
            gbOrderHeader.TabStop = false;
            gbOrderHeader.Text = "Sipariş Bilgileri";
            // 
            // txtJobNo
            // 
            txtJobNo.Location = new Point(89, 35);
            txtJobNo.MaxLength = 200;
            txtJobNo.Name = "txtJobNo";
            txtJobNo.Size = new Size(207, 27);
            txtJobNo.TabIndex = 0;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(697, 33);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(207, 27);
            dtpOrderDate.TabIndex = 2;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new Point(1024, 33);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(207, 27);
            dtpDeliveryDate.TabIndex = 3;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(367, 33);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(207, 28);
            cbCustomers.TabIndex = 1;
            cbCustomers.Leave += cbCustomers_Leave;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(601, 37);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(92, 20);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "Sipariş Tarihi";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(928, 37);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(90, 20);
            lblDeliveryDate.TabIndex = 0;
            lblDeliveryDate.Text = "Teslim Tarihi";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(325, 37);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(35, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Cari";
            // 
            // lblJobNo
            // 
            lblJobNo.AutoSize = true;
            lblJobNo.Location = new Point(6, 37);
            lblJobNo.Name = "lblJobNo";
            lblJobNo.Size = new Size(77, 20);
            lblJobNo.TabIndex = 0;
            lblJobNo.Text = "Sipariş No";
            // 
            // gbOrderDetails
            // 
            gbOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrderDetails.Controls.Add(btnColumnSettings);
            gbOrderDetails.Controls.Add(btnUpdateOrderDetailsSpecs);
            gbOrderDetails.Controls.Add(btnUpdateLastCostPrice);
            gbOrderDetails.Controls.Add(lblSearchOrderDetail);
            gbOrderDetails.Controls.Add(txtSearchOrderDetail);
            gbOrderDetails.Controls.Add(gbOrderTotals);
            gbOrderDetails.Controls.Add(gbAddProductDetail);
            gbOrderDetails.Controls.Add(lvOrderDetails);
            gbOrderDetails.Location = new Point(11, 96);
            gbOrderDetails.Name = "gbOrderDetails";
            gbOrderDetails.Size = new Size(1404, 813);
            gbOrderDetails.TabIndex = 1;
            gbOrderDetails.TabStop = false;
            gbOrderDetails.Text = "Sipariş Detayı";
            // 
            // btnColumnSettings
            // 
            btnColumnSettings.Location = new Point(422, 24);
            btnColumnSettings.Name = "btnColumnSettings";
            btnColumnSettings.Size = new Size(111, 29);
            btnColumnSettings.TabIndex = 8;
            btnColumnSettings.TabStop = false;
            btnColumnSettings.Text = "Sütun Ayarları";
            btnColumnSettings.UseVisualStyleBackColor = true;
            btnColumnSettings.Click += btnColumnSettings_Click;
            // 
            // btnUpdateOrderDetailsSpecs
            // 
            btnUpdateOrderDetailsSpecs.Location = new Point(206, 24);
            btnUpdateOrderDetailsSpecs.Name = "btnUpdateOrderDetailsSpecs";
            btnUpdateOrderDetailsSpecs.Size = new Size(210, 29);
            btnUpdateOrderDetailsSpecs.TabIndex = 7;
            btnUpdateOrderDetailsSpecs.TabStop = false;
            btnUpdateOrderDetailsSpecs.Text = "Toplu Ürün Özelliği Güncelle";
            btnUpdateOrderDetailsSpecs.UseVisualStyleBackColor = true;
            btnUpdateOrderDetailsSpecs.Click += btnUpdate_Click;
            // 
            // btnUpdateLastCostPrice
            // 
            btnUpdateLastCostPrice.Location = new Point(7, 24);
            btnUpdateLastCostPrice.Name = "btnUpdateLastCostPrice";
            btnUpdateLastCostPrice.Size = new Size(193, 29);
            btnUpdateLastCostPrice.TabIndex = 7;
            btnUpdateLastCostPrice.TabStop = false;
            btnUpdateLastCostPrice.Text = "Maliyet ve Fiyat Güncelle";
            btnUpdateLastCostPrice.UseVisualStyleBackColor = true;
            btnUpdateLastCostPrice.Click += btnUpdateLastCostPrice_Click;
            // 
            // lblSearchOrderDetail
            // 
            lblSearchOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchOrderDetail.AutoSize = true;
            lblSearchOrderDetail.Location = new Point(1052, 29);
            lblSearchOrderDetail.Name = "lblSearchOrderDetail";
            lblSearchOrderDetail.Size = new Size(32, 20);
            lblSearchOrderDetail.TabIndex = 6;
            lblSearchOrderDetail.Text = "Ara";
            // 
            // txtSearchOrderDetail
            // 
            txtSearchOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchOrderDetail.Location = new Point(1090, 26);
            txtSearchOrderDetail.Name = "txtSearchOrderDetail";
            txtSearchOrderDetail.Size = new Size(306, 27);
            txtSearchOrderDetail.TabIndex = 5;
            txtSearchOrderDetail.TextChanged += txtSearchOrderDetail_TextChanged;
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
            gbOrderTotals.Location = new Point(1066, 416);
            gbOrderTotals.Name = "gbOrderTotals";
            gbOrderTotals.Size = new Size(330, 391);
            gbOrderTotals.TabIndex = 2;
            gbOrderTotals.TabStop = false;
            gbOrderTotals.Text = "Sipariş Toplamları";
            // 
            // txtProducedQuantity
            // 
            txtProducedQuantity.Location = new Point(6, 235);
            txtProducedQuantity.MaxLength = 200;
            txtProducedQuantity.Name = "txtProducedQuantity";
            txtProducedQuantity.ReadOnly = true;
            txtProducedQuantity.Size = new Size(151, 27);
            txtProducedQuantity.TabIndex = 18;
            txtProducedQuantity.TabStop = false;
            // 
            // lblProducedQuantity
            // 
            lblProducedQuantity.AutoSize = true;
            lblProducedQuantity.Location = new Point(6, 212);
            lblProducedQuantity.Name = "lblProducedQuantity";
            lblProducedQuantity.Size = new Size(54, 20);
            lblProducedQuantity.TabIndex = 17;
            lblProducedQuantity.Text = "Üretim";
            // 
            // txtPriceWithTax
            // 
            txtPriceWithTax.Location = new Point(6, 173);
            txtPriceWithTax.MaxLength = 200;
            txtPriceWithTax.Name = "txtPriceWithTax";
            txtPriceWithTax.ReadOnly = true;
            txtPriceWithTax.Size = new Size(151, 27);
            txtPriceWithTax.TabIndex = 18;
            txtPriceWithTax.TabStop = false;
            // 
            // lblPriceWithTax
            // 
            lblPriceWithTax.AutoSize = true;
            lblPriceWithTax.Location = new Point(6, 151);
            lblPriceWithTax.Name = "lblPriceWithTax";
            lblPriceWithTax.Size = new Size(117, 20);
            lblPriceWithTax.TabIndex = 17;
            lblPriceWithTax.Text = "Vergi Dahil Fiyat";
            // 
            // txtProfitRatio
            // 
            txtProfitRatio.Location = new Point(163, 115);
            txtProfitRatio.MaxLength = 200;
            txtProfitRatio.Name = "txtProfitRatio";
            txtProfitRatio.ReadOnly = true;
            txtProfitRatio.Size = new Size(151, 27);
            txtProfitRatio.TabIndex = 16;
            txtProfitRatio.TabStop = false;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(163, 92);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(71, 20);
            lblPercentage.TabIndex = 15;
            lblPercentage.Text = "Kar Oranı";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(163, 59);
            txtProfit.MaxLength = 200;
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(151, 27);
            txtProfit.TabIndex = 14;
            txtProfit.TabStop = false;
            // 
            // txtRemainingQuantity
            // 
            txtRemainingQuantity.Location = new Point(163, 235);
            txtRemainingQuantity.MaxLength = 200;
            txtRemainingQuantity.Name = "txtRemainingQuantity";
            txtRemainingQuantity.ReadOnly = true;
            txtRemainingQuantity.Size = new Size(151, 27);
            txtRemainingQuantity.TabIndex = 6;
            txtRemainingQuantity.TabStop = false;
            // 
            // lvlProfit
            // 
            lvlProfit.AutoSize = true;
            lvlProfit.Location = new Point(163, 35);
            lvlProfit.Name = "lvlProfit";
            lvlProfit.Size = new Size(31, 20);
            lvlProfit.TabIndex = 13;
            lvlProfit.Text = "Kar";
            // 
            // lblRemainingQuantity
            // 
            lblRemainingQuantity.AutoSize = true;
            lblRemainingQuantity.Location = new Point(163, 212);
            lblRemainingQuantity.Name = "lblRemainingQuantity";
            lblRemainingQuantity.Size = new Size(92, 20);
            lblRemainingQuantity.TabIndex = 5;
            lblRemainingQuantity.Text = "Kalan Miktar";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(163, 173);
            txtTotalQuantity.MaxLength = 200;
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new Size(151, 27);
            txtTotalQuantity.TabIndex = 6;
            txtTotalQuantity.TabStop = false;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(163, 151);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(105, 20);
            lblTotalQuantity.TabIndex = 5;
            lblTotalQuantity.Text = "Toplam Miktar";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(6, 115);
            txtTotalPrice.MaxLength = 200;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(151, 27);
            txtTotalPrice.TabIndex = 4;
            txtTotalPrice.TabStop = false;
            // 
            // lvlTotalPrice
            // 
            lvlTotalPrice.AutoSize = true;
            lvlTotalPrice.Location = new Point(6, 92);
            lvlTotalPrice.Name = "lvlTotalPrice";
            lvlTotalPrice.Size = new Size(40, 20);
            lvlTotalPrice.TabIndex = 3;
            lvlTotalPrice.Text = "Fiyat";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(6, 59);
            txtTotalCost.MaxLength = 200;
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(151, 27);
            txtTotalCost.TabIndex = 2;
            txtTotalCost.TabStop = false;
            // 
            // lvlTotalOrderCost
            // 
            lvlTotalOrderCost.AutoSize = true;
            lvlTotalOrderCost.Location = new Point(6, 35);
            lvlTotalOrderCost.Name = "lvlTotalOrderCost";
            lvlTotalOrderCost.Size = new Size(58, 20);
            lvlTotalOrderCost.TabIndex = 1;
            lvlTotalOrderCost.Text = "Maliyet";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelOrder_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(163, 267);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(151, 29);
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
            gbAddProductDetail.Location = new Point(7, 416);
            gbAddProductDetail.Name = "gbAddProductDetail";
            gbAddProductDetail.Size = new Size(1054, 391);
            gbAddProductDetail.TabIndex = 1;
            gbAddProductDetail.TabStop = false;
            gbAddProductDetail.Text = "Ürün Ekle";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(6, 269);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(32, 20);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Ara";
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmProductCode, clmProductName0, clmProductType, clmLastCost, clmLastPrice, clmIsCounting });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(6, 57);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(1037, 205);
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
            btnDeleteOrderDetail.Location = new Point(777, 356);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(130, 29);
            btnDeleteOrderDetail.TabIndex = 15;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrderDetail.Location = new Point(913, 356);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(130, 29);
            btnAddOrderDetail.TabIndex = 16;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // nudHeight
            // 
            nudHeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudHeight.Location = new Point(777, 322);
            nudHeight.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(130, 27);
            nudHeight.TabIndex = 13;
            nudHeight.ThousandsSeparator = true;
            nudHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Enter += NumericUpDownEnterFocus;
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(777, 300);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(68, 20);
            lblHeight.TabIndex = 9;
            lblHeight.Text = "Yükseklik";
            // 
            // nudDiscountRatio
            // 
            nudDiscountRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudDiscountRatio.Location = new Point(505, 322);
            nudDiscountRatio.Name = "nudDiscountRatio";
            nudDiscountRatio.Size = new Size(130, 27);
            nudDiscountRatio.TabIndex = 11;
            nudDiscountRatio.ThousandsSeparator = true;
            // 
            // nudWidth
            // 
            nudWidth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudWidth.Location = new Point(641, 322);
            nudWidth.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(130, 27);
            nudWidth.TabIndex = 12;
            nudWidth.ThousandsSeparator = true;
            nudWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Enter += NumericUpDownEnterFocus;
            // 
            // lblDiscountRatio
            // 
            lblDiscountRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscountRatio.AutoSize = true;
            lblDiscountRatio.Location = new Point(505, 300);
            lblDiscountRatio.Name = "lblDiscountRatio";
            lblDiscountRatio.Size = new Size(97, 20);
            lblDiscountRatio.TabIndex = 9;
            lblDiscountRatio.Text = "İskonto Oranı";
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(641, 300);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(60, 20);
            lblWidth.TabIndex = 9;
            lblWidth.Text = "Genişlik";
            // 
            // nudTaxRatio
            // 
            nudTaxRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudTaxRatio.Location = new Point(371, 322);
            nudTaxRatio.Name = "nudTaxRatio";
            nudTaxRatio.Size = new Size(130, 27);
            nudTaxRatio.TabIndex = 10;
            nudTaxRatio.ThousandsSeparator = true;
            nudTaxRatio.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblTaxRatio
            // 
            lblTaxRatio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTaxRatio.AutoSize = true;
            lblTaxRatio.Location = new Point(371, 300);
            lblTaxRatio.Name = "lblTaxRatio";
            lblTaxRatio.Size = new Size(83, 20);
            lblTaxRatio.TabIndex = 9;
            lblTaxRatio.Text = "Vergi Oranı";
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudQuantity.Location = new Point(913, 322);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(130, 27);
            nudQuantity.TabIndex = 14;
            nudQuantity.ThousandsSeparator = true;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Enter += NumericUpDownEnterFocus;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(913, 300);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(235, 322);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(130, 27);
            nudPrice.TabIndex = 9;
            nudPrice.ThousandsSeparator = true;
            nudPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(235, 300);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(99, 322);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(130, 27);
            nudCost.TabIndex = 8;
            nudCost.ThousandsSeparator = true;
            nudCost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCost.AutoSize = true;
            lblCost.Location = new Point(99, 300);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(58, 20);
            lblCost.TabIndex = 5;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(9, 321);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(83, 28);
            cbUnitCode.TabIndex = 7;
            // 
            // lblUnitCode
            // 
            lblUnitCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(9, 300);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(83, 20);
            lblUnitCode.TabIndex = 3;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchProduct.Location = new Point(43, 268);
            txtSearchProduct.MaxLength = 200;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(1000, 27);
            txtSearchProduct.TabIndex = 6;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lblProducts
            // 
            lblProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(6, 33);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(57, 20);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Ürünler";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.AllowColumnReorder = true;
            lvOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrderDetails.CheckBoxes = true;
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductCode1, clmProductName1, clmSize, clmUnitArea, clmTotalArea, clmQuantity, clmProductUnitCode, clmUnitCost, clmUnitPrice, clmTaxRatio, clmProducedQuantity, clmRemainingQuantity, clmTotalCost, clmTotalPrice, clmTotalProfit, clmTotalProfitPercentage });
            lvOrderDetails.ContextMenuStrip = cmsAddUpdate;
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(7, 59);
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(1389, 351);
            lvOrderDetails.TabIndex = 4;
            lvOrderDetails.UseCompatibleStateImageBehavior = false;
            lvOrderDetails.View = View.Details;
            lvOrderDetails.ItemChecked += lvOrderDetails_SelectedIndexAndCheckedChanged;
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
            // cmsAddUpdate
            // 
            cmsAddUpdate.ImageScalingSize = new Size(20, 20);
            cmsAddUpdate.Items.AddRange(new ToolStripItem[] { checkAllToolStripMenuItem, checkSameProductsToolStripMenuItem, uncheckAllToolStripMenuItem });
            cmsAddUpdate.Name = "cmsAddUpdate";
            cmsAddUpdate.Size = new Size(191, 76);
            // 
            // checkAllToolStripMenuItem
            // 
            checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            checkAllToolStripMenuItem.Size = new Size(190, 24);
            checkAllToolStripMenuItem.Text = "Tümünü Seç";
            checkAllToolStripMenuItem.Click += checkAllToolStripMenuItem_Click;
            // 
            // checkSameProductsToolStripMenuItem
            // 
            checkSameProductsToolStripMenuItem.Name = "checkSameProductsToolStripMenuItem";
            checkSameProductsToolStripMenuItem.Size = new Size(190, 24);
            checkSameProductsToolStripMenuItem.Text = "Aynı Ürünleri Seç";
            checkSameProductsToolStripMenuItem.Click += checkSameProductsToolStripMenuItem_Click;
            // 
            // uncheckAllToolStripMenuItem
            // 
            uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            uncheckAllToolStripMenuItem.Size = new Size(190, 24);
            uncheckAllToolStripMenuItem.Text = "Seçimleri Kaldır";
            uncheckAllToolStripMenuItem.Click += uncheckAllToolStripMenuItem_Click;
            // 
            // AddUpdateOrder
            // 
            AcceptButton = btnAddOrderDetail;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1430, 921);
            Controls.Add(gbOrderDetails);
            Controls.Add(gbOrderHeader);
            MinimumSize = new Size(1448, 968);
            Name = "AddUpdateOrder";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Oluştur";
            gbOrderHeader.ResumeLayout(false);
            gbOrderHeader.PerformLayout();
            gbOrderDetails.ResumeLayout(false);
            gbOrderDetails.PerformLayout();
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
            cmsAddUpdate.ResumeLayout(false);
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
        private ContextMenuStrip cmsAddUpdate;
        private ToolStripMenuItem checkAllToolStripMenuItem;
        private ToolStripMenuItem checkSameProductsToolStripMenuItem;
        private ToolStripMenuItem uncheckAllToolStripMenuItem;
        private Label lblSearchOrderDetail;
        private TextBox txtSearchOrderDetail;
        private Button btnUpdateLastCostPrice;
        private Button btnUpdateOrderDetailsSpecs;
        private Button btnColumnSettings;
    }
}