namespace EnezcamERP.Forms.Report_Forms
{
    partial class SpecQuantities
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
            dgSpecQuantities = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSpecQuantities).BeginInit();
            SuspendLayout();
            // 
            // dgSpecQuantities
            // 
            dgSpecQuantities.AllowUserToAddRows = false;
            dgSpecQuantities.AllowUserToDeleteRows = false;
            dgSpecQuantities.AllowUserToOrderColumns = true;
            dgSpecQuantities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSpecQuantities.Dock = DockStyle.Fill;
            dgSpecQuantities.Location = new Point(0, 0);
            dgSpecQuantities.Name = "dgSpecQuantities";
            dgSpecQuantities.ReadOnly = true;
            dgSpecQuantities.RowHeadersWidth = 51;
            dgSpecQuantities.Size = new Size(564, 368);
            dgSpecQuantities.TabIndex = 0;
            // 
            // SpecQuantities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 368);
            Controls.Add(dgSpecQuantities);
            Name = "SpecQuantities";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgSpecQuantities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgSpecQuantities;
    }
}