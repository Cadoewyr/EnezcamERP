namespace EnezcamERP.Forms.Customer_Forms
{
    partial class UpdateCustomer
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
            btnCancel = new Button();
            btnUpdateCustomer = new Button();
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
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnUpdateCustomer);
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
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cari Bilgileri";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(181, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(223, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Enabled = false;
            btnUpdateCustomer.Location = new Point(181, 364);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(224, 29);
            btnUpdateCustomer.TabIndex = 7;
            btnUpdateCustomer.Text = "Kaydet";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // txtContactPhone
            // 
            txtContactPhone.Location = new Point(181, 328);
            txtContactPhone.Mask = "(999) 000-0000";
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.Size = new Size(223, 27);
            txtContactPhone.TabIndex = 6;
            txtContactPhone.TextChanged += ControlTextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(181, 213);
            txtDescription.MaxLength = 300;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(345, 75);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            txtDescription.TextChanged += ControlTextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(181, 133);
            txtAddress.MaxLength = 300;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(345, 75);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "";
            txtAddress.TextChanged += ControlTextChanged;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(181, 295);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(223, 27);
            txtContactName.TabIndex = 5;
            txtContactName.TextChanged += ControlTextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(181, 100);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(223, 27);
            txtCity.TabIndex = 2;
            txtCity.TextChanged += ControlTextChanged;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(181, 67);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(223, 27);
            txtCountry.TabIndex = 1;
            txtCountry.TextChanged += ControlTextChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(181, 35);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(223, 27);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += ControlTextChanged;
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
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(6, 299);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(48, 20);
            lblContactName.TabIndex = 0;
            lblContactName.Text = "Yetkili";
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
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(6, 136);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(47, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Adres";
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
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(6, 69);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(38, 20);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Ülke";
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
            // UpdateCustomer
            // 
            AcceptButton = btnUpdateCustomer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(560, 472);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UpdateCustomer";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cari Ekle";
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
        private Button btnUpdateCustomer;
        private Button btnCancel;
    }
}