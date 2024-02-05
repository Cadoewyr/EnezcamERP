namespace EnezcamERP
{
    partial class FormOrderAddEdit
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
            gbOrder = new GroupBox();
            lblTotalProduced = new Label();
            lblTotalCount = new Label();
            gbOrderDetails = new GroupBox();
            btnCancel = new Button();
            btnSaveChanges = new Button();
            btnDeleteOrderDetail = new Button();
            btnEditOrderDetail = new Button();
            btnAddOrderDetail = new Button();
            lvOrderDetails = new ListView();
            clmProductName = new ColumnHeader();
            clmType = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmUnitCode = new ColumnHeader();
            clmUnitPrice = new ColumnHeader();
            clmUnitCost = new ColumnHeader();
            clmProfit = new ColumnHeader();
            clmProfitPercentage = new ColumnHeader();
            dtpIssueDate = new DateTimePicker();
            txtCustomer = new TextBox();
            txtProfitPercentage = new TextBox();
            txtProfit = new TextBox();
            txtTotalProduced = new TextBox();
            txtTotalCount = new TextBox();
            txtTotalCost = new TextBox();
            txtTotalPrice = new TextBox();
            lblProfitPercentage = new Label();
            txtJobNo = new TextBox();
            lblProfit = new Label();
            lblIssueDate = new Label();
            lblTotalCost = new Label();
            lblCustomer = new Label();
            lblTotalPrice = new Label();
            lblJobNo = new Label();
            gbOrder.SuspendLayout();
            gbOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(lblTotalProduced);
            gbOrder.Controls.Add(lblTotalCount);
            gbOrder.Controls.Add(gbOrderDetails);
            gbOrder.Controls.Add(dtpIssueDate);
            gbOrder.Controls.Add(txtCustomer);
            gbOrder.Controls.Add(txtProfitPercentage);
            gbOrder.Controls.Add(txtProfit);
            gbOrder.Controls.Add(txtTotalProduced);
            gbOrder.Controls.Add(txtTotalCount);
            gbOrder.Controls.Add(txtTotalCost);
            gbOrder.Controls.Add(txtTotalPrice);
            gbOrder.Controls.Add(lblProfitPercentage);
            gbOrder.Controls.Add(txtJobNo);
            gbOrder.Controls.Add(lblProfit);
            gbOrder.Controls.Add(lblIssueDate);
            gbOrder.Controls.Add(lblTotalCost);
            gbOrder.Controls.Add(lblCustomer);
            gbOrder.Controls.Add(lblTotalPrice);
            gbOrder.Controls.Add(lblJobNo);
            gbOrder.Location = new Point(12, 12);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(1163, 474);
            gbOrder.TabIndex = 0;
            gbOrder.TabStop = false;
            gbOrder.Text = "Sipariş Detayları";
            // 
            // lblTotalProduced
            // 
            lblTotalProduced.AutoSize = true;
            lblTotalProduced.Location = new Point(810, 106);
            lblTotalProduced.Name = "lblTotalProduced";
            lblTotalProduced.Size = new Size(118, 20);
            lblTotalProduced.TabIndex = 7;
            lblTotalProduced.Text = "Toplam Üretilen:";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(513, 106);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(98, 20);
            lblTotalCount.TabIndex = 7;
            lblTotalCount.Text = "Toplam Adet:";
            // 
            // gbOrderDetails
            // 
            gbOrderDetails.Controls.Add(btnCancel);
            gbOrderDetails.Controls.Add(btnSaveChanges);
            gbOrderDetails.Controls.Add(btnDeleteOrderDetail);
            gbOrderDetails.Controls.Add(btnEditOrderDetail);
            gbOrderDetails.Controls.Add(btnAddOrderDetail);
            gbOrderDetails.Controls.Add(lvOrderDetails);
            gbOrderDetails.Location = new Point(6, 136);
            gbOrderDetails.Name = "gbOrderDetails";
            gbOrderDetails.Size = new Size(1151, 332);
            gbOrderDetails.TabIndex = 6;
            gbOrderDetails.TabStop = false;
            gbOrderDetails.Text = "Sipariş Detayları";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(951, 29);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(1051, 29);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(94, 29);
            btnSaveChanges.TabIndex = 7;
            btnSaveChanges.Text = "Kaydet";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.Location = new Point(206, 29);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(94, 29);
            btnDeleteOrderDetail.TabIndex = 5;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // btnEditOrderDetail
            // 
            btnEditOrderDetail.Location = new Point(106, 29);
            btnEditOrderDetail.Name = "btnEditOrderDetail";
            btnEditOrderDetail.Size = new Size(94, 29);
            btnEditOrderDetail.TabIndex = 4;
            btnEditOrderDetail.Text = "Düzenle";
            btnEditOrderDetail.UseVisualStyleBackColor = true;
            btnEditOrderDetail.Click += btnEditOrderDetail_Click;
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Location = new Point(6, 29);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(94, 29);
            btnAddOrderDetail.TabIndex = 3;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // lvOrderDetails
            // 
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmType, clmQuantity, clmUnitCode, clmUnitPrice, clmUnitCost, clmProfit, clmProfitPercentage });
            lvOrderDetails.Location = new Point(6, 64);
            lvOrderDetails.MultiSelect = false;
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(1139, 262);
            lvOrderDetails.TabIndex = 8;
            lvOrderDetails.UseCompatibleStateImageBehavior = false;
            lvOrderDetails.View = View.Details;
            // 
            // clmProductName
            // 
            clmProductName.Text = "Ürün Adı";
            // 
            // clmType
            // 
            clmType.Text = "Tür";
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Miktar";
            // 
            // clmUnitCode
            // 
            clmUnitCode.Text = "Birim";
            // 
            // clmUnitPrice
            // 
            clmUnitPrice.Text = "Birim Fiyat";
            // 
            // clmUnitCost
            // 
            clmUnitCost.Text = "Maliyet";
            // 
            // clmProfit
            // 
            clmProfit.Text = "Kar";
            // 
            // clmProfitPercentage
            // 
            clmProfitPercentage.Text = "Kar (%)";
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(104, 103);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(250, 27);
            dtpIssueDate.TabIndex = 2;
            dtpIssueDate.ValueChanged += Changed;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(104, 70);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(250, 27);
            txtCustomer.TabIndex = 1;
            txtCustomer.TextChanged += Changed;
            // 
            // txtProfitPercentage
            // 
            txtProfitPercentage.Location = new Point(934, 70);
            txtProfitPercentage.MaxLength = 50;
            txtProfitPercentage.Name = "txtProfitPercentage";
            txtProfitPercentage.ReadOnly = true;
            txtProfitPercentage.Size = new Size(158, 27);
            txtProfitPercentage.TabIndex = 7;
            txtProfitPercentage.TabStop = false;
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(934, 37);
            txtProfit.MaxLength = 50;
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(158, 27);
            txtProfit.TabIndex = 6;
            txtProfit.TabStop = false;
            // 
            // txtTotalProduced
            // 
            txtTotalProduced.Location = new Point(934, 103);
            txtTotalProduced.MaxLength = 50;
            txtTotalProduced.Name = "txtTotalProduced";
            txtTotalProduced.ReadOnly = true;
            txtTotalProduced.Size = new Size(158, 27);
            txtTotalProduced.TabIndex = 3;
            txtTotalProduced.TabStop = false;
            // 
            // txtTotalCount
            // 
            txtTotalCount.Location = new Point(631, 103);
            txtTotalCount.MaxLength = 50;
            txtTotalCount.Name = "txtTotalCount";
            txtTotalCount.ReadOnly = true;
            txtTotalCount.Size = new Size(158, 27);
            txtTotalCount.TabIndex = 5;
            txtTotalCount.TabStop = false;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(631, 70);
            txtTotalCost.MaxLength = 50;
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(158, 27);
            txtTotalCost.TabIndex = 4;
            txtTotalCost.TabStop = false;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(631, 37);
            txtTotalPrice.MaxLength = 50;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(158, 27);
            txtTotalPrice.TabIndex = 3;
            txtTotalPrice.TabStop = false;
            // 
            // lblProfitPercentage
            // 
            lblProfitPercentage.AutoSize = true;
            lblProfitPercentage.Location = new Point(810, 73);
            lblProfitPercentage.Name = "lblProfitPercentage";
            lblProfitPercentage.Size = new Size(71, 20);
            lblProfitPercentage.TabIndex = 0;
            lblProfitPercentage.Text = "Kar Oranı";
            // 
            // txtJobNo
            // 
            txtJobNo.Location = new Point(104, 37);
            txtJobNo.Name = "txtJobNo";
            txtJobNo.Size = new Size(250, 27);
            txtJobNo.TabIndex = 0;
            txtJobNo.TextChanged += Changed;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Location = new Point(810, 40);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(31, 20);
            lblProfit.TabIndex = 0;
            lblProfit.Text = "Kar";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(6, 106);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(92, 20);
            lblIssueDate.TabIndex = 2;
            lblIssueDate.Text = "Sipariş Tarihi";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(513, 73);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(112, 20);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "Toplam Maliyet";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(6, 73);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(35, 20);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Cari";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(513, 40);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(97, 20);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "Toplam Tutar";
            // 
            // lblJobNo
            // 
            lblJobNo.AutoSize = true;
            lblJobNo.Location = new Point(6, 40);
            lblJobNo.Name = "lblJobNo";
            lblJobNo.Size = new Size(77, 20);
            lblJobNo.TabIndex = 0;
            lblJobNo.Text = "Sipariş No";
            // 
            // FormOrderAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 498);
            Controls.Add(gbOrder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormOrderAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Detayı";
            Shown += FormOrderAddEdit_Shown;
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            gbOrderDetails.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrder;
        private DateTimePicker dtpIssueDate;
        private TextBox txtCustomer;
        private TextBox txtJobNo;
        private Label lblIssueDate;
        private Label lblCustomer;
        private Label lblJobNo;
        private GroupBox gbOrderDetails;
        private ListView lvOrderDetails;
        private ColumnHeader clmProductName;
        private ColumnHeader clmType;
        private ColumnHeader clmQuantity;
        private ColumnHeader clmUnitCode;
        private ColumnHeader clmUnitPrice;
        private ColumnHeader clmUnitCost;
        private ColumnHeader clmProfit;
        private ColumnHeader clmProfitPercentage;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private TextBox txtTotalCost;
        private Label lblTotalCost;
        private TextBox txtProfitPercentage;
        private TextBox txtProfit;
        private Label lblProfitPercentage;
        private Label lblProfit;
        private Button btnDeleteOrderDetail;
        private Button btnEditOrderDetail;
        private Button btnAddOrderDetail;
        private Label lblTotalCount;
        private TextBox txtTotalCount;
        private Label lblTotalProduced;
        private TextBox txtTotalProduced;
        private Button btnCancel;
        private Button btnSaveChanges;
    }
}