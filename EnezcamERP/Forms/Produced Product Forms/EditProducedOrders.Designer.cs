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
            gbProducedOrders.SuspendLayout();
            gbAddDeleteProducedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProducedQuantity).BeginInit();
            SuspendLayout();
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Controls.Add(lvOrderDetails);
            gbOrderDetail.Controls.Add(gbProducedOrders);
            gbOrderDetail.Location = new Point(10, 9);
            gbOrderDetail.Margin = new Padding(3, 2, 3, 2);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Padding = new Padding(3, 2, 3, 2);
            gbOrderDetail.Size = new Size(878, 532);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.CheckBoxes = true;
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmCode, clmUnitCost, clmUnitPrice, clmSize, clmUnitCode, clmQuantity, clmProducedQuantity0, clmRemainingQuantity0 });
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(5, 20);
            lvOrderDetails.Margin = new Padding(3, 2, 3, 2);
            lvOrderDetails.MultiSelect = false;
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(868, 200);
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
            // gbProducedOrders
            // 
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
            gbProducedOrders.Location = new Point(5, 224);
            gbProducedOrders.Margin = new Padding(3, 2, 3, 2);
            gbProducedOrders.Name = "gbProducedOrders";
            gbProducedOrders.Padding = new Padding(3, 2, 3, 2);
            gbProducedOrders.Size = new Size(868, 303);
            gbProducedOrders.TabIndex = 3;
            gbProducedOrders.TabStop = false;
            gbProducedOrders.Text = "Üretim Geçmişi";
            // 
            // gbAddDeleteProducedOrders
            // 
            gbAddDeleteProducedOrders.Controls.Add(cbIsStock);
            gbAddDeleteProducedOrders.Controls.Add(dtpProduceDate);
            gbAddDeleteProducedOrders.Controls.Add(lblProduceQuantity);
            gbAddDeleteProducedOrders.Controls.Add(btnMultipleComplete);
            gbAddDeleteProducedOrders.Controls.Add(btnAddProducedQuantity);
            gbAddDeleteProducedOrders.Controls.Add(lblDate);
            gbAddDeleteProducedOrders.Controls.Add(btnDeleteProducedOrder);
            gbAddDeleteProducedOrders.Controls.Add(nudProducedQuantity);
            gbAddDeleteProducedOrders.Location = new Point(564, 121);
            gbAddDeleteProducedOrders.Margin = new Padding(3, 2, 3, 2);
            gbAddDeleteProducedOrders.Name = "gbAddDeleteProducedOrders";
            gbAddDeleteProducedOrders.Padding = new Padding(3, 2, 3, 2);
            gbAddDeleteProducedOrders.Size = new Size(299, 178);
            gbAddDeleteProducedOrders.TabIndex = 8;
            gbAddDeleteProducedOrders.TabStop = false;
            gbAddDeleteProducedOrders.Text = "Ekle / Sil";
            // 
            // cbIsStock
            // 
            cbIsStock.AutoSize = true;
            cbIsStock.Location = new Point(88, 72);
            cbIsStock.Name = "cbIsStock";
            cbIsStock.Size = new Size(49, 19);
            cbIsStock.TabIndex = 4;
            cbIsStock.Text = "Stok";
            cbIsStock.UseVisualStyleBackColor = true;
            // 
            // dtpProduceDate
            // 
            dtpProduceDate.Location = new Point(88, 20);
            dtpProduceDate.Margin = new Padding(3, 2, 3, 2);
            dtpProduceDate.Name = "dtpProduceDate";
            dtpProduceDate.Size = new Size(201, 23);
            dtpProduceDate.TabIndex = 2;
            // 
            // lblProduceQuantity
            // 
            lblProduceQuantity.AutoSize = true;
            lblProduceQuantity.Location = new Point(5, 46);
            lblProduceQuantity.Name = "lblProduceQuantity";
            lblProduceQuantity.Size = new Size(41, 15);
            lblProduceQuantity.TabIndex = 7;
            lblProduceQuantity.Text = "Miktar";
            // 
            // btnMultipleComplete
            // 
            btnMultipleComplete.Enabled = false;
            btnMultipleComplete.Location = new Point(88, 148);
            btnMultipleComplete.Margin = new Padding(3, 2, 3, 2);
            btnMultipleComplete.Name = "btnMultipleComplete";
            btnMultipleComplete.Size = new Size(200, 22);
            btnMultipleComplete.TabIndex = 7;
            btnMultipleComplete.Text = "Seçilenleri Tamamla";
            btnMultipleComplete.UseVisualStyleBackColor = true;
            btnMultipleComplete.Click += btnMultipleComplete_Click;
            // 
            // btnAddProducedQuantity
            // 
            btnAddProducedQuantity.Location = new Point(88, 96);
            btnAddProducedQuantity.Margin = new Padding(3, 2, 3, 2);
            btnAddProducedQuantity.Name = "btnAddProducedQuantity";
            btnAddProducedQuantity.Size = new Size(200, 22);
            btnAddProducedQuantity.TabIndex = 5;
            btnAddProducedQuantity.Text = "Ekle";
            btnAddProducedQuantity.UseVisualStyleBackColor = true;
            btnAddProducedQuantity.Click += btnAddProducedOrder_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(5, 23);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(32, 15);
            lblDate.TabIndex = 6;
            lblDate.Text = "Tarih";
            // 
            // btnDeleteProducedOrder
            // 
            btnDeleteProducedOrder.Location = new Point(88, 122);
            btnDeleteProducedOrder.Margin = new Padding(3, 2, 3, 2);
            btnDeleteProducedOrder.Name = "btnDeleteProducedOrder";
            btnDeleteProducedOrder.Size = new Size(200, 22);
            btnDeleteProducedOrder.TabIndex = 6;
            btnDeleteProducedOrder.Text = "Sil";
            btnDeleteProducedOrder.UseVisualStyleBackColor = true;
            btnDeleteProducedOrder.Click += btnDeleteProducedOrder_Click;
            // 
            // nudProducedQuantity
            // 
            nudProducedQuantity.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudProducedQuantity.Location = new Point(88, 44);
            nudProducedQuantity.Margin = new Padding(3, 2, 3, 2);
            nudProducedQuantity.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudProducedQuantity.Name = "nudProducedQuantity";
            nudProducedQuantity.Size = new Size(200, 23);
            nudProducedQuantity.TabIndex = 3;
            // 
            // txtRemainigQuantity
            // 
            txtRemainigQuantity.Location = new Point(662, 94);
            txtRemainigQuantity.Margin = new Padding(3, 2, 3, 2);
            txtRemainigQuantity.MaxLength = 200;
            txtRemainigQuantity.Name = "txtRemainigQuantity";
            txtRemainigQuantity.ReadOnly = true;
            txtRemainigQuantity.Size = new Size(196, 23);
            txtRemainigQuantity.TabIndex = 1;
            txtRemainigQuantity.TabStop = false;
            // 
            // txtProducedQuantity
            // 
            txtProducedQuantity.Location = new Point(662, 69);
            txtProducedQuantity.Margin = new Padding(3, 2, 3, 2);
            txtProducedQuantity.MaxLength = 200;
            txtProducedQuantity.Name = "txtProducedQuantity";
            txtProducedQuantity.ReadOnly = true;
            txtProducedQuantity.Size = new Size(196, 23);
            txtProducedQuantity.TabIndex = 1;
            txtProducedQuantity.TabStop = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(662, 44);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.MaxLength = 200;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(196, 23);
            txtQuantity.TabIndex = 1;
            txtQuantity.TabStop = false;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(662, 20);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.MaxLength = 200;
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(196, 23);
            txtProductName.TabIndex = 1;
            txtProductName.TabStop = false;
            // 
            // lblProducedQuantity
            // 
            lblProducedQuantity.AutoSize = true;
            lblProducedQuantity.Location = new Point(564, 71);
            lblProducedQuantity.Name = "lblProducedQuantity";
            lblProducedQuantity.Size = new Size(85, 15);
            lblProducedQuantity.TabIndex = 0;
            lblProducedQuantity.Text = "Üretilen Miktar";
            // 
            // lvProduceHistory
            // 
            lvProduceHistory.Columns.AddRange(new ColumnHeader[] { clmDate, clmProducedQuantity, clmRemaningQuantity, clmIsStock });
            lvProduceHistory.FullRowSelect = true;
            lvProduceHistory.GridLines = true;
            lvProduceHistory.Location = new Point(5, 22);
            lvProduceHistory.Margin = new Padding(3, 2, 3, 2);
            lvProduceHistory.MultiSelect = false;
            lvProduceHistory.Name = "lvProduceHistory";
            lvProduceHistory.Size = new Size(554, 278);
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
            lblRemainingQuantity.AutoSize = true;
            lblRemainingQuantity.Location = new Point(564, 96);
            lblRemainingQuantity.Name = "lblRemainingQuantity";
            lblRemainingQuantity.Size = new Size(73, 15);
            lblRemainingQuantity.TabIndex = 0;
            lblRemainingQuantity.Text = "Kalan Miktar";
            // 
            // lnlProductName
            // 
            lnlProductName.AutoSize = true;
            lnlProductName.Location = new Point(564, 22);
            lnlProductName.Name = "lnlProductName";
            lnlProductName.Size = new Size(33, 15);
            lnlProductName.TabIndex = 0;
            lnlProductName.Text = "Ürün";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(564, 46);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(41, 15);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Miktar";
            // 
            // EditProducedOrders
            // 
            AcceptButton = btnAddProducedQuantity;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(gbOrderDetail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EditProducedOrders";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üretim Miktarı Düzenle";
            gbOrderDetail.ResumeLayout(false);
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
    }
}