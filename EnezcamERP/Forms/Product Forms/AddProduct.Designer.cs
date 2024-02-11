namespace EnezcamERP.Forms.Product_Forms
{
    partial class AddProduct
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
            btnAdd = new Button();
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
            gbProduct.Controls.Add(btnAdd);
            gbProduct.Controls.Add(cbProductType);
            gbProduct.Controls.Add(lblProductType);
            gbProduct.Controls.Add(txtProductName);
            gbProduct.Controls.Add(lblProductName);
            gbProduct.Location = new Point(10, 9);
            gbProduct.Margin = new Padding(3, 2, 3, 2);
            gbProduct.Name = "gbProduct";
            gbProduct.Padding = new Padding(3, 2, 3, 2);
            gbProduct.Size = new Size(236, 143);
            gbProduct.TabIndex = 1;
            gbProduct.TabStop = false;
            gbProduct.Text = "Ürün Bilgileri";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(97, 110);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 22);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 83);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 22);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbProductType
            // 
            cbProductType.FormattingEnabled = true;
            cbProductType.Location = new Point(97, 58);
            cbProductType.Margin = new Padding(3, 2, 3, 2);
            cbProductType.Name = "cbProductType";
            cbProductType.Size = new Size(134, 23);
            cbProductType.TabIndex = 1;
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(5, 60);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(55, 15);
            lblProductType.TabIndex = 0;
            lblProductType.Text = "Ürün Tipi";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(97, 33);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(134, 23);
            txtProductName.TabIndex = 0;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(5, 35);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(54, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Ürün Adı";
            // 
            // AddProduct
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(257, 160);
            Controls.Add(gbProduct);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddProduct";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProduct;
        private Button btnCancel;
        private Button btnAdd;
        private ComboBox cbProductType;
        private Label lblProductType;
        private TextBox txtProductName;
        private Label lblProductName;
    }
}