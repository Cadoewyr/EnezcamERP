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
            clmUnitCost = new ColumnHeader();
            clmUnitPrice = new ColumnHeader();
            clmUnitCode = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmProducedQuantity0 = new ColumnHeader();
            clmRemainingQuantity0 = new ColumnHeader();
            gbProducedOrders = new GroupBox();
            gbAddDeleteProducedOrders = new GroupBox();
            dtpProduceDate = new DateTimePicker();
            lblProduceQuantity = new Label();
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
            gbOrderDetail.Location = new Point(12, 12);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(662, 492);
            gbOrderDetail.TabIndex = 0;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Sipariş Detayı";
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmUnitCost, clmUnitPrice, clmUnitCode, clmQuantity, clmProducedQuantity0, clmRemainingQuantity0 });
            lvOrderDetails.FullRowSelect = true;
            lvOrderDetails.GridLines = true;
            lvOrderDetails.Location = new Point(6, 26);
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(650, 98);
            lvOrderDetails.TabIndex = 4;
            lvOrderDetails.UseCompatibleStateImageBehavior = false;
            lvOrderDetails.View = View.Details;
            lvOrderDetails.SelectedIndexChanged += lvOrderDetails_SelectedIndexChanged;
            // 
            // clmProductName
            // 
            clmProductName.Text = "Ürün Adı";
            // 
            // clmUnitCost
            // 
            clmUnitCost.Text = "Maliyet";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.Text = "Fiyat";
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
            gbProducedOrders.Location = new Point(6, 130);
            gbProducedOrders.Name = "gbProducedOrders";
            gbProducedOrders.Size = new Size(650, 356);
            gbProducedOrders.TabIndex = 3;
            gbProducedOrders.TabStop = false;
            gbProducedOrders.Text = "Üretim Geçmişi";
            // 
            // gbAddDeleteProducedOrders
            // 
            gbAddDeleteProducedOrders.Controls.Add(dtpProduceDate);
            gbAddDeleteProducedOrders.Controls.Add(lblProduceQuantity);
            gbAddDeleteProducedOrders.Controls.Add(btnAddProducedQuantity);
            gbAddDeleteProducedOrders.Controls.Add(lblDate);
            gbAddDeleteProducedOrders.Controls.Add(btnDeleteProducedOrder);
            gbAddDeleteProducedOrders.Controls.Add(nudProducedQuantity);
            gbAddDeleteProducedOrders.Location = new Point(308, 182);
            gbAddDeleteProducedOrders.Name = "gbAddDeleteProducedOrders";
            gbAddDeleteProducedOrders.Size = new Size(336, 165);
            gbAddDeleteProducedOrders.TabIndex = 8;
            gbAddDeleteProducedOrders.TabStop = false;
            gbAddDeleteProducedOrders.Text = "Ekle / Sil";
            // 
            // dtpProduceDate
            // 
            dtpProduceDate.Location = new Point(101, 26);
            dtpProduceDate.Name = "dtpProduceDate";
            dtpProduceDate.Size = new Size(229, 27);
            dtpProduceDate.TabIndex = 4;
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
            // btnAddProducedQuantity
            // 
            btnAddProducedQuantity.Location = new Point(101, 92);
            btnAddProducedQuantity.Name = "btnAddProducedQuantity";
            btnAddProducedQuantity.Size = new Size(229, 29);
            btnAddProducedQuantity.TabIndex = 3;
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
            btnDeleteProducedOrder.Location = new Point(101, 127);
            btnDeleteProducedOrder.Name = "btnDeleteProducedOrder";
            btnDeleteProducedOrder.Size = new Size(229, 29);
            btnDeleteProducedOrder.TabIndex = 3;
            btnDeleteProducedOrder.Text = "Sil";
            btnDeleteProducedOrder.UseVisualStyleBackColor = true;
            btnDeleteProducedOrder.Click += btnDeleteProducedOrder_Click;
            // 
            // nudProducedQuantity
            // 
            nudProducedQuantity.DecimalPlaces = 3;
            nudProducedQuantity.Location = new Point(101, 59);
            nudProducedQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudProducedQuantity.Name = "nudProducedQuantity";
            nudProducedQuantity.Size = new Size(229, 27);
            nudProducedQuantity.TabIndex = 5;
            // 
            // txtRemainigQuantity
            // 
            txtRemainigQuantity.Location = new Point(421, 125);
            txtRemainigQuantity.MaxLength = 200;
            txtRemainigQuantity.Name = "txtRemainigQuantity";
            txtRemainigQuantity.ReadOnly = true;
            txtRemainigQuantity.Size = new Size(223, 27);
            txtRemainigQuantity.TabIndex = 1;
            // 
            // txtProducedQuantity
            // 
            txtProducedQuantity.Location = new Point(421, 92);
            txtProducedQuantity.MaxLength = 200;
            txtProducedQuantity.Name = "txtProducedQuantity";
            txtProducedQuantity.ReadOnly = true;
            txtProducedQuantity.Size = new Size(223, 27);
            txtProducedQuantity.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(421, 59);
            txtQuantity.MaxLength = 200;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(223, 27);
            txtQuantity.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(421, 26);
            txtProductName.MaxLength = 200;
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(223, 27);
            txtProductName.TabIndex = 1;
            // 
            // lblProducedQuantity
            // 
            lblProducedQuantity.AutoSize = true;
            lblProducedQuantity.Location = new Point(308, 95);
            lblProducedQuantity.Name = "lblProducedQuantity";
            lblProducedQuantity.Size = new Size(107, 20);
            lblProducedQuantity.TabIndex = 0;
            lblProducedQuantity.Text = "Üretilen Miktar";
            // 
            // lvProduceHistory
            // 
            lvProduceHistory.Columns.AddRange(new ColumnHeader[] { clmDate, clmProducedQuantity });
            lvProduceHistory.FullRowSelect = true;
            lvProduceHistory.GridLines = true;
            lvProduceHistory.Location = new Point(6, 29);
            lvProduceHistory.Name = "lvProduceHistory";
            lvProduceHistory.Size = new Size(296, 318);
            lvProduceHistory.TabIndex = 2;
            lvProduceHistory.UseCompatibleStateImageBehavior = false;
            lvProduceHistory.View = View.Details;
            // 
            // clmDate
            // 
            clmDate.Text = "Tarih";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretim Miktarı";
            // 
            // lblRemainingQuantity
            // 
            lblRemainingQuantity.AutoSize = true;
            lblRemainingQuantity.Location = new Point(308, 128);
            lblRemainingQuantity.Name = "lblRemainingQuantity";
            lblRemainingQuantity.Size = new Size(92, 20);
            lblRemainingQuantity.TabIndex = 0;
            lblRemainingQuantity.Text = "Kalan Miktar";
            // 
            // lnlProductName
            // 
            lnlProductName.AutoSize = true;
            lnlProductName.Location = new Point(308, 29);
            lnlProductName.Name = "lnlProductName";
            lnlProductName.Size = new Size(40, 20);
            lnlProductName.TabIndex = 0;
            lnlProductName.Text = "Ürün";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(308, 62);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 20);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Miktar";
            // 
            // EditProducedOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 516);
            Controls.Add(gbOrderDetail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}