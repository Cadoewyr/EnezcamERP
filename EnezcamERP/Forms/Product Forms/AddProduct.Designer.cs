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
            lblCode = new Label();
            cbIsCounting = new CheckBox();
            btnCancel = new Button();
            btnAdd = new Button();
            cbProcessTypes = new ComboBox();
            lblProductType = new Label();
            txtCode = new TextBox();
            txtProductName = new TextBox();
            lblProductName = new Label();
            gbProduct.SuspendLayout();
            SuspendLayout();
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(lblCode);
            gbProduct.Controls.Add(cbIsCounting);
            gbProduct.Controls.Add(btnCancel);
            gbProduct.Controls.Add(btnAdd);
            gbProduct.Controls.Add(cbProcessTypes);
            gbProduct.Controls.Add(lblProductType);
            gbProduct.Controls.Add(txtCode);
            gbProduct.Controls.Add(txtProductName);
            gbProduct.Controls.Add(lblProductName);
            gbProduct.Location = new Point(11, 12);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(270, 222);
            gbProduct.TabIndex = 1;
            gbProduct.TabStop = false;
            gbProduct.Text = "Ürün Bilgileri";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(6, 80);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(79, 20);
            lblCode.TabIndex = 5;
            lblCode.Text = "Ürün Kodu";
            // 
            // cbIsCounting
            // 
            cbIsCounting.AutoSize = true;
            cbIsCounting.Location = new Point(6, 147);
            cbIsCounting.Name = "cbIsCounting";
            cbIsCounting.Size = new Size(90, 24);
            cbIsCounting.TabIndex = 3;
            cbIsCounting.Text = "Adet Say";
            cbIsCounting.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(111, 179);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(111, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbProcessTypes
            // 
            cbProcessTypes.FormattingEnabled = true;
            cbProcessTypes.Location = new Point(111, 110);
            cbProcessTypes.Name = "cbProcessTypes";
            cbProcessTypes.Size = new Size(153, 28);
            cbProcessTypes.TabIndex = 2;
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(6, 113);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(73, 20);
            lblProductType.TabIndex = 0;
            lblProductType.Text = "İşlem Tipi";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(111, 77);
            txtCode.MaxLength = 200;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(153, 27);
            txtCode.TabIndex = 1;
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
            // AddProduct
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(294, 246);
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
        private Label lblCode;
        private TextBox txtCode;
    }
}