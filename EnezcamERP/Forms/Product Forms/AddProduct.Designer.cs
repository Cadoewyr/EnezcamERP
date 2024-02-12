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
            cbProcessTypes = new ComboBox();
            lblProductType = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            cbIsCounting = new CheckBox();
            gbProduct.SuspendLayout();
            SuspendLayout();
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(cbIsCounting);
            gbProduct.Controls.Add(btnCancel);
            gbProduct.Controls.Add(btnAdd);
            gbProduct.Controls.Add(cbProcessTypes);
            gbProduct.Controls.Add(lblProductType);
            gbProduct.Controls.Add(txtProductName);
            gbProduct.Controls.Add(lblProductName);
            gbProduct.Location = new Point(11, 12);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(270, 193);
            gbProduct.TabIndex = 1;
            gbProduct.TabStop = false;
            gbProduct.Text = "Ürün Bilgileri";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(111, 147);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(111, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbProcessTypes
            // 
            cbProcessTypes.FormattingEnabled = true;
            cbProcessTypes.Location = new Point(111, 77);
            cbProcessTypes.Name = "cbProcessTypes";
            cbProcessTypes.Size = new Size(153, 28);
            cbProcessTypes.TabIndex = 1;
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(6, 80);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(73, 20);
            lblProductType.TabIndex = 0;
            lblProductType.Text = "İşlem Tipi";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(111, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(153, 27);
            txtProductName.TabIndex = 0;
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
            // cbIsCounting
            // 
            cbIsCounting.AutoSize = true;
            cbIsCounting.Location = new Point(6, 114);
            cbIsCounting.Name = "cbIsCounting";
            cbIsCounting.Size = new Size(90, 24);
            cbIsCounting.TabIndex = 2;
            cbIsCounting.Text = "Adet Say";
            cbIsCounting.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(294, 217);
            Controls.Add(gbProduct);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private ComboBox cbProcessTypes;
        private Label lblProductType;
        private TextBox txtProductName;
        private Label lblProductName;
        private CheckBox cbIsCounting;
    }
}