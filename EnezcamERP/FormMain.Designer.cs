namespace EnezcamERP
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            gbOrders = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lvOrders = new ListView();
            clmJobNo = new ColumnHeader();
            clmCustomer = new ColumnHeader();
            clmIssueDate = new ColumnHeader();
            clmCount = new ColumnHeader();
            clmProducedCount = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmProducedPrice = new ColumnHeader();
            clmCost = new ColumnHeader();
            clmProducedCost = new ColumnHeader();
            clmProfit = new ColumnHeader();
            clmProfitPercentage = new ColumnHeader();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            gbProducts = new GroupBox();
            lvProducts = new ListView();
            tabPage1.SuspendLayout();
            gbOrders.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            gbProducts.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gbOrders);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(944, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Siparişler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbOrders
            // 
            gbOrders.Controls.Add(btnDelete);
            gbOrders.Controls.Add(btnEdit);
            gbOrders.Controls.Add(btnAdd);
            gbOrders.Controls.Add(lvOrders);
            gbOrders.Dock = DockStyle.Fill;
            gbOrders.Location = new Point(3, 3);
            gbOrders.Name = "gbOrders";
            gbOrders.Size = new Size(938, 484);
            gbOrders.TabIndex = 0;
            gbOrders.TabStop = false;
            gbOrders.Text = "Siparişler";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(206, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(106, 28);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lvOrders
            // 
            lvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrders.Columns.AddRange(new ColumnHeader[] { clmJobNo, clmCustomer, clmIssueDate, clmCount, clmProducedCount, clmPrice, clmProducedPrice, clmCost, clmProducedCost, clmProfit, clmProfitPercentage });
            lvOrders.Location = new Point(3, 63);
            lvOrders.MultiSelect = false;
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(932, 418);
            lvOrders.TabIndex = 4;
            lvOrders.UseCompatibleStateImageBehavior = false;
            lvOrders.View = View.Details;
            // 
            // clmJobNo
            // 
            clmJobNo.Text = "Evrak No";
            // 
            // clmCustomer
            // 
            clmCustomer.Text = "Cari";
            // 
            // clmIssueDate
            // 
            clmIssueDate.Text = "Sipariş Tarihi";
            // 
            // clmCount
            // 
            clmCount.Text = "Sipariş Adedi";
            // 
            // clmProducedCount
            // 
            clmProducedCount.Text = "Üretim";
            // 
            // clmPrice
            // 
            clmPrice.Text = "Tutar";
            // 
            // clmProducedPrice
            // 
            clmProducedPrice.Text = "Üretim Tutarı";
            // 
            // clmCost
            // 
            clmCost.Text = "Maliyet";
            // 
            // clmProducedCost
            // 
            clmProducedCost.Text = "Üretim Maliyeti";
            // 
            // clmProfit
            // 
            clmProfit.Text = "Kar";
            // 
            // clmProfitPercentage
            // 
            clmProfitPercentage.Text = "Üretim Karı";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(952, 523);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gbProducts);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(944, 490);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stok Kartı";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbProducts
            // 
            gbProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProducts.Controls.Add(lvProducts);
            gbProducts.Location = new Point(6, 6);
            gbProducts.Name = "gbProducts";
            gbProducts.Size = new Size(930, 476);
            gbProducts.TabIndex = 0;
            gbProducts.TabStop = false;
            gbProducts.Text = "Stok Kartları";
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Location = new Point(6, 26);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(918, 332);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 523);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(970, 570);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enezcam ERP";
            Load += Main_Load;
            tabPage1.ResumeLayout(false);
            gbOrders.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            gbProducts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private GroupBox gbOrders;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ListView lvOrders;
        private ColumnHeader clmJobNo;
        private ColumnHeader clmCustomer;
        private ColumnHeader clmIssueDate;
        private ColumnHeader clmCount;
        private ColumnHeader clmProducedCount;
        private ColumnHeader clmPrice;
        private ColumnHeader clmProducedPrice;
        private ColumnHeader clmCost;
        private ColumnHeader clmProducedCost;
        private ColumnHeader clmProfit;
        private ColumnHeader clmProfitPercentage;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox gbProducts;
        private ListView lvProducts;
    }
}
