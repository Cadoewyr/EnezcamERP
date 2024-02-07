namespace EnezcamERP.Forms.Customer_Forms
{
    partial class AddCustomer
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
            groupBox1 = new GroupBox();
            btnAddCustomer = new Button();
            txtContactPhone = new MaskedTextBox();
            txtDescription = new RichTextBox();
            txtAddress = new RichTextBox();
            txtContactName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtCustomerName = new TextBox();
            lblContactPhone = new Label();
            lblContactName = new Label();
            lblDescription = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblCustomerName = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(txtContactPhone);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtContactName);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtCountry);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(lblContactPhone);
            groupBox1.Controls.Add(lblContactName);
            groupBox1.Controls.Add(lblDescription);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(lblCustomerName);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(468, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cari Bilgileri";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(158, 273);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(196, 22);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Ekle";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // txtContactPhone
            // 
            txtContactPhone.Location = new Point(158, 246);
            txtContactPhone.Margin = new Padding(3, 2, 3, 2);
            txtContactPhone.Mask = "(999) 000-0000";
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.Size = new Size(196, 23);
            txtContactPhone.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(158, 160);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.MaxLength = 300;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(302, 57);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 100);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.MaxLength = 300;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(302, 57);
            txtAddress.TabIndex = 2;
            txtAddress.Text = "";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(158, 221);
            txtContactName.Margin = new Padding(3, 2, 3, 2);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(196, 23);
            txtContactName.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(158, 75);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(196, 23);
            txtCity.TabIndex = 1;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(158, 50);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(196, 23);
            txtCountry.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(158, 26);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(196, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblContactPhone
            // 
            lblContactPhone.AutoSize = true;
            lblContactPhone.Location = new Point(5, 248);
            lblContactPhone.Name = "lblContactPhone";
            lblContactPhone.Size = new Size(133, 15);
            lblContactPhone.TabIndex = 0;
            lblContactPhone.Text = "Yetkili Telefon Numarası";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(5, 224);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(38, 15);
            lblContactName.TabIndex = 0;
            lblContactName.Text = "Yetkili";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(5, 163);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(56, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Açıklama";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(5, 102);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(37, 15);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Adres";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(5, 77);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(33, 15);
            lblCity.TabIndex = 0;
            lblCity.Text = "Şehir";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(5, 52);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(30, 15);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Ülke";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(5, 28);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(49, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Cari Adı";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 323);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddCustomer";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cari Ekle";
            Load += AddCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblCustomerName;
        private Label lblAddress;
        private Label lblCity;
        private Label lblCountry;
        private Label lblContactPhone;
        private Label lblContactName;
        private Label lblDescription;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtCustomerName;
        private MaskedTextBox txtContactPhone;
        private RichTextBox txtDescription;
        private RichTextBox txtAddress;
        private TextBox txtContactName;
        private Button btnAddCustomer;
    }
}