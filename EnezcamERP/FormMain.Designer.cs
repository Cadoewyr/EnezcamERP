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
            tabOrders = new TabPage();
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
            tabControlMain = new TabControl();
            tabStock = new TabPage();
            gbProducts = new GroupBox();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnRefreshStock = new Button();
            btnDeleteProduct = new Button();
            lvProducts = new ListView();
            clmName = new ColumnHeader();
            clmProductType = new ColumnHeader();
            tabCustomer = new TabPage();
            gbCustomers = new GroupBox();
            btnRefreshCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddCustomer = new Button();
            lvCustomers = new ListView();
            clmCustomerName = new ColumnHeader();
            clmCountry = new ColumnHeader();
            clmCity = new ColumnHeader();
            clmDescription = new ColumnHeader();
            clmContactName = new ColumnHeader();
            clmContactPhone = new ColumnHeader();
            txtSearchCustomer = new TextBox();
            lblSearchCustomer = new Label();
            tabOrders.SuspendLayout();
            gbOrders.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabStock.SuspendLayout();
            gbProducts.SuspendLayout();
            tabCustomer.SuspendLayout();
            gbCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(gbOrders);
            tabOrders.Location = new Point(4, 29);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3);
            tabOrders.Size = new Size(946, 498);
            tabOrders.TabIndex = 0;
            tabOrders.Text = "Siparişler";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // gbOrders
            // 
            gbOrders.Controls.Add(btnDeleteOrder);
            gbOrders.Controls.Add(btnUpdateOrder);
            gbOrders.Controls.Add(btnAddOrder);
            gbOrders.Controls.Add(lvOrders);
            gbOrders.Dock = DockStyle.Fill;
            gbOrders.Location = new Point(3, 3);
            gbOrders.Name = "gbOrders";
            gbOrders.Size = new Size(940, 492);
            gbOrders.TabIndex = 0;
            gbOrders.TabStop = false;
            gbOrders.Text = "Siparişler";
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(206, 28);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(94, 29);
            btnDeleteOrder.TabIndex = 3;
            btnDeleteOrder.Text = "Sil";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Location = new Point(106, 28);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(94, 29);
            btnUpdateOrder.TabIndex = 2;
            btnUpdateOrder.Text = "Düzenle";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(6, 28);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(94, 29);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lvOrders
            // 
            lvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrders.Columns.AddRange(new ColumnHeader[] { clmJobNo, clmCustomer, clmIssueDate, clmCount, clmProducedCount, clmPrice, clmProducedPrice, clmCost, clmProducedCost, clmProfit, clmProfitPercentage });
            lvOrders.Location = new Point(3, 63);
            lvOrders.MultiSelect = false;
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(934, 425);
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
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabOrders);
            tabControlMain.Controls.Add(tabStock);
            tabControlMain.Controls.Add(tabCustomer);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(954, 531);
            tabControlMain.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(gbProducts);
            tabStock.Location = new Point(4, 29);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(946, 498);
            tabStock.TabIndex = 1;
            tabStock.Text = "Stok Kartı";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // gbProducts
            // 
            gbProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProducts.Controls.Add(btnAddProduct);
            gbProducts.Controls.Add(btnUpdateProduct);
            gbProducts.Controls.Add(btnRefreshStock);
            gbProducts.Controls.Add(btnDeleteProduct);
            gbProducts.Controls.Add(lvProducts);
            gbProducts.Location = new Point(6, 5);
            gbProducts.Name = "gbProducts";
            gbProducts.Size = new Size(933, 484);
            gbProducts.TabIndex = 0;
            gbProducts.TabStop = false;
            gbProducts.Text = "Stok Kartları";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddProduct.Location = new Point(6, 373);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateProduct.Location = new Point(106, 373);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(94, 29);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnRefreshStock
            // 
            btnRefreshStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefreshStock.Location = new Point(833, 373);
            btnRefreshStock.Name = "btnRefreshStock";
            btnRefreshStock.Size = new Size(94, 29);
            btnRefreshStock.TabIndex = 2;
            btnRefreshStock.Text = "Yenile";
            btnRefreshStock.UseVisualStyleBackColor = true;
            btnRefreshStock.Click += btnRefreshStock_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteProduct.Location = new Point(206, 373);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(94, 29);
            btnDeleteProduct.TabIndex = 1;
            btnDeleteProduct.Text = "Sil";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmName, clmProductType });
            lvProducts.Location = new Point(6, 27);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(921, 340);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // clmName
            // 
            clmName.Text = "Ürün Adı";
            // 
            // clmProductType
            // 
            clmProductType.Text = "Ürün Tipi";
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(gbCustomers);
            tabCustomer.Location = new Point(4, 29);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(946, 498);
            tabCustomer.TabIndex = 2;
            tabCustomer.Text = "Cari Kartı";
            tabCustomer.UseVisualStyleBackColor = true;
            // 
            // gbCustomers
            // 
            gbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomers.Controls.Add(lblSearchCustomer);
            gbCustomers.Controls.Add(txtSearchCustomer);
            gbCustomers.Controls.Add(btnRefreshCustomer);
            gbCustomers.Controls.Add(btnDeleteCustomer);
            gbCustomers.Controls.Add(btnUpdateCustomer);
            gbCustomers.Controls.Add(btnAddCustomer);
            gbCustomers.Controls.Add(lvCustomers);
            gbCustomers.Location = new Point(6, 5);
            gbCustomers.Name = "gbCustomers";
            gbCustomers.Size = new Size(933, 484);
            gbCustomers.TabIndex = 0;
            gbCustomers.TabStop = false;
            gbCustomers.Text = "Cariler";
            // 
            // btnRefreshCustomer
            // 
            btnRefreshCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefreshCustomer.Location = new Point(833, 414);
            btnRefreshCustomer.Name = "btnRefreshCustomer";
            btnRefreshCustomer.Size = new Size(94, 29);
            btnRefreshCustomer.TabIndex = 2;
            btnRefreshCustomer.Text = "Yenile";
            btnRefreshCustomer.UseVisualStyleBackColor = true;
            btnRefreshCustomer.Click += btnRefreshCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteCustomer.Location = new Point(207, 414);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(94, 29);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Sil";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateCustomer.Location = new Point(107, 414);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(94, 29);
            btnUpdateCustomer.TabIndex = 3;
            btnUpdateCustomer.Text = "Güncelle";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCustomer.Location = new Point(7, 414);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(94, 29);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Ekle";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lvCustomers
            // 
            lvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvCustomers.Columns.AddRange(new ColumnHeader[] { clmCustomerName, clmCountry, clmCity, clmDescription, clmContactName, clmContactPhone });
            lvCustomers.Location = new Point(6, 68);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(921, 340);
            lvCustomers.TabIndex = 0;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            // 
            // clmCustomerName
            // 
            clmCustomerName.Text = "Cari Adı";
            // 
            // clmCountry
            // 
            clmCountry.Text = "Ülke";
            // 
            // clmCity
            // 
            clmCity.Text = "Şehir";
            // 
            // clmDescription
            // 
            clmDescription.Text = "Açıklama";
            // 
            // clmContactName
            // 
            clmContactName.Text = "Yetkili";
            // 
            // clmContactPhone
            // 
            clmContactPhone.Text = "Yetkili Numarası";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(729, 35);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(198, 27);
            txtSearchCustomer.TabIndex = 5;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.AutoSize = true;
            lblSearchCustomer.Location = new Point(691, 38);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(32, 20);
            lblSearchCustomer.TabIndex = 6;
            lblSearchCustomer.Text = "Ara";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 531);
            Controls.Add(tabControlMain);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(970, 567);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enezcam ERP";
            Load += Main_Load;
            tabOrders.ResumeLayout(false);
            gbOrders.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabStock.ResumeLayout(false);
            gbProducts.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            gbCustomers.ResumeLayout(false);
            gbCustomers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabOrders;
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
        private TabControl tabControlMain;
        private TabPage tabStock;
        private GroupBox gbProducts;
        private ListView lvProducts;
        private TabPage tabCustomer;
        private GroupBox gbCustomers;
        private ListView lvCustomers;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Button btnAddCustomer;
        private Button btnRefreshStock;
        private ColumnHeader clmName;
        private ColumnHeader clmProductType;
        private ColumnHeader clmCustomerName;
        private ColumnHeader clmCountry;
        private ColumnHeader clmCity;
        private ColumnHeader clmDescription;
        private ColumnHeader clmContactName;
        private ColumnHeader clmContactPhone;
        private Button btnRefreshCustomer;
        private TextBox txtSearchCustomer;
        private Label lblSearchCustomer;
    }
}
