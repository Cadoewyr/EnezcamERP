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
            gbDateFilterSettings = new GroupBox();
            cbDateFilter = new CheckBox();
            rbCompletedDate = new RadioButton();
            rbOrderDate = new RadioButton();
            lblDateFilter = new Label();
            mcDateFilter = new MonthCalendar();
            cbIsDone = new CheckBox();
            btnEditProducedOrders = new Button();
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
            clmCost = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmPriceWithTax = new ColumnHeader();
            clmProfit = new ColumnHeader();
            clmProfitRatio = new ColumnHeader();
            clmIsDone = new ColumnHeader();
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
            clmCode = new ColumnHeader();
            clmProcessType = new ColumnHeader();
            clmIsCounting = new ColumnHeader();
            clmLastCost = new ColumnHeader();
            clmLastPrice = new ColumnHeader();
            clmLastProfit = new ColumnHeader();
            clmLastProfitRatio = new ColumnHeader();
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
            clmAddress = new ColumnHeader();
            tabReports = new TabPage();
            gbProductionReportDetails = new GroupBox();
            label1 = new Label();
            nudOutgoing = new NumericUpDown();
            gbReportType = new GroupBox();
            rbSales = new RadioButton();
            rbProduction = new RadioButton();
            dtpDate = new DateTimePicker();
            btnCreateProductionReport = new Button();
            gbReportInterval = new GroupBox();
            rbDaily = new RadioButton();
            rbYearly = new RadioButton();
            rbWeekly = new RadioButton();
            rbMonthly = new RadioButton();
            gbProductionReport = new GroupBox();
            dgReport = new DataGridView();
            tabOrders.SuspendLayout();
            gbOrders.SuspendLayout();
            gbDateFilterSettings.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabStock.SuspendLayout();
            gbProducts.SuspendLayout();
            tabCustomer.SuspendLayout();
            gbCustomers.SuspendLayout();
            tabReports.SuspendLayout();
            gbProductionReportDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudOutgoing).BeginInit();
            gbReportType.SuspendLayout();
            gbReportInterval.SuspendLayout();
            gbProductionReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgReport).BeginInit();
            SuspendLayout();
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(gbOrders);
            tabOrders.Location = new Point(4, 24);
            tabOrders.Margin = new Padding(3, 2, 3, 2);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3, 2, 3, 2);
            tabOrders.Size = new Size(1236, 394);
            tabOrders.TabIndex = 0;
            tabOrders.Text = "Siparişler";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // gbOrders
            // 
            gbOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrders.Controls.Add(gbDateFilterSettings);
            gbOrders.Controls.Add(lblDateFilter);
            gbOrders.Controls.Add(mcDateFilter);
            gbOrders.Controls.Add(cbIsDone);
            gbOrders.Controls.Add(btnEditProducedOrders);
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
            gbOrders.Size = new Size(1225, 386);
            gbOrders.TabIndex = 0;
            gbOrders.TabStop = false;
            gbOrders.Text = "Siparişler";
            // 
            // gbDateFilterSettings
            // 
            gbDateFilterSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbDateFilterSettings.Controls.Add(cbDateFilter);
            gbDateFilterSettings.Controls.Add(rbCompletedDate);
            gbDateFilterSettings.Controls.Add(rbOrderDate);
            gbDateFilterSettings.Location = new Point(986, 238);
            gbDateFilterSettings.Name = "gbDateFilterSettings";
            gbDateFilterSettings.Size = new Size(233, 143);
            gbDateFilterSettings.TabIndex = 16;
            gbDateFilterSettings.TabStop = false;
            gbDateFilterSettings.Text = "Filtre Ayarları";
            // 
            // cbDateFilter
            // 
            cbDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbDateFilter.AutoSize = true;
            cbDateFilter.Location = new Point(6, 31);
            cbDateFilter.Margin = new Padding(3, 2, 3, 2);
            cbDateFilter.Name = "cbDateFilter";
            cbDateFilter.Size = new Size(139, 19);
            cbDateFilter.TabIndex = 8;
            cbDateFilter.Text = "Tarih Filtresini Aktif Et";
            cbDateFilter.UseVisualStyleBackColor = true;
            cbDateFilter.CheckedChanged += cbDateFilter_CheckedChanged;
            // 
            // rbCompletedDate
            // 
            rbCompletedDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbCompletedDate.AutoSize = true;
            rbCompletedDate.Location = new Point(6, 80);
            rbCompletedDate.Name = "rbCompletedDate";
            rbCompletedDate.Size = new Size(128, 19);
            rbCompletedDate.TabIndex = 15;
            rbCompletedDate.TabStop = true;
            rbCompletedDate.Text = "Tamamlanma Tarihi";
            rbCompletedDate.UseVisualStyleBackColor = true;
            rbCompletedDate.CheckedChanged += DateFilterSettingsChanged;
            // 
            // rbOrderDate
            // 
            rbOrderDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbOrderDate.AutoSize = true;
            rbOrderDate.Checked = true;
            rbOrderDate.Location = new Point(6, 55);
            rbOrderDate.Name = "rbOrderDate";
            rbOrderDate.Size = new Size(90, 19);
            rbOrderDate.TabIndex = 15;
            rbOrderDate.TabStop = true;
            rbOrderDate.Text = "Sipariş Tarihi";
            rbOrderDate.UseVisualStyleBackColor = true;
            rbOrderDate.CheckedChanged += DateFilterSettingsChanged;
            // 
            // lblDateFilter
            // 
            lblDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateFilter.AutoSize = true;
            lblDateFilter.Location = new Point(985, 44);
            lblDateFilter.Name = "lblDateFilter";
            lblDateFilter.Size = new Size(69, 15);
            lblDateFilter.TabIndex = 14;
            lblDateFilter.Text = "Tarih Aralığı";
            // 
            // mcDateFilter
            // 
            mcDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcDateFilter.Location = new Point(986, 66);
            mcDateFilter.Margin = new Padding(8, 7, 8, 7);
            mcDateFilter.MaxSelectionCount = 42;
            mcDateFilter.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            mcDateFilter.Name = "mcDateFilter";
            mcDateFilter.TabIndex = 7;
            mcDateFilter.DateSelected += mcDateFilter_DateSelected;
            // 
            // cbIsDone
            // 
            cbIsDone.AutoSize = true;
            cbIsDone.Location = new Point(485, 20);
            cbIsDone.Margin = new Padding(3, 2, 3, 2);
            cbIsDone.Name = "cbIsDone";
            cbIsDone.Size = new Size(189, 19);
            cbIsDone.TabIndex = 5;
            cbIsDone.Text = "Tamamlanmış Siparişleri Listele";
            cbIsDone.UseVisualStyleBackColor = true;
            cbIsDone.CheckedChanged += cbIsDone_CheckedChanged;
            // 
            // btnEditProducedOrders
            // 
            btnEditProducedOrders.Location = new Point(355, 18);
            btnEditProducedOrders.Margin = new Padding(3, 2, 3, 2);
            btnEditProducedOrders.Name = "btnEditProducedOrders";
            btnEditProducedOrders.Size = new Size(124, 22);
            btnEditProducedOrders.TabIndex = 4;
            btnEditProducedOrders.Text = "Üretim Geçmişi";
            btnEditProducedOrders.UseVisualStyleBackColor = true;
            btnEditProducedOrders.Click += btnEditProducedOrders_Click;
            // 
            // lblSearchOrder
            // 
            lblSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchOrder.AutoSize = true;
            lblSearchOrder.Location = new Point(768, 20);
            lblSearchOrder.Name = "lblSearchOrder";
            lblSearchOrder.Size = new Size(25, 15);
            lblSearchOrder.TabIndex = 10;
            lblSearchOrder.Text = "Ara";
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchOrder.Location = new Point(802, 19);
            txtSearchOrder.Margin = new Padding(3, 2, 3, 2);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.Size = new Size(174, 23);
            txtSearchOrder.TabIndex = 6;
            txtSearchOrder.TextChanged += txtSearchOrder_TextChanged;
            // 
            // btnRefreshOrder
            // 
            btnRefreshOrder.Location = new Point(268, 18);
            btnRefreshOrder.Margin = new Padding(3, 2, 3, 2);
            btnRefreshOrder.Name = "btnRefreshOrder";
            btnRefreshOrder.Size = new Size(82, 22);
            btnRefreshOrder.TabIndex = 3;
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
            btnDeleteOrder.TabIndex = 2;
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
            btnUpdateOrder.TabIndex = 1;
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
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lvOrders
            // 
            lvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrders.Columns.AddRange(new ColumnHeader[] { clmJobNo, clmCustomer, clmIssueDate, clmQuantity, clmProducedQuantity, clmCost, clmPrice, clmPriceWithTax, clmProfit, clmProfitRatio, clmIsDone });
            lvOrders.FullRowSelect = true;
            lvOrders.GridLines = true;
            lvOrders.Location = new Point(5, 44);
            lvOrders.Margin = new Padding(3, 2, 3, 2);
            lvOrders.MultiSelect = false;
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(970, 338);
            lvOrders.TabIndex = 4;
            lvOrders.UseCompatibleStateImageBehavior = false;
            lvOrders.View = View.Details;
            lvOrders.DoubleClick += btnUpdateOrder_Click;
            lvOrders.KeyDown += ListView_KeyDown;
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
            clmQuantity.Text = "Sipariş Miktarı";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretim Miktarı";
            // 
            // clmCost
            // 
            clmCost.Text = "Maliyet";
            // 
            // clmPrice
            // 
            clmPrice.Text = "Tutar";
            // 
            // clmPriceWithTax
            // 
            clmPriceWithTax.Text = "Vergi Dahil Fiyat";
            // 
            // clmProfit
            // 
            clmProfit.Text = "Kar";
            // 
            // clmProfitRatio
            // 
            clmProfitRatio.Text = "Kar Oranı";
            // 
            // clmIsDone
            // 
            clmIsDone.Text = "Durum";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabOrders);
            tabControlMain.Controls.Add(tabStock);
            tabControlMain.Controls.Add(tabCustomer);
            tabControlMain.Controls.Add(tabReports);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(3, 2, 3, 2);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1244, 422);
            tabControlMain.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(gbProducts);
            tabStock.Location = new Point(4, 24);
            tabStock.Margin = new Padding(3, 2, 3, 2);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3, 2, 3, 2);
            tabStock.Size = new Size(1236, 394);
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
            gbProducts.Size = new Size(1227, 386);
            gbProducts.TabIndex = 0;
            gbProducts.TabStop = false;
            gbProducts.Text = "Stok Kartları";
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Location = new Point(1015, 21);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(25, 15);
            lblSearchProduct.TabIndex = 8;
            lblSearchProduct.Text = "Ara";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchProduct.Location = new Point(1048, 20);
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
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmName, clmCode, clmProcessType, clmIsCounting, clmLastCost, clmLastPrice, clmLastProfit, clmLastProfitRatio });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(5, 44);
            lvProducts.Margin = new Padding(3, 2, 3, 2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(1217, 338);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.DoubleClick += btnUpdateProduct_Click;
            lvProducts.KeyDown += ListView_KeyDown;
            // 
            // clmName
            // 
            clmName.Text = "Ürün Adı";
            // 
            // clmCode
            // 
            clmCode.Text = "Ürün Kodu";
            // 
            // clmProcessType
            // 
            clmProcessType.Text = "İşlem Tipi";
            // 
            // clmIsCounting
            // 
            clmIsCounting.Text = "Say";
            // 
            // clmLastCost
            // 
            clmLastCost.Text = "Son Maliyet";
            // 
            // clmLastPrice
            // 
            clmLastPrice.Text = "Son Fiyat";
            // 
            // clmLastProfit
            // 
            clmLastProfit.Text = "Son Kar";
            // 
            // clmLastProfitRatio
            // 
            clmLastProfitRatio.Text = "Son Kar Oranı";
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(gbCustomers);
            tabCustomer.Location = new Point(4, 24);
            tabCustomer.Margin = new Padding(3, 2, 3, 2);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3, 2, 3, 2);
            tabCustomer.Size = new Size(1236, 394);
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
            gbCustomers.Size = new Size(1227, 386);
            gbCustomers.TabIndex = 0;
            gbCustomers.TabStop = false;
            gbCustomers.Text = "Cariler";
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchCustomer.AutoSize = true;
            lblSearchCustomer.Location = new Point(1015, 22);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(25, 15);
            lblSearchCustomer.TabIndex = 6;
            lblSearchCustomer.Text = "Ara";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchCustomer.Location = new Point(1048, 20);
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
            lvCustomers.Columns.AddRange(new ColumnHeader[] { clmCustomerName, clmCountry, clmCity, clmDescription, clmContactName, clmContactPhone, clmAddress });
            lvCustomers.FullRowSelect = true;
            lvCustomers.GridLines = true;
            lvCustomers.Location = new Point(4, 44);
            lvCustomers.Margin = new Padding(3, 2, 3, 2);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(1217, 338);
            lvCustomers.TabIndex = 0;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            lvCustomers.DoubleClick += btnUpdateCustomer_Click;
            lvCustomers.KeyDown += ListView_KeyDown;
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
            // clmAddress
            // 
            clmAddress.Text = "Adres";
            // 
            // tabReports
            // 
            tabReports.Controls.Add(gbProductionReportDetails);
            tabReports.Controls.Add(gbProductionReport);
            tabReports.Location = new Point(4, 24);
            tabReports.Margin = new Padding(3, 2, 3, 2);
            tabReports.Name = "tabReports";
            tabReports.Padding = new Padding(3, 2, 3, 2);
            tabReports.Size = new Size(1236, 394);
            tabReports.TabIndex = 3;
            tabReports.Text = "Raporlar";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // gbProductionReportDetails
            // 
            gbProductionReportDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbProductionReportDetails.Controls.Add(label1);
            gbProductionReportDetails.Controls.Add(nudOutgoing);
            gbProductionReportDetails.Controls.Add(gbReportType);
            gbProductionReportDetails.Controls.Add(dtpDate);
            gbProductionReportDetails.Controls.Add(btnCreateProductionReport);
            gbProductionReportDetails.Controls.Add(gbReportInterval);
            gbProductionReportDetails.Location = new Point(1024, 4);
            gbProductionReportDetails.Margin = new Padding(3, 2, 3, 2);
            gbProductionReportDetails.Name = "gbProductionReportDetails";
            gbProductionReportDetails.Padding = new Padding(3, 2, 3, 2);
            gbProductionReportDetails.Size = new Size(206, 387);
            gbProductionReportDetails.TabIndex = 2;
            gbProductionReportDetails.TabStop = false;
            gbProductionReportDetails.Text = "Rapor Detayları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 244);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "Günlük Gider";
            // 
            // nudOutgoing
            // 
            nudOutgoing.Location = new Point(5, 262);
            nudOutgoing.Margin = new Padding(3, 2, 3, 2);
            nudOutgoing.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudOutgoing.Name = "nudOutgoing";
            nudOutgoing.Size = new Size(196, 23);
            nudOutgoing.TabIndex = 6;
            // 
            // gbReportType
            // 
            gbReportType.Controls.Add(rbSales);
            gbReportType.Controls.Add(rbProduction);
            gbReportType.Location = new Point(5, 138);
            gbReportType.Margin = new Padding(3, 2, 3, 2);
            gbReportType.Name = "gbReportType";
            gbReportType.Padding = new Padding(3, 2, 3, 2);
            gbReportType.Size = new Size(196, 69);
            gbReportType.TabIndex = 5;
            gbReportType.TabStop = false;
            gbReportType.Text = "Rapor Türü";
            // 
            // rbSales
            // 
            rbSales.AutoSize = true;
            rbSales.Enabled = false;
            rbSales.Location = new Point(5, 20);
            rbSales.Margin = new Padding(3, 2, 3, 2);
            rbSales.Name = "rbSales";
            rbSales.Size = new Size(49, 19);
            rbSales.TabIndex = 1;
            rbSales.Text = "Satış";
            rbSales.UseVisualStyleBackColor = true;
            // 
            // rbProduction
            // 
            rbProduction.AutoSize = true;
            rbProduction.Checked = true;
            rbProduction.Location = new Point(5, 42);
            rbProduction.Margin = new Padding(3, 2, 3, 2);
            rbProduction.Name = "rbProduction";
            rbProduction.Size = new Size(61, 19);
            rbProduction.TabIndex = 1;
            rbProduction.TabStop = true;
            rbProduction.Text = "Üretim";
            rbProduction.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(5, 212);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(196, 23);
            dtpDate.TabIndex = 4;
            // 
            // btnCreateProductionReport
            // 
            btnCreateProductionReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateProductionReport.Location = new Point(5, 361);
            btnCreateProductionReport.Margin = new Padding(3, 2, 3, 2);
            btnCreateProductionReport.Name = "btnCreateProductionReport";
            btnCreateProductionReport.Size = new Size(196, 22);
            btnCreateProductionReport.TabIndex = 3;
            btnCreateProductionReport.Text = "Oluştur";
            btnCreateProductionReport.UseVisualStyleBackColor = true;
            btnCreateProductionReport.Click += btnCreateProductionReport_Click;
            // 
            // gbReportInterval
            // 
            gbReportInterval.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbReportInterval.Controls.Add(rbDaily);
            gbReportInterval.Controls.Add(rbYearly);
            gbReportInterval.Controls.Add(rbWeekly);
            gbReportInterval.Controls.Add(rbMonthly);
            gbReportInterval.Location = new Point(5, 20);
            gbReportInterval.Margin = new Padding(3, 2, 3, 2);
            gbReportInterval.Name = "gbReportInterval";
            gbReportInterval.Padding = new Padding(3, 2, 3, 2);
            gbReportInterval.Size = new Size(196, 114);
            gbReportInterval.TabIndex = 2;
            gbReportInterval.TabStop = false;
            gbReportInterval.Text = "Rapor Türü";
            // 
            // rbDaily
            // 
            rbDaily.AutoSize = true;
            rbDaily.Checked = true;
            rbDaily.Location = new Point(18, 20);
            rbDaily.Margin = new Padding(3, 2, 3, 2);
            rbDaily.Name = "rbDaily";
            rbDaily.Size = new Size(63, 19);
            rbDaily.TabIndex = 1;
            rbDaily.TabStop = true;
            rbDaily.Text = "Günlük";
            rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbYearly
            // 
            rbYearly.AutoSize = true;
            rbYearly.Enabled = false;
            rbYearly.Location = new Point(18, 87);
            rbYearly.Margin = new Padding(3, 2, 3, 2);
            rbYearly.Name = "rbYearly";
            rbYearly.Size = new Size(50, 19);
            rbYearly.TabIndex = 1;
            rbYearly.Text = "Yıllık";
            rbYearly.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            rbWeekly.AutoSize = true;
            rbWeekly.Enabled = false;
            rbWeekly.Location = new Point(18, 42);
            rbWeekly.Margin = new Padding(3, 2, 3, 2);
            rbWeekly.Name = "rbWeekly";
            rbWeekly.Size = new Size(66, 19);
            rbWeekly.TabIndex = 1;
            rbWeekly.Text = "Haftalık";
            rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            rbMonthly.AutoSize = true;
            rbMonthly.Enabled = false;
            rbMonthly.Location = new Point(18, 64);
            rbMonthly.Margin = new Padding(3, 2, 3, 2);
            rbMonthly.Name = "rbMonthly";
            rbMonthly.Size = new Size(51, 19);
            rbMonthly.TabIndex = 1;
            rbMonthly.Text = "Aylık";
            rbMonthly.UseVisualStyleBackColor = true;
            // 
            // gbProductionReport
            // 
            gbProductionReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProductionReport.Controls.Add(dgReport);
            gbProductionReport.Location = new Point(7, 4);
            gbProductionReport.Margin = new Padding(3, 2, 3, 2);
            gbProductionReport.Name = "gbProductionReport";
            gbProductionReport.Padding = new Padding(3, 2, 3, 2);
            gbProductionReport.Size = new Size(1012, 387);
            gbProductionReport.TabIndex = 1;
            gbProductionReport.TabStop = false;
            gbProductionReport.Text = "Rapor";
            // 
            // dgReport
            // 
            dgReport.AllowUserToAddRows = false;
            dgReport.AllowUserToDeleteRows = false;
            dgReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgReport.BorderStyle = BorderStyle.None;
            dgReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReport.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgReport.Location = new Point(5, 20);
            dgReport.Margin = new Padding(3, 2, 3, 2);
            dgReport.Name = "dgReport";
            dgReport.ReadOnly = true;
            dgReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgReport.ShowEditingIcon = false;
            dgReport.Size = new Size(1001, 363);
            dgReport.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 422);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(1076, 459);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enezcam ERP";
            Load += Main_Load;
            tabOrders.ResumeLayout(false);
            gbOrders.ResumeLayout(false);
            gbOrders.PerformLayout();
            gbDateFilterSettings.ResumeLayout(false);
            gbDateFilterSettings.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabStock.ResumeLayout(false);
            gbProducts.ResumeLayout(false);
            gbProducts.PerformLayout();
            tabCustomer.ResumeLayout(false);
            gbCustomers.ResumeLayout(false);
            gbCustomers.PerformLayout();
            tabReports.ResumeLayout(false);
            gbProductionReportDetails.ResumeLayout(false);
            gbProductionReportDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudOutgoing).EndInit();
            gbReportType.ResumeLayout(false);
            gbReportType.PerformLayout();
            gbReportInterval.ResumeLayout(false);
            gbReportInterval.PerformLayout();
            gbProductionReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgReport).EndInit();
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
        private ColumnHeader clmProfitRatio;
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
        private ColumnHeader clmProcessType;
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
        private ColumnHeader clmIsCounting;
        private Button btnEditProducedOrders;
        private ColumnHeader clmLastCost;
        private ColumnHeader clmLastPrice;
        private ColumnHeader clmLastProfit;
        private ColumnHeader clmLastProfitRatio;
        private CheckBox cbIsDone;
        private ColumnHeader clmAddress;
        private ColumnHeader clmPriceWithTax;
        private ColumnHeader clmIsDone;
        private Label lblDateFilter;
        private MonthCalendar mcDateFilter;
        private CheckBox cbDateFilter;
        private TabPage tabReports;
        private GroupBox gbProductionReport;
        private DataGridView dgReport;
        private GroupBox gbProductionReportDetails;
        private GroupBox gbReportInterval;
        private RadioButton rbDaily;
        private RadioButton rbYearly;
        private RadioButton rbWeekly;
        private RadioButton rbMonthly;
        private Button btnCreateProductionReport;
        private GroupBox gbReportType;
        private RadioButton rbSales;
        private RadioButton rbProduction;
        private ColumnHeader clmCode;
        private DateTimePicker dtpDate;
        private Label label1;
        private NumericUpDown nudOutgoing;
        private RadioButton rbOrderDate;
        private GroupBox gbDateFilterSettings;
        private RadioButton rbCompletedDate;
    }
}
