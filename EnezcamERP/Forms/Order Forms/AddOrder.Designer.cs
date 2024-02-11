namespace EnezcamERP.Forms.Order_Forms
{
    partial class AddOrder
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
            txtProfitPercentage = new TextBox();
            lblPercentage = new Label();
            txtProfit = new TextBox();
            lvlProfit = new Label();
            txtTotalQuantity = new TextBox();
            lblTotalQuantity = new Label();
            txtTotalPrice = new TextBox();
            lvlTotalPrice = new Label();
            txtTotalCost = new TextBox();
            lvlTotalOrderCost = new Label();
            btnSaveOrder = new Button();
            gbAddProductDetail = new GroupBox();
            btnAddOrderDetail = new Button();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            nudPrice = new NumericUpDown();
            lblPrice = new Label();
            nudCost = new NumericUpDown();
            lblCost = new Label();
            cbUnitCode = new ComboBox();
            lblUnitCode = new Label();
            txtSearchProduct = new TextBox();
            lbProducts = new ListBox();
            lblProducts = new Label();
            lvOrderDetails = new ListView();
            clmProductName = new ColumnHeader();
            clmUnitCost = new ColumnHeader();
            clmUnitPrice = new ColumnHeader();
            clmProductUnitCode = new ColumnHeader();
            clmQuantity = new ColumnHeader();
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
            cbCustomers.Location = new Point(320, 26);
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
            lblOrderDate.Size = new Size(71, 15);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "Teslim Tarihi";
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
            gbOrderTotals.Controls.Add(txtProfitPercentage);
            gbOrderTotals.Controls.Add(lblPercentage);
            gbOrderTotals.Controls.Add(txtProfit);
            gbOrderTotals.Controls.Add(lvlProfit);
            gbOrderTotals.Controls.Add(txtTotalQuantity);
            gbOrderTotals.Controls.Add(lblTotalQuantity);
            gbOrderTotals.Controls.Add(txtTotalPrice);
            gbOrderTotals.Controls.Add(lvlTotalPrice);
            gbOrderTotals.Controls.Add(txtTotalCost);
            gbOrderTotals.Controls.Add(lvlTotalOrderCost);
            gbOrderTotals.Controls.Add(btnSaveOrder);
            gbOrderTotals.Location = new Point(436, 179);
            gbOrderTotals.Margin = new Padding(3, 2, 3, 2);
            gbOrderTotals.Name = "gbOrderTotals";
            gbOrderTotals.Padding = new Padding(3, 2, 3, 2);
            gbOrderTotals.Size = new Size(641, 183);
            gbOrderTotals.TabIndex = 2;
            gbOrderTotals.TabStop = false;
            gbOrderTotals.Text = "Sipariş Toplamları";
            // 
            // txtProfitPercentage
            // 
            txtProfitPercentage.Location = new Point(144, 86);
            txtProfitPercentage.Margin = new Padding(3, 2, 3, 2);
            txtProfitPercentage.MaxLength = 200;
            txtProfitPercentage.Name = "txtProfitPercentage";
            txtProfitPercentage.ReadOnly = true;
            txtProfitPercentage.Size = new Size(133, 23);
            txtProfitPercentage.TabIndex = 16;
            txtProfitPercentage.TabStop = false;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(144, 69);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(56, 15);
            lblPercentage.TabIndex = 15;
            lblPercentage.Text = "Kar Oranı";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(144, 43);
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
            lvlProfit.Location = new Point(143, 26);
            lvlProfit.Name = "lvlProfit";
            lvlProfit.Size = new Size(24, 15);
            lvlProfit.TabIndex = 13;
            lvlProfit.Text = "Kar";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(6, 129);
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
            lblTotalQuantity.Location = new Point(7, 112);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(74, 15);
            lblTotalQuantity.TabIndex = 5;
            lblTotalQuantity.Text = "Toplam Adet";
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
            txtTotalCost.Location = new Point(5, 43);
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
            lvlTotalOrderCost.Location = new Point(6, 26);
            lvlTotalOrderCost.Name = "lvlTotalOrderCost";
            lvlTotalOrderCost.Size = new Size(46, 15);
            lvlTotalOrderCost.TabIndex = 1;
            lvlTotalOrderCost.Text = "Maliyet";
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(554, 157);
            btnSaveOrder.Margin = new Padding(3, 2, 3, 2);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(82, 22);
            btnSaveOrder.TabIndex = 12;
            btnSaveOrder.Text = "Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // gbAddProductDetail
            // 
            gbAddProductDetail.Controls.Add(btnAddOrderDetail);
            gbAddProductDetail.Controls.Add(nudQuantity);
            gbAddProductDetail.Controls.Add(lblQuantity);
            gbAddProductDetail.Controls.Add(nudPrice);
            gbAddProductDetail.Controls.Add(lblPrice);
            gbAddProductDetail.Controls.Add(nudCost);
            gbAddProductDetail.Controls.Add(lblCost);
            gbAddProductDetail.Controls.Add(cbUnitCode);
            gbAddProductDetail.Controls.Add(lblUnitCode);
            gbAddProductDetail.Controls.Add(txtSearchProduct);
            gbAddProductDetail.Controls.Add(lbProducts);
            gbAddProductDetail.Controls.Add(lblProducts);
            gbAddProductDetail.Location = new Point(5, 179);
            gbAddProductDetail.Margin = new Padding(3, 2, 3, 2);
            gbAddProductDetail.Name = "gbAddProductDetail";
            gbAddProductDetail.Padding = new Padding(3, 2, 3, 2);
            gbAddProductDetail.Size = new Size(425, 183);
            gbAddProductDetail.TabIndex = 1;
            gbAddProductDetail.TabStop = false;
            gbAddProductDetail.Text = "Ürün Ekle";
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Location = new Point(279, 154);
            btnAddOrderDetail.Margin = new Padding(3, 2, 3, 2);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(132, 22);
            btnAddOrderDetail.TabIndex = 11;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Location = new Point(142, 86);
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
            lblQuantity.Location = new Point(142, 69);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(32, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Adet";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(279, 86);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(132, 23);
            nudPrice.TabIndex = 10;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(279, 69);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(279, 43);
            nudCost.Margin = new Padding(3, 2, 3, 2);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(132, 23);
            nudCost.TabIndex = 9;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(279, 26);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(46, 15);
            lblCost.TabIndex = 5;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(142, 43);
            cbUnitCode.Margin = new Padding(3, 2, 3, 2);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(133, 23);
            cbUnitCode.TabIndex = 7;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(142, 26);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(66, 15);
            lblUnitCode.TabIndex = 3;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(5, 155);
            txtSearchProduct.Margin = new Padding(3, 2, 3, 2);
            txtSearchProduct.MaxLength = 200;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(132, 23);
            txtSearchProduct.TabIndex = 6;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lbProducts
            // 
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 15;
            lbProducts.Location = new Point(5, 43);
            lbProducts.Margin = new Padding(3, 2, 3, 2);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(132, 109);
            lbProducts.TabIndex = 5;
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
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmUnitCost, clmUnitPrice, clmProductUnitCode, clmQuantity, clmProducedQuantity, clmRemainingQuantity, clmTotalCost, clmTotalPrice, clmTotalProfit, clmTotalProfitPercentage });
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
            // 
            // clmProductName
            // 
            clmProductName.Text = "Ürün Adı";
            // 
            // clmUnitCost
            // 
            clmUnitCost.DisplayIndex = 2;
            clmUnitCost.Text = "Birim Maliyet";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.DisplayIndex = 3;
            clmUnitPrice.Text = "Birim Fiyat";
            // 
            // clmProductUnitCode
            // 
            clmProductUnitCode.DisplayIndex = 1;
            clmProductUnitCode.Text = "Birim Kodu";
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Miktar";
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
            // AddOrder
            // 
            AcceptButton = btnSaveOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 448);
            Controls.Add(gbOrderDetails);
            Controls.Add(gbOrderHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddOrder";
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
        private ListBox lbProducts;
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
        private TextBox txtProfitPercentage;
        private Label lblPercentage;
        private TextBox txtProfit;
        private Label lvlProfit;
    }
}