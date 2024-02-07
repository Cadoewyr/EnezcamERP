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
            lblCustomerName = new Label();
            lblCountry = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            lblDescription = new Label();
            lblContactName = new Label();
            lblContactPhone = new Label();
            txtCustomerName = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtAddress = new RichTextBox();
            txtDescription = new RichTextBox();
            txtContactName = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            btnAddCustomer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(maskedTextBox1);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cari Bilgileri";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(6, 37);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(62, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Cari Adı";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(6, 70);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(38, 20);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Ülke";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(6, 103);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 20);
            lblCity.TabIndex = 0;
            lblCity.Text = "Şehir";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(6, 136);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(47, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Adres";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 217);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 20);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Açıklama";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(6, 298);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(48, 20);
            lblContactName.TabIndex = 0;
            lblContactName.Text = "Yetkili";
            // 
            // lblContactPhone
            // 
            lblContactPhone.AutoSize = true;
            lblContactPhone.Location = new Point(6, 331);
            lblContactPhone.Name = "lblContactPhone";
            lblContactPhone.Size = new Size(168, 20);
            lblContactPhone.TabIndex = 0;
            lblContactPhone.Text = "Yetkili Telefon Numarası";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(180, 34);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(223, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(180, 67);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(223, 27);
            txtCountry.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(180, 100);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(223, 27);
            txtCity.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(180, 133);
            txtAddress.MaxLength = 300;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(344, 75);
            txtAddress.TabIndex = 2;
            txtAddress.Text = "";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(180, 214);
            txtDescription.MaxLength = 300;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(344, 75);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(180, 295);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(223, 27);
            txtContactName.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(180, 328);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(223, 27);
            maskedTextBox1.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.None;
            btnAddCustomer.Location = new Point(220, 380);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(94, 29);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Ekle";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private MaskedTextBox maskedTextBox1;
        private RichTextBox txtDescription;
        private RichTextBox txtAddress;
        private TextBox txtContactName;
        private Button btnAddCustomer;
    }
}