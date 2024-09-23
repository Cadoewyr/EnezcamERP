namespace EnezcamERP.Forms.ColumnSettings
{
    partial class ColumnSettingsForm
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
            cbColumnSettings = new CheckedListBox();
            btnSave = new Button();
            cbCheckAll = new CheckBox();
            SuspendLayout();
            // 
            // cbColumnSettings
            // 
            cbColumnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbColumnSettings.FormattingEnabled = true;
            cbColumnSettings.Location = new Point(0, 44);
            cbColumnSettings.Name = "cbColumnSettings";
            cbColumnSettings.Size = new Size(310, 422);
            cbColumnSettings.TabIndex = 1;
            cbColumnSettings.ItemCheck += cbColumnSettings_ItemCheck;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(12, 472);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbCheckAll
            // 
            cbCheckAll.AutoSize = true;
            cbCheckAll.Location = new Point(3, 12);
            cbCheckAll.Name = "cbCheckAll";
            cbCheckAll.Size = new Size(136, 24);
            cbCheckAll.TabIndex = 0;
            cbCheckAll.Text = "Tümünü İşaretle";
            cbCheckAll.UseVisualStyleBackColor = true;
            cbCheckAll.CheckedChanged += cbCheckAll_CheckedChanged;
            // 
            // ColumnSettingsForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 509);
            Controls.Add(cbCheckAll);
            Controls.Add(btnSave);
            Controls.Add(cbColumnSettings);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(328, 556);
            Name = "ColumnSettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sütun Ayarları";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox cbColumnSettings;
        private Button btnSave;
        private CheckBox cbCheckAll;
    }
}