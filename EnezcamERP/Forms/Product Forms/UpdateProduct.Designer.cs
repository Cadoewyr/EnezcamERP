namespace EnezcamERP.Forms.Product_Forms
{
    partial class UpdateProduct
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
            gbProduct = new GroupBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            cbProductType = new ComboBox();
            lblProductType = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            gbProduct.SuspendLayout();
            SuspendLayout();
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(btnCancel);
            gbProduct.Controls.Add(btnUpdate);
            gbProduct.Controls.Add(cbProductType);
            gbProduct.Controls.Add(lblProductType);
            gbProduct.Controls.Add(txtProductName);
            gbProduct.Controls.Add(lblProductName);
            gbProduct.Location = new Point(12, 12);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(270, 191);
            gbProduct.TabIndex = 1;
            gbProduct.TabStop = false;
            gbProduct.Text = "Ürün Bilgileri";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(111, 146);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(111, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Kaydet";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbProductType
            // 
            cbProductType.FormattingEnabled = true;
            cbProductType.Location = new Point(111, 77);
            cbProductType.Name = "cbProductType";
            cbProductType.Size = new Size(153, 28);
            cbProductType.TabIndex = 1;
            cbProductType.TextChanged += ControlTextChanged;
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(6, 80);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(69, 20);
            lblProductType.TabIndex = 0;
            lblProductType.Text = "Ürün Tipi";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(111, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(153, 27);
            txtProductName.TabIndex = 0;
            txtProductName.TextChanged += ControlTextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 47);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(67, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Ürün Adı";
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 214);
            Controls.Add(gbProduct);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UpdateProduct";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Güncelle";
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProduct;
        private Button btnCancel;
        private Button btnUpdate;
        private ComboBox cbProductType;
        private Label lblProductType;
        private TextBox txtProductName;
        private Label lblProductName;
    }
}