namespace EnezcamERP.Forms.Produced_Product_Forms
{
    partial class EditProducedOrders
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
            gbOrderDetail = new GroupBox();
            lvOrderDetails = new ListView();
            clmProductName = new ColumnHeader();
            clmCode = new ColumnHeader();
            clmUnitCost = new ColumnHeader();
            clmUnitPrice = new ColumnHeader();
            clmSize = new ColumnHeader();
            clmUnitCode = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmProducedQuantity0 = new ColumnHeader();
            clmRemainingQuantity0 = new ColumnHeader();
            cmsProducedOrders = new ContextMenuStrip(components);
            checkAllToolStripMenuItem = new ToolStripMenuItem();
            checkSameProductsToolStripMenuItem = new ToolStripMenuItem();
            uncheckAllToolStripMenuItem = new ToolStripMenuItem();
            gbProducedOrders = new GroupBox();
            gbAddDeleteProducedOrders = new GroupBox();
            cbIsStock = new CheckBox();
            dtpProduceDate = new DateTimePicker();
            lblProduceQuantity = new Label();
            btnMultipleComplete = new Button();
            btnAddProducedQuantity = new Button();
            lblDate = new Label();
            btnDeleteProducedOrder = new Button();
            nudProducedQuantity = new NumericUpDown();
            txtRemainigQuantity = new TextBox();
            txtProducedQuantity = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            lblProducedQuantity = new Label();
            lvProduceHistory = new ListView();
            clmDate = new ColumnHeader();
            clmProducedQuantity = new ColumnHeader();
            clmRemaningQuantity = new ColumnHeader();
            clmIsStock = new ColumnHeader();
            lblRemainingQuantity = new Label();
            lnlProductName = new Label();
            lblQuantity = new Label();
            gbOrderDetail.SuspendLayout();
            cmsProducedOrders.SuspendLayout();
            gbProducedOrders.SuspendLayout();
            gbAddDeleteProducedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedQuantity).BeginInit();
            SuspendLayout();
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrderDetail.Controls.Add(lvOrderDetails);
            gbOrderDetail.Controls.Add(gbProducedOrders);
            gbOrderDetail.Location = new Point(11, 12);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(1003, 709);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrderDetails.CheckBoxes = true;
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmCode, clmUnitCost, clmUnitPrice, clmSize, clmUnitCode, clmQuantity, clmProducedQuantity0, clmRemainingQuantity0 });
            lvOrderDetails.ContextMenuStrip = cmsProducedOrders;
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(6, 27);
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(991, 265);
            lvOrderDetails.TabIndex = 0;
            lvOrderDetails.UseCompatibleStateImageBehavior = false;
            lvOrderDetails.View = View.Details;
            lvOrderDetails.ItemChecked += lvOrderDetails_SelectedIndexChangedAndChecked;
            lvOrderDetails.SelectedIndexChanged += lvOrderDetails_SelectedIndexChangedAndChecked;
            // 
            // clmProductName
            // 
            clmProductName.Text = "Ürün Adı";
            // 
            // clmCode
            // 
            clmCode.Text = "Ürün Kodu";
            // 
            // clmUnitCost
            // 
            clmUnitCost.Text = "Maliyet";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.Text = "Fiyat";
            // 
            // clmSize
            // 
            clmSize.Text = "Boyut";
            // 
            // clmUnitCode
            // 
            clmUnitCode.Text = "Birim";
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Miktar";
            // 
            // clmProducedQuantity0
            // 
            clmProducedQuantity0.Text = "Üretilen Miktar";
            // 
            // clmRemainingQuantity0
            // 
            clmRemainingQuantity0.Text = "Kalan Miktar";
            // 
            // cmsProducedOrders
            // 
            cmsProducedOrders.ImageScalingSize = new Size(20, 20);
            cmsProducedOrders.Items.AddRange(new ToolStripItem[] { checkAllToolStripMenuItem, checkSameProductsToolStripMenuItem, uncheckAllToolStripMenuItem });
            cmsProducedOrders.Name = "cmsProducedOrders";
            cmsProducedOrders.Size = new Size(191, 76);
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
            uncheckAllToolStripMenuItem.Text = "Seçimi Kaldır";
            uncheckAllToolStripMenuItem.Click += uncheckAllToolStripMenuItem_Click;
            // 
            // gbProducedOrders
            // 
            gbProducedOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProducedOrders.Controls.Add(gbAddDeleteProducedOrders);
            gbProducedOrders.Controls.Add(txtRemainigQuantity);
            gbProducedOrders.Controls.Add(txtProducedQuantity);
            gbProducedOrders.Controls.Add(txtQuantity);
            gbProducedOrders.Controls.Add(txtProductName);
            gbProducedOrders.Controls.Add(lblProducedQuantity);
            gbProducedOrders.Controls.Add(lvProduceHistory);
            gbProducedOrders.Controls.Add(lblRemainingQuantity);
            gbProducedOrders.Controls.Add(lnlProductName);
            gbProducedOrders.Controls.Add(lblQuantity);
            gbProducedOrders.Location = new Point(6, 299);
            gbProducedOrders.Name = "gbProducedOrders";
            gbProducedOrders.Size = new Size(992, 404);
            gbProducedOrders.TabIndex = 3;
            gbProducedOrders.TabStop = false;
            gbProducedOrders.Text = "Üretim Geçmişi";
            // 
            // gbAddDeleteProducedOrders
            // 
            gbAddDeleteProducedOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gbAddDeleteProducedOrders.Controls.Add(cbIsStock);
            gbAddDeleteProducedOrders.Controls.Add(dtpProduceDate);
            gbAddDeleteProducedOrders.Controls.Add(lblProduceQuantity);
            gbAddDeleteProducedOrders.Controls.Add(btnMultipleComplete);
            gbAddDeleteProducedOrders.Controls.Add(btnAddProducedQuantity);
            gbAddDeleteProducedOrders.Controls.Add(lblDate);
            gbAddDeleteProducedOrders.Controls.Add(btnDeleteProducedOrder);
            gbAddDeleteProducedOrders.Controls.Add(nudProducedQuantity);
            gbAddDeleteProducedOrders.Location = new Point(645, 161);
            gbAddDeleteProducedOrders.Name = "gbAddDeleteProducedOrders";
            gbAddDeleteProducedOrders.Size = new Size(342, 237);
            gbAddDeleteProducedOrders.TabIndex = 8;
            gbAddDeleteProducedOrders.TabStop = false;
            gbAddDeleteProducedOrders.Text = "Ekle / Sil";
            // 
            // cbIsStock
            // 
            cbIsStock.AutoSize = true;
            cbIsStock.Location = new Point(101, 96);
            cbIsStock.Margin = new Padding(3, 4, 3, 4);
            cbIsStock.Name = "cbIsStock";
            cbIsStock.Size = new Size(60, 24);
            cbIsStock.TabIndex = 4;
            cbIsStock.Text = "Stok";
            cbIsStock.UseVisualStyleBackColor = true;
            // 
            // dtpProduceDate
            // 
            dtpProduceDate.Location = new Point(101, 27);
            dtpProduceDate.Name = "dtpProduceDate";
            dtpProduceDate.Size = new Size(229, 27);
            dtpProduceDate.TabIndex = 2;
            // 
            // lblProduceQuantity
            // 
            lblProduceQuantity.AutoSize = true;
            lblProduceQuantity.Location = new Point(6, 61);
            lblProduceQuantity.Name = "lblProduceQuantity";
            lblProduceQuantity.Size = new Size(51, 20);
            lblProduceQuantity.TabIndex = 7;
            lblProduceQuantity.Text = "Miktar";
            // 
            // btnMultipleComplete
            // 
            btnMultipleComplete.Enabled = false;
            btnMultipleComplete.Location = new Point(101, 197);
            btnMultipleComplete.Name = "btnMultipleComplete";
            btnMultipleComplete.Size = new Size(229, 29);
            btnMultipleComplete.TabIndex = 7;
            btnMultipleComplete.Text = "Seçilenleri Tamamla";
            btnMultipleComplete.UseVisualStyleBackColor = true;
            btnMultipleComplete.Click += btnMultipleComplete_Click;
            // 
            // btnAddProducedQuantity
            // 
            btnAddProducedQuantity.Location = new Point(101, 128);
            btnAddProducedQuantity.Name = "btnAddProducedQuantity";
            btnAddProducedQuantity.Size = new Size(229, 29);
            btnAddProducedQuantity.TabIndex = 5;
            btnAddProducedQuantity.Text = "Ekle";
            btnAddProducedQuantity.UseVisualStyleBackColor = true;
            btnAddProducedQuantity.Click += btnAddProducedOrder_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(6, 31);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(40, 20);
            lblDate.TabIndex = 6;
            lblDate.Text = "Tarih";
            // 
            // btnDeleteProducedOrder
            // 
            btnDeleteProducedOrder.Location = new Point(101, 163);
            btnDeleteProducedOrder.Name = "btnDeleteProducedOrder";
            btnDeleteProducedOrder.Size = new Size(229, 29);
            btnDeleteProducedOrder.TabIndex = 6;
            btnDeleteProducedOrder.Text = "Sil";
            btnDeleteProducedOrder.UseVisualStyleBackColor = true;
            btnDeleteProducedOrder.Click += btnDeleteProducedOrder_Click;
            // 
            // nudProducedQuantity
            // 
            nudProducedQuantity.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudProducedQuantity.Location = new Point(101, 59);
            nudProducedQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudProducedQuantity.Name = "nudProducedQuantity";
            nudProducedQuantity.Size = new Size(229, 27);
            nudProducedQuantity.TabIndex = 3;
            nudProducedQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtRemainigQuantity
            // 
            txtRemainigQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtRemainigQuantity.Location = new Point(757, 125);
            txtRemainigQuantity.MaxLength = 200;
            txtRemainigQuantity.Name = "txtRemainigQuantity";
            txtRemainigQuantity.ReadOnly = true;
            txtRemainigQuantity.Size = new Size(223, 27);
            txtRemainigQuantity.TabIndex = 1;
            txtRemainigQuantity.TabStop = false;
            // 
            // txtProducedQuantity
            // 
            txtProducedQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtProducedQuantity.Location = new Point(757, 92);
            txtProducedQuantity.MaxLength = 200;
            txtProducedQuantity.Name = "txtProducedQuantity";
            txtProducedQuantity.ReadOnly = true;
            txtProducedQuantity.Size = new Size(223, 27);
            txtProducedQuantity.TabIndex = 1;
            txtProducedQuantity.TabStop = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtQuantity.Location = new Point(757, 59);
            txtQuantity.MaxLength = 200;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(223, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.TabStop = false;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtProductName.Location = new Point(757, 27);
            txtProductName.MaxLength = 200;
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(223, 27);
            txtProductName.TabIndex = 1;
            txtProductName.TabStop = false;
            // 
            // lblProducedQuantity
            // 
            lblProducedQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblProducedQuantity.AutoSize = true;
            lblProducedQuantity.Location = new Point(645, 95);
            lblProducedQuantity.Name = "lblProducedQuantity";
            lblProducedQuantity.Size = new Size(107, 20);
            lblProducedQuantity.TabIndex = 0;
            lblProducedQuantity.Text = "Üretilen Miktar";
            // 
            // lvProduceHistory
            // 
            lvProduceHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProduceHistory.Columns.AddRange(new ColumnHeader[] { clmDate, clmProducedQuantity, clmRemaningQuantity, clmIsStock });
            lvProduceHistory.FullRowSelect = true;
            lvProduceHistory.GridLines = true;
            lvProduceHistory.Location = new Point(6, 29);
            lvProduceHistory.MultiSelect = false;
            lvProduceHistory.Name = "lvProduceHistory";
            lvProduceHistory.Size = new Size(633, 369);
            lvProduceHistory.TabIndex = 1;
            lvProduceHistory.UseCompatibleStateImageBehavior = false;
            lvProduceHistory.View = View.Details;
            lvProduceHistory.KeyDown += ListView_KeyDown;
            // 
            // clmDate
            // 
            clmDate.Text = "Tarih";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretim Miktarı";
            // 
            // clmRemaningQuantity
            // 
            clmRemaningQuantity.Text = "Kalan Üretim";
            // 
            // clmIsStock
            // 
            clmIsStock.Text = "Üretim Türü";
            // 
            // lblRemainingQuantity
            // 
            lblRemainingQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRemainingQuantity.AutoSize = true;
            lblRemainingQuantity.Location = new Point(645, 128);
            lblRemainingQuantity.Name = "lblRemainingQuantity";
            lblRemainingQuantity.Size = new Size(92, 20);
            lblRemainingQuantity.TabIndex = 0;
            lblRemainingQuantity.Text = "Kalan Miktar";
            // 
            // lnlProductName
            // 
            lnlProductName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lnlProductName.AutoSize = true;
            lnlProductName.Location = new Point(645, 29);
            lnlProductName.Name = "lnlProductName";
            lnlProductName.Size = new Size(40, 20);
            lnlProductName.TabIndex = 0;
            lnlProductName.Text = "Ürün";
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(645, 61);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Miktar";
            // 
            // EditProducedOrders
            // 
            AcceptButton = btnAddProducedQuantity;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 733);
            Controls.Add(gbOrderDetail);
            Name = "EditProducedOrders";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üretim Miktarı Düzenle";
            gbOrderDetail.ResumeLayout(false);
            cmsProducedOrders.ResumeLayout(false);
            gbProducedOrders.ResumeLayout(false);
            gbProducedOrders.PerformLayout();
            gbAddDeleteProducedOrders.ResumeLayout(false);
            gbAddDeleteProducedOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrderDetail;
        private TextBox txtProductName;
        private Label lnlProductName;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtRemainigQuantity;
        private Label lblRemainingQuantity;
        private GroupBox gbProducedOrders;
        private ListView lvProduceHistory;
        private ColumnHeader clmDate;
        private ColumnHeader clmProducedQuantity;
        private Button btnAddProducedQuantity;
        private Button btnDeleteProducedOrder;
        private Label lblDate;
        private NumericUpDown nudProducedQuantity;
        private DateTimePicker dtpProduceDate;
        private Label lblProduceQuantity;
        private TextBox txtProducedQuantity;
        private Label lblProducedQuantity;
        private GroupBox gbAddDeleteProducedOrders;
        private ListView lvOrderDetails;
        private ColumnHeader clmProductName;
        private ColumnHeader clmUnitCost;
        private ColumnHeader clmUnitPrice;
        private ColumnHeader clmUnitCode;
        private ColumnHeader clmQuantity;
        private ColumnHeader clmProducedQuantity0;
        private ColumnHeader clmRemainingQuantity0;
        private ColumnHeader clmRemaningQuantity;
        private ColumnHeader clmCode;
        private CheckBox cbIsStock;
        private ColumnHeader clmIsStock;
        private ColumnHeader clmSize;
        private Button btnMultipleComplete;
        private ContextMenuStrip cmsProducedOrders;
        private ToolStripMenuItem checkAllToolStripMenuItem;
        private ToolStripMenuItem checkSameProductsToolStripMenuItem;
        private ToolStripMenuItem uncheckAllToolStripMenuItem;
    }
}