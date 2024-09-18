namespace EnezcamERP.Forms.Order_Forms
{
    partial class Fire
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
            lblWidth = new Label();
            lblHeight = new Label();
            nudWidth = new NumericUpDown();
            nudHeight = new NumericUpDown();
            btnCalculate = new Button();
            gbPaint = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(12, 9);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(60, 20);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Genişlik";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 71);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(68, 20);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Yükseklik";
            // 
            // nudWidth
            // 
            nudWidth.Location = new Point(12, 32);
            nudWidth.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(118, 27);
            nudWidth.TabIndex = 0;
            nudWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(12, 94);
            nudHeight.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(118, 27);
            nudHeight.TabIndex = 1;
            nudHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 127);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(118, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // gbPaint
            // 
            gbPaint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPaint.Location = new Point(136, 12);
            gbPaint.Name = "gbPaint";
            gbPaint.Size = new Size(600, 599);
            gbPaint.TabIndex = 4;
            gbPaint.TabStop = false;
            // 
            // Fire
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 623);
            Controls.Add(gbPaint);
            Controls.Add(btnCalculate);
            Controls.Add(nudHeight);
            Controls.Add(nudWidth);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            MinimizeBox = false;
            Name = "Fire";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fire";
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWidth;
        private Label lblHeight;
        private NumericUpDown nudWidth;
        private NumericUpDown nudHeight;
        private Button btnCalculate;
        private GroupBox gbPaint;
    }
}