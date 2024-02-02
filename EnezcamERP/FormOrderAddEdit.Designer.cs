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
            gbOrderDetails = new GroupBox();
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
            txtTotalCost = new TextBox();
            txtTotalPrice = new TextBox();
            lblProfitPercentage = new Label();
            txtJobNo = new TextBox();
            lblProfit = new Label();
            label1 = new Label();
            lblTotalCost = new Label();
            lblCustomer = new Label();
            lblTotalPrice = new Label();
            lblJobNo = new Label();
            btnAddOrderDetail = new Button();
            btnEditOrderDetail = new Button();
            btnDeleteOrderDetail = new Button();
            gbOrder.SuspendLayout();
            gbOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(gbOrderDetails);
            gbOrder.Controls.Add(dtpIssueDate);
            gbOrder.Controls.Add(txtCustomer);
            gbOrder.Controls.Add(txtProfitPercentage);
            gbOrder.Controls.Add(txtProfit);
            gbOrder.Controls.Add(txtTotalCost);
            gbOrder.Controls.Add(txtTotalPrice);
            gbOrder.Controls.Add(lblProfitPercentage);
            gbOrder.Controls.Add(txtJobNo);
            gbOrder.Controls.Add(lblProfit);
            gbOrder.Controls.Add(label1);
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
            // gbOrderDetails
            // 
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
            // lvOrderDetails
            // 
            lvOrderDetails.Columns.AddRange(new ColumnHeader[] { clmProductName, clmType, clmQuantity, clmUnitCode, clmUnitPrice, clmUnitCost, clmProfit, clmProfitPercentage });
            lvOrderDetails.Location = new Point(6, 64);
            lvOrderDetails.Name = "lvOrderDetails";
            lvOrderDetails.Size = new Size(1139, 262);
            lvOrderDetails.TabIndex = 0;
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
            dtpIssueDate.TabIndex = 5;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(104, 70);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(250, 27);
            txtCustomer.TabIndex = 4;
            // 
            // txtProfitPercentage
            // 
            txtProfitPercentage.Location = new Point(887, 70);
            txtProfitPercentage.Name = "txtProfitPercentage";
            txtProfitPercentage.Size = new Size(158, 27);
            txtProfitPercentage.TabIndex = 3;
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(887, 37);
            txtProfit.Name = "txtProfit";
            txtProfit.Size = new Size(158, 27);
            txtProfit.TabIndex = 3;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(557, 70);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(158, 27);
            txtTotalCost.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(557, 37);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(158, 27);
            txtTotalPrice.TabIndex = 3;
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
            txtJobNo.TabIndex = 3;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Location = new Point(810, 40);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(31, 20);
            lblProfit.TabIndex = 0;
            lblProfit.Text = "Kar";
            lblProfit.Click += lblTotalCost_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 103);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "Sipariş Tarihi";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(439, 73);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(112, 20);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "Toplam Maliyet";
            lblTotalCost.Click += lblTotalCost_Click;
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
            lblTotalPrice.Location = new Point(439, 40);
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
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.Location = new Point(6, 29);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(94, 29);
            btnAddOrderDetail.TabIndex = 1;
            btnAddOrderDetail.Text = "Ekle";
            btnAddOrderDetail.UseVisualStyleBackColor = true;
            // 
            // btnEditOrderDetail
            // 
            btnEditOrderDetail.Location = new Point(106, 29);
            btnEditOrderDetail.Name = "btnEditOrderDetail";
            btnEditOrderDetail.Size = new Size(94, 29);
            btnEditOrderDetail.TabIndex = 1;
            btnEditOrderDetail.Text = "Düzenle";
            btnEditOrderDetail.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.Location = new Point(206, 29);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(94, 29);
            btnDeleteOrderDetail.TabIndex = 1;
            btnDeleteOrderDetail.Text = "Sil";
            btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            // 
            // FormOrderAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 498);
            Controls.Add(gbOrder);
            Name = "FormOrderAddEdit";
            Text = "Order Details";
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
        private Label label1;
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
    }
}