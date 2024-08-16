namespace EnezcamERP.Forms.Order_Forms
{
    partial class OrderDetailSpecs
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
            btnSave = new Button();
            lvOrderDetailsSpecs = new ListView();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 528);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(327, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lvOrderDetailsSpecs
            // 
            lvOrderDetailsSpecs.CheckBoxes = true;
            lvOrderDetailsSpecs.FullRowSelect = true;
            lvOrderDetailsSpecs.Location = new Point(12, 12);
            lvOrderDetailsSpecs.Name = "lvOrderDetailsSpecs";
            lvOrderDetailsSpecs.Size = new Size(327, 510);
            lvOrderDetailsSpecs.TabIndex = 1;
            lvOrderDetailsSpecs.UseCompatibleStateImageBehavior = false;
            lvOrderDetailsSpecs.View = View.List;
            lvOrderDetailsSpecs.ItemChecked += lvOrderDetailsSpecs_ItemChecked;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 563);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(327, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Kapat";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // OrderDetailSpecs
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(354, 600);
            Controls.Add(btnCancel);
            Controls.Add(lvOrderDetailsSpecs);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "OrderDetailSpecs";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Özellikleri";
            Load += OrderDetailSpecs_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private ListView lvOrderDetailsSpecs;
        private Button btnCancel;
    }
}