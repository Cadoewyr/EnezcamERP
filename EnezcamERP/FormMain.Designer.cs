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
            lblSearchOrder = new Label();
            txtSearchOrder = new TextBox();
            btnRefreshOrder = new Button();
            btnDeleteOrder = new Button();
            btnUpdateOrder = new Button();
            btnAddOrder = new Button();
            lvOrders = new ListView();
            clmJobNo = new ColumnHeader();
            clmCustomer = new ColumnHeader();
            clmIssueDate = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmProducedQuantity = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmCost = new ColumnHeader();
            clmProfit = new ColumnHeader();
            clmProfitPercentage = new ColumnHeader();
            tabControlMain = new TabControl();
            tabStock = new TabPage();
            gbProducts = new GroupBox();
            lblSearchProduct = new Label();
            txtSearchProduct = new TextBox();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnRefreshStock = new Button();
            btnDeleteProduct = new Button();
            lvProducts = new ListView();
            clmName = new ColumnHeader();
            clmProductType = new ColumnHeader();
            tabCustomer = new TabPage();
            gbCustomers = new GroupBox();
            lblSearchCustomer = new Label();
            txtSearchCustomer = new TextBox();
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
            tabOrders.Location = new Point(4, 24);
            tabOrders.Margin = new Padding(3, 2, 3, 2);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3, 2, 3, 2);
            tabOrders.Size = new Size(868, 388);
            tabOrders.TabIndex = 0;
            tabOrders.Text = "Siparişler";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // gbOrders
            // 
            gbOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrders.Controls.Add(lblSearchOrder);
            gbOrders.Controls.Add(txtSearchOrder);
            gbOrders.Controls.Add(btnRefreshOrder);
            gbOrders.Controls.Add(btnDeleteOrder);
            gbOrders.Controls.Add(btnUpdateOrder);
            gbOrders.Controls.Add(btnAddOrder);
            gbOrders.Controls.Add(lvOrders);
            gbOrders.Location = new Point(5, 4);
            gbOrders.Margin = new Padding(3, 2, 3, 2);
            gbOrders.Name = "gbOrders";
            gbOrders.Padding = new Padding(3, 2, 3, 2);
            gbOrders.Size = new Size(858, 380);
            gbOrders.TabIndex = 0;
            gbOrders.TabStop = false;
            gbOrders.Text = "Siparişler";
            // 
            // lblSearchOrder
            // 
            lblSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchOrder.AutoSize = true;
            lblSearchOrder.Location = new Point(646, 22);
            lblSearchOrder.Name = "lblSearchOrder";
            lblSearchOrder.Size = new Size(25, 15);
            lblSearchOrder.TabIndex = 10;
            lblSearchOrder.Text = "Ara";
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchOrder.Location = new Point(679, 20);
            txtSearchOrder.Margin = new Padding(3, 2, 3, 2);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.Size = new Size(174, 23);
            txtSearchOrder.TabIndex = 9;
            // 
            // btnRefreshOrder
            // 
            btnRefreshOrder.Location = new Point(268, 18);
            btnRefreshOrder.Margin = new Padding(3, 2, 3, 2);
            btnRefreshOrder.Name = "btnRefreshOrder";
            btnRefreshOrder.Size = new Size(82, 22);
            btnRefreshOrder.TabIndex = 5;
            btnRefreshOrder.Text = "Yenile";
            btnRefreshOrder.UseVisualStyleBackColor = true;
            btnRefreshOrder.Click += btnRefreshOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(180, 18);
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
            btnUpdateOrder.Location = new Point(93, 18);
            btnUpdateOrder.Margin = new Padding(3, 2, 3, 2);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(82, 22);
            btnUpdateOrder.TabIndex = 2;
            btnUpdateOrder.Text = "Güncelle";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(5, 18);
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
            lvOrders.Columns.AddRange(new ColumnHeader[] { clmJobNo, clmCustomer, clmIssueDate, clmQuantity, clmProducedQuantity, clmPrice, clmCost, clmProfit, clmProfitPercentage });
            lvOrders.FullRowSelect = true;
            lvOrders.GridLines = true;
            lvOrders.Location = new Point(5, 44);
            lvOrders.Margin = new Padding(3, 2, 3, 2);
            lvOrders.MultiSelect = false;
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(848, 332);
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
            // clmQuantity
            // 
            clmQuantity.Text = "Sipariş Adedi";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretim";
            // 
            // clmPrice
            // 
            clmPrice.Text = "Tutar";
            // 
            // clmCost
            // 
            clmCost.Text = "Maliyet";
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
            tabControlMain.Margin = new Padding(3, 2, 3, 2);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(876, 416);
            tabControlMain.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(gbProducts);
            tabStock.Location = new Point(4, 24);
            tabStock.Margin = new Padding(3, 2, 3, 2);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3, 2, 3, 2);
            tabStock.Size = new Size(868, 388);
            tabStock.TabIndex = 1;
            tabStock.Text = "Stok Kartı";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // gbProducts
            // 
            gbProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProducts.Controls.Add(lblSearchProduct);
            gbProducts.Controls.Add(txtSearchProduct);
            gbProducts.Controls.Add(btnAddProduct);
            gbProducts.Controls.Add(btnUpdateProduct);
            gbProducts.Controls.Add(btnRefreshStock);
            gbProducts.Controls.Add(btnDeleteProduct);
            gbProducts.Controls.Add(lvProducts);
            gbProducts.Location = new Point(5, 4);
            gbProducts.Margin = new Padding(3, 2, 3, 2);
            gbProducts.Name = "gbProducts";
            gbProducts.Padding = new Padding(3, 2, 3, 2);
            gbProducts.Size = new Size(858, 380);
            gbProducts.TabIndex = 0;
            gbProducts.TabStop = false;
            gbProducts.Text = "Stok Kartları";
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Location = new Point(646, 22);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(25, 15);
            lblSearchProduct.TabIndex = 8;
            lblSearchProduct.Text = "Ara";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchProduct.Location = new Point(679, 20);
            txtSearchProduct.Margin = new Padding(3, 2, 3, 2);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(174, 23);
            txtSearchProduct.TabIndex = 7;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(5, 18);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(82, 22);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(93, 18);
            btnUpdateProduct.Margin = new Padding(3, 2, 3, 2);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(82, 22);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnRefreshStock
            // 
            btnRefreshStock.Location = new Point(268, 18);
            btnRefreshStock.Margin = new Padding(3, 2, 3, 2);
            btnRefreshStock.Name = "btnRefreshStock";
            btnRefreshStock.Size = new Size(82, 22);
            btnRefreshStock.TabIndex = 2;
            btnRefreshStock.Text = "Yenile";
            btnRefreshStock.UseVisualStyleBackColor = true;
            btnRefreshStock.Click += btnRefreshStock_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(180, 18);
            btnDeleteProduct.Margin = new Padding(3, 2, 3, 2);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(82, 22);
            btnDeleteProduct.TabIndex = 1;
            btnDeleteProduct.Text = "Sil";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmName, clmProductType });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(5, 44);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(848, 332);
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
            tabCustomer.Location = new Point(4, 24);
            tabCustomer.Margin = new Padding(3, 2, 3, 2);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3, 2, 3, 2);
            tabCustomer.Size = new Size(868, 388);
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
            gbCustomers.Location = new Point(5, 4);
            gbCustomers.Margin = new Padding(3, 2, 3, 2);
            gbCustomers.Name = "gbCustomers";
            gbCustomers.Padding = new Padding(3, 2, 3, 2);
            gbCustomers.Size = new Size(858, 380);
            gbCustomers.TabIndex = 0;
            gbCustomers.TabStop = false;
            gbCustomers.Text = "Cariler";
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchCustomer.AutoSize = true;
            lblSearchCustomer.Location = new Point(646, 22);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(25, 15);
            lblSearchCustomer.TabIndex = 6;
            lblSearchCustomer.Text = "Ara";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchCustomer.Location = new Point(679, 20);
            txtSearchCustomer.Margin = new Padding(3, 2, 3, 2);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(174, 23);
            txtSearchCustomer.TabIndex = 5;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // btnRefreshCustomer
            // 
            btnRefreshCustomer.Location = new Point(268, 18);
            btnRefreshCustomer.Margin = new Padding(3, 2, 3, 2);
            btnRefreshCustomer.Name = "btnRefreshCustomer";
            btnRefreshCustomer.Size = new Size(82, 22);
            btnRefreshCustomer.TabIndex = 2;
            btnRefreshCustomer.Text = "Yenile";
            btnRefreshCustomer.UseVisualStyleBackColor = true;
            btnRefreshCustomer.Click += btnRefreshCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(180, 18);
            btnDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(82, 22);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Sil";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(93, 18);
            btnUpdateCustomer.Margin = new Padding(3, 2, 3, 2);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(82, 22);
            btnUpdateCustomer.TabIndex = 3;
            btnUpdateCustomer.Text = "Güncelle";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(5, 18);
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
            lvCustomers.Columns.AddRange(new ColumnHeader[] { clmCustomerName, clmCountry, clmCity, clmDescription, clmContactName, clmContactPhone });
            lvCustomers.FullRowSelect = true;
            lvCustomers.GridLines = true;
            lvCustomers.Location = new Point(4, 44);
            lvCustomers.Margin = new Padding(3, 2, 3, 2);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(848, 332);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 416);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(851, 435);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enezcam ERP";
            Load += Main_Load;
            tabOrders.ResumeLayout(false);
            gbOrders.ResumeLayout(false);
            gbOrders.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabStock.ResumeLayout(false);
            gbProducts.ResumeLayout(false);
            gbProducts.PerformLayout();
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
        private ColumnHeader clmQuantity;
        private ColumnHeader clmProducedQuantity;
        private ColumnHeader clmPrice;
        private ColumnHeader clmCost;
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
        private Label lblSearchProduct;
        private TextBox txtSearchProduct;
        private Button btnRefreshOrder;
        private Label lblSearchOrder;
        private TextBox txtSearchOrder;
    }
}
