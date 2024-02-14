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
            gbOrderTotals = new GroupBox();
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
            btnDeleteOrderDetail = new Button();
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
            cmsOrderDetail = new ContextMenuStrip(components);
            miDelete = new ToolStripMenuItem();
            miEditProducedQuantity = new ToolStripMenuItem();
            gbOrderHeader.SuspendLayout();
            gbOrderDetails.SuspendLayout();
            gbOrderTotals.SuspendLayout();
            gbAddProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            cmsOrderDetail.SuspendLayout();
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
            gbOrderHeader.Location = new Point(11, 12);
            gbOrderHeader.Name = "gbOrderHeader";
            gbOrderHeader.Size = new Size(1237, 77);
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
            cbCustomers.Location = new Point(366, 35);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(207, 28);
            cbCustomers.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(601, 37);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(90, 20);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "Teslim Tarihi";
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
            gbOrderDetails.Controls.Add(gbOrderTotals);
            gbOrderDetails.Controls.Add(gbAddProductDetail);
            gbOrderDetails.Controls.Add(lvOrderDetails);
            gbOrderDetails.Location = new Point(11, 96);
            gbOrderDetails.Name = "gbOrderDetails";
            gbOrderDetails.Size = new Size(1237, 489);
            gbOrderDetails.TabIndex = 1;
            gbOrderDetails.TabStop = false;
            gbOrderDetails.Text = "Sipariş Detayı";
            // 
            // gbOrderTotals
            // 
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
            gbOrderTotals.Location = new Point(633, 239);
            gbOrderTotals.Name = "gbOrderTotals";
            gbOrderTotals.Size = new Size(598, 244);
            gbOrderTotals.TabIndex = 2;
            gbOrderTotals.TabStop = false;
            gbOrderTotals.Text = "Sipariş Toplamları";
            // 
            // txtProfitRatio
            // 
            txtProfitRatio.Location = new Point(165, 115);
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
            lblPercentage.Location = new Point(165, 92);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(71, 20);
            lblPercentage.TabIndex = 15;
            lblPercentage.Text = "Kar Oranı";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(165, 57);
            txtProfit.MaxLength = 200;
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(151, 27);
            txtProfit.TabIndex = 14;
            txtProfit.TabStop = false;
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
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(7, 172);
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
            lblTotalQuantity.Location = new Point(8, 149);
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
            txtTotalCost.Location = new Point(6, 57);
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
            lvlTotalOrderCost.Location = new Point(7, 35);
            lvlTotalOrderCost.Name = "lvlTotalOrderCost";
            lvlTotalOrderCost.Size = new Size(58, 20);
            lvlTotalOrderCost.TabIndex = 1;
            lvlTotalOrderCost.Text = "Maliyet";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(398, 209);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelOrder_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(498, 209);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(94, 29);
            btnSaveOrder.TabIndex = 15;
            btnSaveOrder.Text = "Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // gbAddProductDetail
            // 
            gbAddProductDetail.Controls.Add(btnDeleteOrderDetail);
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
            gbAddProductDetail.Location = new Point(6, 239);
            gbAddProductDetail.Name = "gbAddProductDetail";
            gbAddProductDetail.Size = new Size(621, 244);
            gbAddProductDetail.TabIndex = 1;
            gbAddProductDetail.TabStop = false;
            gbAddProductDetail.Text = "Ürün Ekle";
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.Location = new Point(307, 209);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(151, 29);
            btnDeleteOrderDetail.TabIndex = 12;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Location = new Point(464, 209);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(151, 29);
            btnAddOrderDetail.TabIndex = 13;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Location = new Point(307, 115);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(151, 27);
            nudQuantity.TabIndex = 8;
            nudQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(307, 92);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Miktar";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(464, 115);
            nudPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(151, 27);
            nudPrice.TabIndex = 11;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(464, 92);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Fiyat";
            // 
            // nudCost
            // 
            nudCost.DecimalPlaces = 2;
            nudCost.Location = new Point(464, 57);
            nudCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(151, 27);
            nudCost.TabIndex = 10;
            nudCost.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(464, 35);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(58, 20);
            lblCost.TabIndex = 5;
            lblCost.Text = "Maliyet";
            // 
            // cbUnitCode
            // 
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(307, 57);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(151, 28);
            cbUnitCode.TabIndex = 7;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(307, 35);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(83, 20);
            lblUnitCode.TabIndex = 3;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(6, 211);
            txtSearchProduct.MaxLength = 200;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(295, 27);
            txtSearchProduct.TabIndex = 6;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lbProducts
            // 
            lbProducts.FormattingEnabled = true;
            lbProducts.Location = new Point(6, 58);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(295, 144);
            lbProducts.TabIndex = 5;
            lbProducts.SelectedIndexChanged += lbProducts_SelectedIndexChanged;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(6, 35);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(57, 20);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Ürünler";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.AllowColumnReorder = true;
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmUnitCost, clmUnitPrice, clmProductUnitCode, clmQuantity, clmProducedQuantity, clmRemainingQuantity, clmTotalCost, clmTotalPrice, clmTotalProfit, clmTotalProfitPercentage });
            lvOrderDetails.ContextMenuStrip = cmsOrderDetail;
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(6, 27);
            lvOrderDetails.MultiSelect = false;
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(1225, 207);
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
            clmUnitCost.Text = "Birim Maliyet";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.Text = "Birim Fiyat";
            // 
            // clmProductUnitCode
            // 
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
            // cmsOrderDetail
            // 
            cmsOrderDetail.ImageScalingSize = new Size(20, 20);
            cmsOrderDetail.Items.AddRange(new ToolStripItem[] { miDelete, miEditProducedQuantity });
            cmsOrderDetail.Name = "cmsOrderDetail";
            cmsOrderDetail.ShowImageMargin = false;
            cmsOrderDetail.Size = new Size(243, 52);
            // 
            // miDelete
            // 
            miDelete.Name = "miDelete";
            miDelete.ShortcutKeys = Keys.Delete;
            miDelete.Size = new Size(242, 24);
            miDelete.Text = "Sil";
            // 
            // miEditProducedQuantity
            // 
            miEditProducedQuantity.Name = "miEditProducedQuantity";
            miEditProducedQuantity.ShortcutKeys = Keys.F2;
            miEditProducedQuantity.Size = new Size(242, 24);
            miEditProducedQuantity.Text = "Üretim Miktarını Düzenle";
            // 
            // AddUpdateOrder
            // 
            AcceptButton = btnSaveOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1261, 597);
            Controls.Add(gbOrderDetails);
            Controls.Add(gbOrderHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            cmsOrderDetail.ResumeLayout(false);
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
        private TextBox txtProfitRatio;
        private Label lblPercentage;
        private TextBox txtProfit;
        private Label lvlProfit;
        private Button btnCancel;
        private Button btnDeleteOrderDetail;
        private ContextMenuStrip cmsOrderDetail;
        private ToolStripMenuItem miDelete;
        private ToolStripMenuItem miEditProducedQuantity;
    }
}