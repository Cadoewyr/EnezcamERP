namespace EnezcamERP.Forms.Product_Specs_Forms
{
    partial class AddUpdateProductSpec
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
            lblSpecName = new Label();
            txtSpecName = new TextBox();
            btnAddUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblSpecName
            // 
            lblSpecName.AutoSize = true;
            lblSpecName.Location = new Point(12, 9);
            lblSpecName.Name = "lblSpecName";
            lblSpecName.Size = new Size(122, 20);
            lblSpecName.TabIndex = 0;
            lblSpecName.Text = "Ürün Özelliği Adı";
            // 
            // txtSpecName
            // 
            txtSpecName.Location = new Point(12, 32);
            txtSpecName.Name = "txtSpecName";
            txtSpecName.Size = new Size(249, 27);
            txtSpecName.TabIndex = 1;
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Location = new Point(12, 65);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(249, 29);
            btnAddUpdate.TabIndex = 2;
            btnAddUpdate.UseVisualStyleBackColor = true;
            btnAddUpdate.Click += btnAddUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(249, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddUpdateProductSpec
            // 
            AcceptButton = btnAddUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(274, 138);
            Controls.Add(btnCancel);
            Controls.Add(btnAddUpdate);
            Controls.Add(txtSpecName);
            Controls.Add(lblSpecName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUpdateProductSpec";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSpecName;
        private TextBox txtSpecName;
        private Button btnAddUpdate;
        private Button btnCancel;
    }
}