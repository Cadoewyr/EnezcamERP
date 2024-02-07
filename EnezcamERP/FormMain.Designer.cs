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
            btnDeleteOrder = new Button();
            btnUpdateOrder = new Button();
            btnAddOrder = new Button();
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
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            lvProducts = new ListView();
            tabPage3 = new TabPage();
            gbCustomers = new GroupBox();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddCustomer = new Button();
            lvCustomers = new ListView();
            tabPage1.SuspendLayout();
            gbOrders.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            gbProducts.SuspendLayout();
            tabPage3.SuspendLayout();
            gbCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gbOrders);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(827, 370);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Siparişler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbOrders
            // 
            gbOrders.Controls.Add(btnDeleteOrder);
            gbOrders.Controls.Add(btnUpdateOrder);
            gbOrders.Controls.Add(btnAddOrder);
            gbOrders.Controls.Add(lvOrders);
            gbOrders.Dock = DockStyle.Fill;
            gbOrders.Location = new Point(3, 2);
            gbOrders.Margin = new Padding(3, 2, 3, 2);
            gbOrders.Name = "gbOrders";
            gbOrders.Padding = new Padding(3, 2, 3, 2);
            gbOrders.Size = new Size(821, 366);
            gbOrders.TabIndex = 0;
            gbOrders.TabStop = false;
            gbOrders.Text = "Siparişler";
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(180, 21);
            btnDeleteOrder.Margin = new Padding(3, 2, 3, 2);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(82, 22);
            btnDeleteOrder.TabIndex = 3;
            btnDeleteOrder.Text = "Sil";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Location = new Point(93, 21);
            btnUpdateOrder.Margin = new Padding(3, 2, 3, 2);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(82, 22);
            btnUpdateOrder.TabIndex = 2;
            btnUpdateOrder.Text = "Düzenle";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(5, 21);
            btnAddOrder.Margin = new Padding(3, 2, 3, 2);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(82, 22);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lvOrders
            // 
            lvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrders.Columns.AddRange(new ColumnHeader[] { clmJobNo, clmCustomer, clmIssueDate, clmCount, clmProducedCount, clmPrice, clmProducedPrice, clmCost, clmProducedCost, clmProfit, clmProfitPercentage });
            lvOrders.Location = new Point(3, 47);
            lvOrders.Margin = new Padding(3, 2, 3, 2);
            lvOrders.MultiSelect = false;
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(816, 317);
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
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(835, 398);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gbProducts);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(827, 370);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stok Kartı";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbProducts
            // 
            gbProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProducts.Controls.Add(btnDeleteProduct);
            gbProducts.Controls.Add(btnUpdateProduct);
            gbProducts.Controls.Add(btnAddProduct);
            gbProducts.Controls.Add(lvProducts);
            gbProducts.Location = new Point(5, 4);
            gbProducts.Margin = new Padding(3, 2, 3, 2);
            gbProducts.Name = "gbProducts";
            gbProducts.Padding = new Padding(3, 2, 3, 2);
            gbProducts.Size = new Size(816, 363);
            gbProducts.TabIndex = 0;
            gbProducts.TabStop = false;
            gbProducts.Text = "Stok Kartları";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteProduct.Location = new Point(181, 280);
            btnDeleteProduct.Margin = new Padding(3, 2, 3, 2);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(82, 22);
            btnDeleteProduct.TabIndex = 1;
            btnDeleteProduct.Text = "Sil";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateProduct.Location = new Point(94, 280);
            btnUpdateProduct.Margin = new Padding(3, 2, 3, 2);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(82, 22);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddProduct.Location = new Point(6, 280);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(82, 22);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Location = new Point(5, 20);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(806, 256);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(gbCustomers);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(827, 370);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cari Kartı";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbCustomers
            // 
            gbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomers.Controls.Add(btnDeleteCustomer);
            gbCustomers.Controls.Add(btnUpdateCustomer);
            gbCustomers.Controls.Add(btnAddCustomer);
            gbCustomers.Controls.Add(lvCustomers);
            gbCustomers.Location = new Point(5, 4);
            gbCustomers.Margin = new Padding(3, 2, 3, 2);
            gbCustomers.Name = "gbCustomers";
            gbCustomers.Padding = new Padding(3, 2, 3, 2);
            gbCustomers.Size = new Size(816, 363);
            gbCustomers.TabIndex = 0;
            gbCustomers.TabStop = false;
            gbCustomers.Text = "Cariler";
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteCustomer.Location = new Point(181, 280);
            btnDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(82, 22);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Sil";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateCustomer.Location = new Point(94, 280);
            btnUpdateCustomer.Margin = new Padding(3, 2, 3, 2);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(82, 22);
            btnUpdateCustomer.TabIndex = 3;
            btnUpdateCustomer.Text = "Güncelle";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCustomer.Location = new Point(6, 280);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(82, 22);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Ekle";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lvCustomers
            // 
            lvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvCustomers.Location = new Point(5, 20);
            lvCustomers.Margin = new Padding(3, 2, 3, 2);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(806, 256);
            lvCustomers.TabIndex = 0;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 398);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(851, 437);
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
            tabPage3.ResumeLayout(false);
            gbCustomers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private GroupBox gbOrders;
        private Button btnDeleteOrder;
        private Button btnUpdateOrder;
        private Button btnAddOrder;
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
        private TabPage tabPage3;
        private GroupBox gbCustomers;
        private ListView lvCustomers;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Button btnAddCustomer;
    }
}
