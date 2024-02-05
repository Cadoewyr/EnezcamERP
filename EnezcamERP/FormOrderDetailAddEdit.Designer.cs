namespace EnezcamERP
{
    partial class FormOrderDetailAddEdit
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
            btnDeleteOrderDetail = new Button();
            btnCancel = new Button();
            btnSaveOrderDetail = new Button();
            nudCost = new NumericUpDown();
            nudPrice = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            cbProduct = new ComboBox();
            cbUnitCode = new ComboBox();
            lblUnitCost = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblUnitCode = new Label();
            lblProductName = new Label();
            gbProducedProducts = new GroupBox();
            gbProduceHistoryEdit = new GroupBox();
            dtpIssueDateEdit = new DateTimePicker();
            btnDeleteProduceHistory = new Button();
            nudProducedCountEdit = new NumericUpDown();
            btnSaveProduceHistory = new Button();
            lblProducedCountEdit = new Label();
            lblIssueDateEdit = new Label();
            gbProduceHistoryAdd = new GroupBox();
            nudProducedCountAdd = new NumericUpDown();
            dtpIssueDateAdd = new DateTimePicker();
            lblIssueDateAdd = new Label();
            btnAddProduceHistory = new Button();
            lblProducedCountAdd = new Label();
            lvProduceHistory = new ListView();
            clmIssueDate = new ColumnHeader();
            clmProductName = new ColumnHeader();
            clmTotalQuantity = new ColumnHeader();
            clmProducedQuantity = new ColumnHeader();
            clmRemainingQuantity = new ColumnHeader();
            gbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            gbProducedProducts.SuspendLayout();
            gbProduceHistoryEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedCountEdit).BeginInit();
            gbProduceHistoryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedCountAdd).BeginInit();
            SuspendLayout();
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Controls.Add(btnDeleteOrderDetail);
            gbOrderDetail.Controls.Add(btnCancel);
            gbOrderDetail.Controls.Add(btnSaveOrderDetail);
            gbOrderDetail.Controls.Add(nudCost);
            gbOrderDetail.Controls.Add(nudPrice);
            gbOrderDetail.Controls.Add(nudQuantity);
            gbOrderDetail.Controls.Add(cbProduct);
            gbOrderDetail.Controls.Add(cbUnitCode);
            gbOrderDetail.Controls.Add(lblUnitCost);
            gbOrderDetail.Controls.Add(lblPrice);
            gbOrderDetail.Controls.Add(lblQuantity);
            gbOrderDetail.Controls.Add(lblUnitCode);
            gbOrderDetail.Controls.Add(lblProductName);
            gbOrderDetail.Location = new Point(12, 12);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(326, 507);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.Location = new Point(4, 216);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(155, 29);
            btnDeleteOrderDetail.TabIndex = 6;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 251);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(314, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveOrderDetail
            // 
            btnSaveOrderDetail.Location = new Point(165, 216);
            btnSaveOrderDetail.Name = "btnSaveOrderDetail";
            btnSaveOrderDetail.Size = new Size(155, 29);
            btnSaveOrderDetail.TabIndex = 1;
            btnSaveOrderDetail.Text = "Kaydet";
            btnSaveOrderDetail.UseVisualStyleBackColor = true;
            btnSaveOrderDetail.Click += btnSaveOrderDetail_Click;
            // 
            // nudCost
            // 
            nudCost.Location = new Point(144, 165);
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(159, 27);
            nudCost.TabIndex = 4;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(144, 132);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(159, 27);
            nudPrice.TabIndex = 4;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(144, 99);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(159, 27);
            nudQuantity.TabIndex = 4;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(144, 31);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(159, 28);
            cbProduct.TabIndex = 3;
            // 
            // cbUnitCode
            // 
            cbUnitCode.FormattingEnabled = true;
            cbUnitCode.Location = new Point(144, 65);
            cbUnitCode.Name = "cbUnitCode";
            cbUnitCode.Size = new Size(159, 28);
            cbUnitCode.TabIndex = 3;
            // 
            // lblUnitCost
            // 
            lblUnitCost.AutoSize = true;
            lblUnitCost.Location = new Point(6, 167);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(97, 20);
            lblUnitCost.TabIndex = 1;
            lblUnitCost.Text = "Birim Maliyet";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(6, 134);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(79, 20);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Birim Fiyat";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(6, 101);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Miktar";
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(6, 68);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(83, 20);
            lblUnitCode.TabIndex = 1;
            lblUnitCode.Text = "Birim Kodu";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 34);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(67, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Ürün Adı";
            // 
            // gbProducedProducts
            // 
            gbProducedProducts.Controls.Add(gbProduceHistoryEdit);
            gbProducedProducts.Controls.Add(gbProduceHistoryAdd);
            gbProducedProducts.Controls.Add(lvProduceHistory);
            gbProducedProducts.Location = new Point(344, 12);
            gbProducedProducts.Name = "gbProducedProducts";
            gbProducedProducts.Size = new Size(726, 507);
            gbProducedProducts.TabIndex = 5;
            gbProducedProducts.TabStop = false;
            gbProducedProducts.Text = "Üretim Geçmişi";
            // 
            // gbProduceHistoryEdit
            // 
            gbProduceHistoryEdit.Controls.Add(dtpIssueDateEdit);
            gbProduceHistoryEdit.Controls.Add(btnDeleteProduceHistory);
            gbProduceHistoryEdit.Controls.Add(nudProducedCountEdit);
            gbProduceHistoryEdit.Controls.Add(btnSaveProduceHistory);
            gbProduceHistoryEdit.Controls.Add(lblProducedCountEdit);
            gbProduceHistoryEdit.Controls.Add(lblIssueDateEdit);
            gbProduceHistoryEdit.Location = new Point(6, 261);
            gbProduceHistoryEdit.Name = "gbProduceHistoryEdit";
            gbProduceHistoryEdit.Size = new Size(354, 240);
            gbProduceHistoryEdit.TabIndex = 7;
            gbProduceHistoryEdit.TabStop = false;
            gbProduceHistoryEdit.Text = "Üretim Geçmişi Düzenle / Sil";
            // 
            // dtpIssueDateEdit
            // 
            dtpIssueDateEdit.Location = new Point(117, 41);
            dtpIssueDateEdit.Name = "dtpIssueDateEdit";
            dtpIssueDateEdit.Size = new Size(231, 27);
            dtpIssueDateEdit.TabIndex = 1;
            // 
            // btnDeleteProduceHistory
            // 
            btnDeleteProduceHistory.Location = new Point(117, 142);
            btnDeleteProduceHistory.Name = "btnDeleteProduceHistory";
            btnDeleteProduceHistory.Size = new Size(231, 29);
            btnDeleteProduceHistory.TabIndex = 5;
            btnDeleteProduceHistory.Text = "Sil";
            btnDeleteProduceHistory.UseVisualStyleBackColor = true;
            btnDeleteProduceHistory.Click += btnDeleteProduceHistory_Click;
            // 
            // nudProducedCountEdit
            // 
            nudProducedCountEdit.Location = new Point(117, 74);
            nudProducedCountEdit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudProducedCountEdit.Name = "nudProducedCountEdit";
            nudProducedCountEdit.Size = new Size(231, 27);
            nudProducedCountEdit.TabIndex = 3;
            // 
            // btnSaveProduceHistory
            // 
            btnSaveProduceHistory.Location = new Point(117, 107);
            btnSaveProduceHistory.Name = "btnSaveProduceHistory";
            btnSaveProduceHistory.Size = new Size(231, 29);
            btnSaveProduceHistory.TabIndex = 4;
            btnSaveProduceHistory.Text = "Kaydet";
            btnSaveProduceHistory.UseVisualStyleBackColor = true;
            btnSaveProduceHistory.Click += btnSaveProduceHistory_Click;
            // 
            // lblProducedCountEdit
            // 
            lblProducedCountEdit.AutoSize = true;
            lblProducedCountEdit.Location = new Point(6, 76);
            lblProducedCountEdit.Name = "lblProducedCountEdit";
            lblProducedCountEdit.Size = new Size(98, 20);
            lblProducedCountEdit.TabIndex = 2;
            lblProducedCountEdit.Text = "Üretim Adedi";
            // 
            // lblIssueDateEdit
            // 
            lblIssueDateEdit.AutoSize = true;
            lblIssueDateEdit.Location = new Point(6, 46);
            lblIssueDateEdit.Name = "lblIssueDateEdit";
            lblIssueDateEdit.Size = new Size(40, 20);
            lblIssueDateEdit.TabIndex = 2;
            lblIssueDateEdit.Text = "Tarih";
            // 
            // gbProduceHistoryAdd
            // 
            gbProduceHistoryAdd.Controls.Add(nudProducedCountAdd);
            gbProduceHistoryAdd.Controls.Add(dtpIssueDateAdd);
            gbProduceHistoryAdd.Controls.Add(lblIssueDateAdd);
            gbProduceHistoryAdd.Controls.Add(btnAddProduceHistory);
            gbProduceHistoryAdd.Controls.Add(lblProducedCountAdd);
            gbProduceHistoryAdd.Location = new Point(366, 261);
            gbProduceHistoryAdd.Name = "gbProduceHistoryAdd";
            gbProduceHistoryAdd.Size = new Size(352, 240);
            gbProduceHistoryAdd.TabIndex = 6;
            gbProduceHistoryAdd.TabStop = false;
            gbProduceHistoryAdd.Text = "Üretim Geçmişi Ekle";
            // 
            // nudProducedCountAdd
            // 
            nudProducedCountAdd.Location = new Point(110, 74);
            nudProducedCountAdd.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudProducedCountAdd.Name = "nudProducedCountAdd";
            nudProducedCountAdd.Size = new Size(231, 27);
            nudProducedCountAdd.TabIndex = 1;
            // 
            // dtpIssueDateAdd
            // 
            dtpIssueDateAdd.Location = new Point(110, 41);
            dtpIssueDateAdd.Name = "dtpIssueDateAdd";
            dtpIssueDateAdd.Size = new Size(231, 27);
            dtpIssueDateAdd.TabIndex = 0;
            // 
            // lblIssueDateAdd
            // 
            lblIssueDateAdd.AutoSize = true;
            lblIssueDateAdd.Location = new Point(6, 46);
            lblIssueDateAdd.Name = "lblIssueDateAdd";
            lblIssueDateAdd.Size = new Size(40, 20);
            lblIssueDateAdd.TabIndex = 2;
            lblIssueDateAdd.Text = "Tarih";
            // 
            // btnAddProduceHistory
            // 
            btnAddProduceHistory.Location = new Point(110, 107);
            btnAddProduceHistory.Name = "btnAddProduceHistory";
            btnAddProduceHistory.Size = new Size(231, 29);
            btnAddProduceHistory.TabIndex = 4;
            btnAddProduceHistory.Text = "Ekle";
            btnAddProduceHistory.UseVisualStyleBackColor = true;
            btnAddProduceHistory.Click += btnAddProduceHistory_Click;
            // 
            // lblProducedCountAdd
            // 
            lblProducedCountAdd.AutoSize = true;
            lblProducedCountAdd.Location = new Point(6, 76);
            lblProducedCountAdd.Name = "lblProducedCountAdd";
            lblProducedCountAdd.Size = new Size(98, 20);
            lblProducedCountAdd.TabIndex = 2;
            lblProducedCountAdd.Text = "Üretim Adedi";
            // 
            // lvProduceHistory
            // 
            lvProduceHistory.Columns.AddRange(new ColumnHeader[] { clmIssueDate, clmProductName, clmTotalQuantity, clmProducedQuantity, clmRemainingQuantity });
            lvProduceHistory.Location = new Point(6, 26);
            lvProduceHistory.Name = "lvProduceHistory";
            lvProduceHistory.Size = new Size(712, 229);
            lvProduceHistory.TabIndex = 0;
            lvProduceHistory.UseCompatibleStateImageBehavior = false;
            lvProduceHistory.View = View.Details;
            lvProduceHistory.SelectedIndexChanged += lvProduceHistory_SelectedIndexChanged;
            // 
            // clmIssueDate
            // 
            clmIssueDate.Text = "Tarih";
            // 
            // clmProductName
            // 
            clmProductName.Text = "Ürün Adı";
            // 
            // clmTotalQuantity
            // 
            clmTotalQuantity.Text = "Sipariş Adedi";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretim Adedi";
            // 
            // clmRemainingQuantity
            // 
            clmRemainingQuantity.Text = "Kalan Adet";
            // 
            // FormOrderDetailAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 531);
            Controls.Add(gbOrderDetail);
            Controls.Add(gbProducedProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormOrderDetailAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Detayı";
            Load += FormOrderDetailAddEdit_Load;
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            gbProducedProducts.ResumeLayout(false);
            gbProduceHistoryEdit.ResumeLayout(false);
            gbProduceHistoryEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedCountEdit).EndInit();
            gbProduceHistoryAdd.ResumeLayout(false);
            gbProduceHistoryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedCountAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrderDetail;
        private Label lblProductName;
        private Label lblUnitCode;
        private ComboBox cbUnitCode;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudCost;
        private NumericUpDown nudPrice;
        private Label lblUnitCost;
        private Label lblPrice;
        private Label lblQuantity;
        private GroupBox gbProducedProducts;
        private ListView lvProduceHistory;
        private ColumnHeader clmIssueDate;
        private ColumnHeader clmProductName;
        private ColumnHeader clmTotalQuantity;
        private ColumnHeader clmProducedQuantity;
        private ColumnHeader clmRemainingQuantity;
        private Button btnDeleteOrderDetail;
        private Button btnCancel;
        private Button btnSaveOrderDetail;
        private NumericUpDown nudProducedCountEdit;
        private Label lblProducedCountEdit;
        private Label lblIssueDateEdit;
        private DateTimePicker dtpIssueDateEdit;
        private Button btnSaveProduceHistory;
        private Button btnDeleteProduceHistory;
        private GroupBox gbProduceHistoryAdd;
        private NumericUpDown nudProducedCountAdd;
        private DateTimePicker dtpIssueDateAdd;
        private GroupBox gbProduceHistoryEdit;
        private Label lblIssueDateAdd;
        private Label lblProducedCountAdd;
        private Button btnAddProduceHistory;
        private ComboBox cbProduct;
    }
}