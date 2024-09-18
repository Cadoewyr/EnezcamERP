namespace EnezcamERP.Forms.Product_Specs_Forms
{
    partial class ProductSpecs
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
            lvProductSpecs = new ListView();
            clmSpecName = new ColumnHeader();
            btnAddSpec = new Button();
            btnUpdateSpec = new Button();
            btnDeleteSpec = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lvProductSpecs
            // 
            lvProductSpecs.Columns.AddRange(new ColumnHeader[] { clmSpecName });
            lvProductSpecs.FullRowSelect = true;
            lvProductSpecs.GridLines = true;
            lvProductSpecs.Location = new Point(12, 12);
            lvProductSpecs.Name = "lvProductSpecs";
            lvProductSpecs.Size = new Size(395, 459);
            lvProductSpecs.TabIndex = 0;
            lvProductSpecs.UseCompatibleStateImageBehavior = false;
            lvProductSpecs.View = View.Details;
            lvProductSpecs.KeyDown += lvProductSpecs_KeyDown;
            // 
            // clmSpecName
            // 
            clmSpecName.Text = "Ürün Özelliği Adı";
            // 
            // btnAddSpec
            // 
            btnAddSpec.Location = new Point(12, 477);
            btnAddSpec.Name = "btnAddSpec";
            btnAddSpec.Size = new Size(94, 29);
            btnAddSpec.TabIndex = 1;
            btnAddSpec.Text = "Ekle";
            btnAddSpec.UseVisualStyleBackColor = true;
            btnAddSpec.Click += btnAddSpec_Click;
            // 
            // btnUpdateSpec
            // 
            btnUpdateSpec.Location = new Point(112, 477);
            btnUpdateSpec.Name = "btnUpdateSpec";
            btnUpdateSpec.Size = new Size(94, 29);
            btnUpdateSpec.TabIndex = 2;
            btnUpdateSpec.Text = "Güncelle";
            btnUpdateSpec.UseVisualStyleBackColor = true;
            btnUpdateSpec.Click += btnUpdateSpec_Click;
            // 
            // btnDeleteSpec
            // 
            btnDeleteSpec.Location = new Point(212, 477);
            btnDeleteSpec.Name = "btnDeleteSpec";
            btnDeleteSpec.Size = new Size(94, 29);
            btnDeleteSpec.TabIndex = 3;
            btnDeleteSpec.Text = "Sil";
            btnDeleteSpec.UseVisualStyleBackColor = true;
            btnDeleteSpec.Click += btnDeleteSpec_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(312, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductSpecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(419, 516);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteSpec);
            Controls.Add(btnUpdateSpec);
            Controls.Add(btnAddSpec);
            Controls.Add(lvProductSpecs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductSpecs";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Özellikleri";
            Load += ProductSpecs_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvProductSpecs;
        private Button btnAddSpec;
        private Button btnUpdateSpec;
        private Button btnDeleteSpec;
        private ColumnHeader clmSpecName;
        private Button btnCancel;
    }
}