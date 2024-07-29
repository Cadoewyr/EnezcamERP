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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabOrders = new TabPage();
            gbOrders = new GroupBox();
            lblPageNumber = new Label();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPreviousPage = new Button();
            gbOrdersTotals = new GroupBox();
            txtTotalPriceWithTax = new TextBox();
            txtTotalPrice = new TextBox();
            txtTotalCost = new TextBox();
            txtTotalRemainingQuantity = new TextBox();
            lblTotalPriceWithTax = new Label();
            txtTotalProducedQuantity = new TextBox();
            lblTotalPrice = new Label();
            lblTotalCost = new Label();
            lblTotalRemainingQuantity = new Label();
            txtTotalQuantity = new TextBox();
            lblTotalProducedQuantity = new Label();
            lblTotalQuantity = new Label();
            gbDateFilterSettings = new GroupBox();
            cbDateFilter = new CheckBox();
            rbDeliveryDate = new RadioButton();
            rbCompletedDate = new RadioButton();
            rbOrderDate = new RadioButton();
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
            clmDeliveryDate = new ColumnHeader();
            clmQuantity = new ColumnHeader();
            clmProducedQuantity = new ColumnHeader();
            clmRemainingQuantity = new ColumnHeader();
            clmPrice = new ColumnHeader();
            clmPriceWithTax = new ColumnHeader();
            clmProfit = new ColumnHeader();
            clmProfitRatio = new ColumnHeader();
            clmIsDone = new ColumnHeader();
            clmCompletedDate = new ColumnHeader();
            cmsOrders = new ContextMenuStrip(components);
            addOrderToolStripMenuItem = new ToolStripMenuItem();
            updateOrderToolStripMenuItem = new ToolStripMenuItem();
            deleteOrderToolStripMenuItem = new ToolStripMenuItem();
            productionHistoryToolStripMenuItem = new ToolStripMenuItem();
            kalanSiparişiTamamlaToolStripMenuItem = new ToolStripMenuItem();
            tümünüSeçToolStripMenuItem = new ToolStripMenuItem();
            aynıMüşterininSiparişleriniSeçToolStripMenuItem = new ToolStripMenuItem();
            seçimleriKaldırToolStripMenuItem = new ToolStripMenuItem();
            tabMain = new TabControl();
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
            clmTotalPrice = new ColumnHeader();
            tabReports = new TabPage();
            gbTotals = new GroupBox();
            txtStockQuantity = new TextBox();
            lblStockQuantity = new Label();
            txtProcessQuantity = new TextBox();
            lblProcessQuantity = new Label();
            txtProfitWithoutOutgoing = new TextBox();
            lbProfitWithoutOutgoing = new Label();
            txtOutgoing = new TextBox();
            lbOutgoing = new Label();
            txtProducedQuantity = new TextBox();
            txtProfitRatio = new TextBox();
            lblProducedQuantity = new Label();
            lbProfitRatio = new Label();
            txtProfitMargin = new TextBox();
            lbProfitMargin = new Label();
            txtProfit = new TextBox();
            lbProfit = new Label();
            txtCostWithTax = new TextBox();
            lbCostWithTax = new Label();
            txtCostTax = new TextBox();
            lbCostTax = new Label();
            txtCost = new TextBox();
            lbCost = new Label();
            txtPriceWithTax = new TextBox();
            lbPriceWithTax = new Label();
            txtPriceTax = new TextBox();
            lbPriceTax = new Label();
            txtPrice = new TextBox();
            lbPrice = new Label();
            gbProductionReportDetails = new GroupBox();
            cbIsOvertime = new CheckBox();
            cbCalculateAllInterval = new CheckBox();
            label1 = new Label();
            nudOutgoing = new NumericUpDown();
            gbReportType = new GroupBox();
            rbSales = new RadioButton();
            rbProduction = new RadioButton();
            dtpDate = new DateTimePicker();
            btnCopyTable = new Button();
            btnCreateReport = new Button();
            gbReportInterval = new GroupBox();
            rbDaily = new RadioButton();
            rbYearly = new RadioButton();
            rbWeekly = new RadioButton();
            rbMonthly = new RadioButton();
            gbProductionReport = new GroupBox();
            dgReport = new DataGridView();
            tabOrders.SuspendLayout();
            gbOrders.SuspendLayout();
            gbOrdersTotals.SuspendLayout();
            gbDateFilterSettings.SuspendLayout();
            cmsOrders.SuspendLayout();
            tabMain.SuspendLayout();
            tabStock.SuspendLayout();
            gbProducts.SuspendLayout();
            tabCustomer.SuspendLayout();
            gbCustomers.SuspendLayout();
            tabReports.SuspendLayout();
            gbTotals.SuspendLayout();
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
            tabOrders.Location = new Point(4, 29);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3, 3, 3, 3);
            tabOrders.Size = new Size(1546, 874);
            tabOrders.TabIndex = 0;
            tabOrders.Text = "Siparişler";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // gbOrders
            // 
            gbOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOrders.Controls.Add(lblPageNumber);
            gbOrders.Controls.Add(btnLastPage);
            gbOrders.Controls.Add(btnNextPage);
            gbOrders.Controls.Add(btnFirstPage);
            gbOrders.Controls.Add(btnPreviousPage);
            gbOrders.Controls.Add(gbOrdersTotals);
            gbOrders.Controls.Add(gbDateFilterSettings);
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
            gbOrders.Location = new Point(6, 5);
            gbOrders.Name = "gbOrders";
            gbOrders.Size = new Size(1533, 857);
            gbOrders.TabIndex = 0;
            gbOrders.TabStop = false;
            gbOrders.Text = "Siparişler";
            // 
            // lblPageNumber
            // 
            lblPageNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(1139, 28);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(17, 20);
            lblPageNumber.TabIndex = 19;
            lblPageNumber.Text = "1";
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLastPage.Location = new Point(1208, 24);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(38, 29);
            btnLastPage.TabIndex = 18;
            btnLastPage.Text = ">>";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNextPage.Location = new Point(1174, 24);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(29, 29);
            btnNextPage.TabIndex = 18;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFirstPage.Location = new Point(1051, 24);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(38, 29);
            btnFirstPage.TabIndex = 18;
            btnFirstPage.Text = "<<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPreviousPage.Location = new Point(1095, 24);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(29, 29);
            btnPreviousPage.TabIndex = 18;
            btnPreviousPage.Text = "<";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // gbOrdersTotals
            // 
            gbOrdersTotals.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbOrdersTotals.Controls.Add(txtTotalPriceWithTax);
            gbOrdersTotals.Controls.Add(txtTotalPrice);
            gbOrdersTotals.Controls.Add(txtTotalCost);
            gbOrdersTotals.Controls.Add(txtTotalRemainingQuantity);
            gbOrdersTotals.Controls.Add(lblTotalPriceWithTax);
            gbOrdersTotals.Controls.Add(txtTotalProducedQuantity);
            gbOrdersTotals.Controls.Add(lblTotalPrice);
            gbOrdersTotals.Controls.Add(lblTotalCost);
            gbOrdersTotals.Controls.Add(lblTotalRemainingQuantity);
            gbOrdersTotals.Controls.Add(txtTotalQuantity);
            gbOrdersTotals.Controls.Add(lblTotalProducedQuantity);
            gbOrdersTotals.Controls.Add(lblTotalQuantity);
            gbOrdersTotals.Location = new Point(1259, 497);
            gbOrdersTotals.Name = "gbOrdersTotals";
            gbOrdersTotals.Size = new Size(262, 353);
            gbOrdersTotals.TabIndex = 17;
            gbOrdersTotals.TabStop = false;
            gbOrdersTotals.Text = "Sipariş Toplamları";
            // 
            // txtTotalPriceWithTax
            // 
            txtTotalPriceWithTax.Location = new Point(6, 321);
            txtTotalPriceWithTax.MaxLength = 200;
            txtTotalPriceWithTax.Name = "txtTotalPriceWithTax";
            txtTotalPriceWithTax.ReadOnly = true;
            txtTotalPriceWithTax.Size = new Size(250, 27);
            txtTotalPriceWithTax.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(6, 268);
            txtTotalPrice.MaxLength = 200;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(250, 27);
            txtTotalPrice.TabIndex = 1;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(6, 215);
            txtTotalCost.MaxLength = 200;
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(250, 27);
            txtTotalCost.TabIndex = 1;
            // 
            // txtTotalRemainingQuantity
            // 
            txtTotalRemainingQuantity.Location = new Point(6, 163);
            txtTotalRemainingQuantity.MaxLength = 200;
            txtTotalRemainingQuantity.Name = "txtTotalRemainingQuantity";
            txtTotalRemainingQuantity.ReadOnly = true;
            txtTotalRemainingQuantity.Size = new Size(250, 27);
            txtTotalRemainingQuantity.TabIndex = 1;
            // 
            // lblTotalPriceWithTax
            // 
            lblTotalPriceWithTax.AutoSize = true;
            lblTotalPriceWithTax.Location = new Point(6, 299);
            lblTotalPriceWithTax.Name = "lblTotalPriceWithTax";
            lblTotalPriceWithTax.Size = new Size(174, 20);
            lblTotalPriceWithTax.TabIndex = 0;
            lblTotalPriceWithTax.Text = "Vergi Dahil Toplam Tutar";
            // 
            // txtTotalProducedQuantity
            // 
            txtTotalProducedQuantity.Location = new Point(6, 109);
            txtTotalProducedQuantity.MaxLength = 200;
            txtTotalProducedQuantity.Name = "txtTotalProducedQuantity";
            txtTotalProducedQuantity.ReadOnly = true;
            txtTotalProducedQuantity.Size = new Size(250, 27);
            txtTotalProducedQuantity.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(6, 245);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(97, 20);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "Toplam Tutar";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(6, 192);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(112, 20);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "Toplam Maliyet";
            // 
            // lblTotalRemainingQuantity
            // 
            lblTotalRemainingQuantity.AutoSize = true;
            lblTotalRemainingQuantity.Location = new Point(6, 139);
            lblTotalRemainingQuantity.Name = "lblTotalRemainingQuantity";
            lblTotalRemainingQuantity.Size = new Size(92, 20);
            lblTotalRemainingQuantity.TabIndex = 0;
            lblTotalRemainingQuantity.Text = "Kalan Miktar";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(6, 56);
            txtTotalQuantity.MaxLength = 200;
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new Size(250, 27);
            txtTotalQuantity.TabIndex = 1;
            // 
            // lblTotalProducedQuantity
            // 
            lblTotalProducedQuantity.AutoSize = true;
            lblTotalProducedQuantity.Location = new Point(6, 85);
            lblTotalProducedQuantity.Name = "lblTotalProducedQuantity";
            lblTotalProducedQuantity.Size = new Size(107, 20);
            lblTotalProducedQuantity.TabIndex = 0;
            lblTotalProducedQuantity.Text = "Üretilen Miktar";
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(6, 33);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(105, 20);
            lblTotalQuantity.TabIndex = 0;
            lblTotalQuantity.Text = "Toplam Miktar";
            // 
            // gbDateFilterSettings
            // 
            gbDateFilterSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbDateFilterSettings.Controls.Add(cbDateFilter);
            gbDateFilterSettings.Controls.Add(rbDeliveryDate);
            gbDateFilterSettings.Controls.Add(rbCompletedDate);
            gbDateFilterSettings.Controls.Add(rbOrderDate);
            gbDateFilterSettings.Location = new Point(1259, 314);
            gbDateFilterSettings.Margin = new Padding(3, 4, 3, 4);
            gbDateFilterSettings.Name = "gbDateFilterSettings";
            gbDateFilterSettings.Padding = new Padding(3, 4, 3, 4);
            gbDateFilterSettings.Size = new Size(262, 176);
            gbDateFilterSettings.TabIndex = 16;
            gbDateFilterSettings.TabStop = false;
            gbDateFilterSettings.Text = "Filtre Ayarları";
            // 
            // cbDateFilter
            // 
            cbDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbDateFilter.AutoSize = true;
            cbDateFilter.Location = new Point(7, 27);
            cbDateFilter.Name = "cbDateFilter";
            cbDateFilter.Size = new Size(173, 24);
            cbDateFilter.TabIndex = 9;
            cbDateFilter.Text = "Tarih Filtresini Aktif Et";
            cbDateFilter.UseVisualStyleBackColor = true;
            cbDateFilter.CheckedChanged += cbDateFilter_CheckedChanged;
            // 
            // rbDeliveryDate
            // 
            rbDeliveryDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbDeliveryDate.AutoSize = true;
            rbDeliveryDate.Enabled = false;
            rbDeliveryDate.Location = new Point(6, 123);
            rbDeliveryDate.Margin = new Padding(3, 4, 3, 4);
            rbDeliveryDate.Name = "rbDeliveryDate";
            rbDeliveryDate.Size = new Size(111, 24);
            rbDeliveryDate.TabIndex = 12;
            rbDeliveryDate.TabStop = true;
            rbDeliveryDate.Text = "Teslim Tarihi";
            rbDeliveryDate.UseVisualStyleBackColor = true;
            rbDeliveryDate.CheckedChanged += DateFilterSettingsChanged;
            // 
            // rbCompletedDate
            // 
            rbCompletedDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbCompletedDate.AutoSize = true;
            rbCompletedDate.Enabled = false;
            rbCompletedDate.Location = new Point(7, 91);
            rbCompletedDate.Margin = new Padding(3, 4, 3, 4);
            rbCompletedDate.Name = "rbCompletedDate";
            rbCompletedDate.Size = new Size(158, 24);
            rbCompletedDate.TabIndex = 11;
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
            rbOrderDate.Enabled = false;
            rbOrderDate.Location = new Point(6, 59);
            rbOrderDate.Margin = new Padding(3, 4, 3, 4);
            rbOrderDate.Name = "rbOrderDate";
            rbOrderDate.Size = new Size(113, 24);
            rbOrderDate.TabIndex = 10;
            rbOrderDate.TabStop = true;
            rbOrderDate.Text = "Sipariş Tarihi";
            rbOrderDate.UseVisualStyleBackColor = true;
            rbOrderDate.CheckedChanged += DateFilterSettingsChanged;
            // 
            // mcDateFilter
            // 
            mcDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcDateFilter.Enabled = false;
            mcDateFilter.Location = new Point(1259, 94);
            mcDateFilter.MaxSelectionCount = 42;
            mcDateFilter.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            mcDateFilter.Name = "mcDateFilter";
            mcDateFilter.TabIndex = 8;
            mcDateFilter.DateSelected += mcDateFilter_DateSelected;
            // 
            // cbIsDone
            // 
            cbIsDone.AutoSize = true;
            cbIsDone.Location = new Point(554, 27);
            cbIsDone.Name = "cbIsDone";
            cbIsDone.Size = new Size(237, 24);
            cbIsDone.TabIndex = 5;
            cbIsDone.Text = "Tamamlanmış Siparişleri Listele";
            cbIsDone.UseVisualStyleBackColor = true;
            cbIsDone.CheckedChanged += cbIsDone_CheckedChanged;
            // 
            // btnEditProducedOrders
            // 
            btnEditProducedOrders.Location = new Point(406, 24);
            btnEditProducedOrders.Name = "btnEditProducedOrders";
            btnEditProducedOrders.Size = new Size(142, 29);
            btnEditProducedOrders.TabIndex = 4;
            btnEditProducedOrders.Text = "Üretim Geçmişi";
            btnEditProducedOrders.UseVisualStyleBackColor = true;
            btnEditProducedOrders.Click += btnEditProducedOrders_Click;
            // 
            // lblSearchOrder
            // 
            lblSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchOrder.AutoSize = true;
            lblSearchOrder.Location = new Point(1253, 65);
            lblSearchOrder.Name = "lblSearchOrder";
            lblSearchOrder.Size = new Size(32, 20);
            lblSearchOrder.TabIndex = 10;
            lblSearchOrder.Text = "Ara";
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.AcceptsReturn = true;
            txtSearchOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchOrder.Location = new Point(1290, 59);
            txtSearchOrder.MaxLength = 200;
            txtSearchOrder.Multiline = true;
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.Size = new Size(223, 27);
            txtSearchOrder.TabIndex = 6;
            txtSearchOrder.KeyPress += txtSearchOrder_KeyPress;
            // 
            // btnRefreshOrder
            // 
            btnRefreshOrder.Location = new Point(306, 24);
            btnRefreshOrder.Name = "btnRefreshOrder";
            btnRefreshOrder.Size = new Size(94, 29);
            btnRefreshOrder.TabIndex = 3;
            btnRefreshOrder.Text = "Yenile";
            btnRefreshOrder.UseVisualStyleBackColor = true;
            btnRefreshOrder.Click += btnRefreshOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(206, 24);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(94, 29);
            btnDeleteOrder.TabIndex = 2;
            btnDeleteOrder.Text = "Sil";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Location = new Point(106, 24);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(94, 29);
            btnUpdateOrder.TabIndex = 1;
            btnUpdateOrder.Text = "Güncelle";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(6, 24);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(94, 29);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lvOrders
            // 
            lvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOrders.CheckBoxes = true;
            lvOrders.Columns.AddRange(new ColumnHeader[] { clmJobNo, clmCustomer, clmIssueDate, clmDeliveryDate, clmQuantity, clmProducedQuantity, clmRemainingQuantity, clmPrice, clmPriceWithTax, clmProfit, clmProfitRatio, clmIsDone, clmCompletedDate });
            lvOrders.ContextMenuStrip = cmsOrders;
            lvOrders.Font = new Font("Segoe UI", 10F);
            lvOrders.FullRowSelect = true;
            lvOrders.GridLines = true;
            lvOrders.Location = new Point(6, 59);
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(1241, 791);
            lvOrders.TabIndex = 7;
            lvOrders.UseCompatibleStateImageBehavior = false;
            lvOrders.View = View.Details;
            lvOrders.ItemChecked += lvOrders_ItemChecked;
            lvOrders.SelectedIndexChanged += lvOrders_SelectedIndexChanged;
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
            // clmDeliveryDate
            // 
            clmDeliveryDate.Text = "Teslim Tarihi";
            // 
            // clmQuantity
            // 
            clmQuantity.Text = "Sipariş Miktarı";
            // 
            // clmProducedQuantity
            // 
            clmProducedQuantity.Text = "Üretim Miktarı";
            // 
            // clmRemainingQuantity
            // 
            clmRemainingQuantity.Text = "Kalan Üretim";
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
            // clmCompletedDate
            // 
            clmCompletedDate.Text = "Tamamlanma Tarihi";
            // 
            // cmsOrders
            // 
            cmsOrders.ImageScalingSize = new Size(20, 20);
            cmsOrders.Items.AddRange(new ToolStripItem[] { addOrderToolStripMenuItem, updateOrderToolStripMenuItem, deleteOrderToolStripMenuItem, productionHistoryToolStripMenuItem, kalanSiparişiTamamlaToolStripMenuItem, tümünüSeçToolStripMenuItem, aynıMüşterininSiparişleriniSeçToolStripMenuItem, seçimleriKaldırToolStripMenuItem });
            cmsOrders.Name = "cmsOrders";
            cmsOrders.Size = new Size(289, 196);
            cmsOrders.Opening += cmsOrders_Opening;
            // 
            // addOrderToolStripMenuItem
            // 
            addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            addOrderToolStripMenuItem.Size = new Size(288, 24);
            addOrderToolStripMenuItem.Text = "Ekle";
            addOrderToolStripMenuItem.Click += addOrderToolStripMenuItem_Click;
            // 
            // updateOrderToolStripMenuItem
            // 
            updateOrderToolStripMenuItem.Name = "updateOrderToolStripMenuItem";
            updateOrderToolStripMenuItem.Size = new Size(288, 24);
            updateOrderToolStripMenuItem.Text = "Güncelle";
            updateOrderToolStripMenuItem.Click += updateOrderToolStripMenuItem_Click;
            // 
            // deleteOrderToolStripMenuItem
            // 
            deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            deleteOrderToolStripMenuItem.Size = new Size(288, 24);
            deleteOrderToolStripMenuItem.Text = "Sil";
            deleteOrderToolStripMenuItem.Click += deleteOrderToolStripMenuItem_Click;
            // 
            // productionHistoryToolStripMenuItem
            // 
            productionHistoryToolStripMenuItem.Name = "productionHistoryToolStripMenuItem";
            productionHistoryToolStripMenuItem.Size = new Size(288, 24);
            productionHistoryToolStripMenuItem.Text = "Üretim Geçmişi";
            productionHistoryToolStripMenuItem.Click += productionHistoryToolStripMenuItem_Click;
            // 
            // kalanSiparişiTamamlaToolStripMenuItem
            // 
            kalanSiparişiTamamlaToolStripMenuItem.Name = "kalanSiparişiTamamlaToolStripMenuItem";
            kalanSiparişiTamamlaToolStripMenuItem.Size = new Size(288, 24);
            kalanSiparişiTamamlaToolStripMenuItem.Text = "Siparişi Tamamla";
            kalanSiparişiTamamlaToolStripMenuItem.Click += completeOrderToolStripMenuItem_Click;
            // 
            // tümünüSeçToolStripMenuItem
            // 
            tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            tümünüSeçToolStripMenuItem.Size = new Size(288, 24);
            tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            tümünüSeçToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // aynıMüşterininSiparişleriniSeçToolStripMenuItem
            // 
            aynıMüşterininSiparişleriniSeçToolStripMenuItem.Name = "aynıMüşterininSiparişleriniSeçToolStripMenuItem";
            aynıMüşterininSiparişleriniSeçToolStripMenuItem.Size = new Size(288, 24);
            aynıMüşterininSiparişleriniSeçToolStripMenuItem.Text = "Aynı Müşterinin Siparişlerini Seç";
            aynıMüşterininSiparişleriniSeçToolStripMenuItem.Click += selectSameCustomersOrdersToolStripMenuItem_Click;
            // 
            // seçimleriKaldırToolStripMenuItem
            // 
            seçimleriKaldırToolStripMenuItem.Name = "seçimleriKaldırToolStripMenuItem";
            seçimleriKaldırToolStripMenuItem.Size = new Size(288, 24);
            seçimleriKaldırToolStripMenuItem.Text = "Seçimleri Kaldır";
            seçimleriKaldırToolStripMenuItem.Click += uncheckAllToolStripMenuItem_Click;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabOrders);
            tabMain.Controls.Add(tabStock);
            tabMain.Controls.Add(tabCustomer);
            tabMain.Controls.Add(tabReports);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1554, 907);
            tabMain.TabIndex = 0;
            // 
            // tabStock
            // 
            tabStock.Controls.Add(gbProducts);
            tabStock.Location = new Point(4, 29);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3, 3, 3, 3);
            tabStock.Size = new Size(1546, 874);
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
            gbProducts.Location = new Point(6, 5);
            gbProducts.Name = "gbProducts";
            gbProducts.Size = new Size(1531, 863);
            gbProducts.TabIndex = 0;
            gbProducts.TabStop = false;
            gbProducts.Text = "Stok Kartları";
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Location = new Point(1289, 28);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(32, 20);
            lblSearchProduct.TabIndex = 8;
            lblSearchProduct.Text = "Ara";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchProduct.Location = new Point(1327, 27);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(198, 27);
            txtSearchProduct.TabIndex = 7;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(6, 24);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(106, 24);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(94, 29);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnRefreshStock
            // 
            btnRefreshStock.Location = new Point(306, 24);
            btnRefreshStock.Name = "btnRefreshStock";
            btnRefreshStock.Size = new Size(94, 29);
            btnRefreshStock.TabIndex = 2;
            btnRefreshStock.Text = "Yenile";
            btnRefreshStock.UseVisualStyleBackColor = true;
            btnRefreshStock.Click += btnRefreshStock_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(206, 24);
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
            lvProducts.Columns.AddRange(new ColumnHeader[] { clmName, clmCode, clmProcessType, clmIsCounting, clmLastCost, clmLastPrice, clmLastProfit, clmLastProfitRatio });
            lvProducts.Font = new Font("Segoe UI", 10F);
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(6, 59);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(1519, 797);
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
            tabCustomer.Location = new Point(4, 29);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3, 3, 3, 3);
            tabCustomer.Size = new Size(1546, 874);
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
            gbCustomers.Size = new Size(1531, 863);
            gbCustomers.TabIndex = 0;
            gbCustomers.TabStop = false;
            gbCustomers.Text = "Cariler";
            // 
            // lblSearchCustomer
            // 
            lblSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearchCustomer.AutoSize = true;
            lblSearchCustomer.Location = new Point(1289, 29);
            lblSearchCustomer.Name = "lblSearchCustomer";
            lblSearchCustomer.Size = new Size(32, 20);
            lblSearchCustomer.TabIndex = 6;
            lblSearchCustomer.Text = "Ara";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchCustomer.Location = new Point(1327, 27);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(198, 27);
            txtSearchCustomer.TabIndex = 5;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // btnRefreshCustomer
            // 
            btnRefreshCustomer.Location = new Point(306, 24);
            btnRefreshCustomer.Name = "btnRefreshCustomer";
            btnRefreshCustomer.Size = new Size(94, 29);
            btnRefreshCustomer.TabIndex = 2;
            btnRefreshCustomer.Text = "Yenile";
            btnRefreshCustomer.UseVisualStyleBackColor = true;
            btnRefreshCustomer.Click += btnRefreshCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(206, 24);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(94, 29);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Sil";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(106, 24);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(94, 29);
            btnUpdateCustomer.TabIndex = 3;
            btnUpdateCustomer.Text = "Güncelle";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(6, 24);
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
            lvCustomers.Columns.AddRange(new ColumnHeader[] { clmCustomerName, clmCountry, clmCity, clmDescription, clmContactName, clmContactPhone, clmAddress, clmTotalPrice });
            lvCustomers.Font = new Font("Segoe UI", 10F);
            lvCustomers.FullRowSelect = true;
            lvCustomers.GridLines = true;
            lvCustomers.Location = new Point(5, 59);
            lvCustomers.MultiSelect = false;
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(1519, 797);
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
            // clmTotalPrice
            // 
            clmTotalPrice.Text = "Toplam Satış Tutarı";
            // 
            // tabReports
            // 
            tabReports.Controls.Add(gbTotals);
            tabReports.Controls.Add(gbProductionReportDetails);
            tabReports.Controls.Add(gbProductionReport);
            tabReports.Location = new Point(4, 29);
            tabReports.Name = "tabReports";
            tabReports.Padding = new Padding(3, 3, 3, 3);
            tabReports.Size = new Size(1546, 874);
            tabReports.TabIndex = 3;
            tabReports.Text = "Raporlar";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // gbTotals
            // 
            gbTotals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gbTotals.Controls.Add(txtStockQuantity);
            gbTotals.Controls.Add(lblStockQuantity);
            gbTotals.Controls.Add(txtProcessQuantity);
            gbTotals.Controls.Add(lblProcessQuantity);
            gbTotals.Controls.Add(txtProfitWithoutOutgoing);
            gbTotals.Controls.Add(lbProfitWithoutOutgoing);
            gbTotals.Controls.Add(txtOutgoing);
            gbTotals.Controls.Add(lbOutgoing);
            gbTotals.Controls.Add(txtProducedQuantity);
            gbTotals.Controls.Add(txtProfitRatio);
            gbTotals.Controls.Add(lblProducedQuantity);
            gbTotals.Controls.Add(lbProfitRatio);
            gbTotals.Controls.Add(txtProfitMargin);
            gbTotals.Controls.Add(lbProfitMargin);
            gbTotals.Controls.Add(txtProfit);
            gbTotals.Controls.Add(lbProfit);
            gbTotals.Controls.Add(txtCostWithTax);
            gbTotals.Controls.Add(lbCostWithTax);
            gbTotals.Controls.Add(txtCostTax);
            gbTotals.Controls.Add(lbCostTax);
            gbTotals.Controls.Add(txtCost);
            gbTotals.Controls.Add(lbCost);
            gbTotals.Controls.Add(txtPriceWithTax);
            gbTotals.Controls.Add(lbPriceWithTax);
            gbTotals.Controls.Add(txtPriceTax);
            gbTotals.Controls.Add(lbPriceTax);
            gbTotals.Controls.Add(txtPrice);
            gbTotals.Controls.Add(lbPrice);
            gbTotals.Location = new Point(6, 701);
            gbTotals.Name = "gbTotals";
            gbTotals.Size = new Size(1157, 167);
            gbTotals.TabIndex = 3;
            gbTotals.TabStop = false;
            gbTotals.Text = "Toplamlar";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(720, 123);
            txtStockQuantity.MaxLength = 25;
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.ReadOnly = true;
            txtStockQuantity.Size = new Size(133, 27);
            txtStockQuantity.TabIndex = 24;
            txtStockQuantity.TabStop = false;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(606, 125);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(88, 20);
            lblStockQuantity.TabIndex = 23;
            lblStockQuantity.Text = "Stok Miktarı";
            // 
            // txtProcessQuantity
            // 
            txtProcessQuantity.Location = new Point(434, 123);
            txtProcessQuantity.MaxLength = 25;
            txtProcessQuantity.Name = "txtProcessQuantity";
            txtProcessQuantity.ReadOnly = true;
            txtProcessQuantity.Size = new Size(133, 27);
            txtProcessQuantity.TabIndex = 22;
            txtProcessQuantity.TabStop = false;
            // 
            // lblProcessQuantity
            // 
            lblProcessQuantity.AutoSize = true;
            lblProcessQuantity.Location = new Point(293, 125);
            lblProcessQuantity.Name = "lblProcessQuantity";
            lblProcessQuantity.Size = new Size(102, 20);
            lblProcessQuantity.TabIndex = 21;
            lblProcessQuantity.Text = "İşleme Miktarı";
            // 
            // txtProfitWithoutOutgoing
            // 
            txtProfitWithoutOutgoing.Location = new Point(720, 89);
            txtProfitWithoutOutgoing.MaxLength = 25;
            txtProfitWithoutOutgoing.Name = "txtProfitWithoutOutgoing";
            txtProfitWithoutOutgoing.ReadOnly = true;
            txtProfitWithoutOutgoing.Size = new Size(133, 27);
            txtProfitWithoutOutgoing.TabIndex = 18;
            txtProfitWithoutOutgoing.TabStop = false;
            // 
            // lbProfitWithoutOutgoing
            // 
            lbProfitWithoutOutgoing.AutoSize = true;
            lbProfitWithoutOutgoing.Location = new Point(606, 92);
            lbProfitWithoutOutgoing.Name = "lbProfitWithoutOutgoing";
            lbProfitWithoutOutgoing.Size = new Size(81, 20);
            lbProfitWithoutOutgoing.TabIndex = 0;
            lbProfitWithoutOutgoing.Text = "Gider - Kar";
            // 
            // txtOutgoing
            // 
            txtOutgoing.Location = new Point(720, 56);
            txtOutgoing.MaxLength = 25;
            txtOutgoing.Name = "txtOutgoing";
            txtOutgoing.ReadOnly = true;
            txtOutgoing.Size = new Size(133, 27);
            txtOutgoing.TabIndex = 17;
            txtOutgoing.TabStop = false;
            // 
            // lbOutgoing
            // 
            lbOutgoing.AutoSize = true;
            lbOutgoing.Location = new Point(606, 59);
            lbOutgoing.Name = "lbOutgoing";
            lbOutgoing.Size = new Size(83, 20);
            lbOutgoing.TabIndex = 0;
            lbOutgoing.Text = "Sabit Gider";
            // 
            // txtProducedQuantity
            // 
            txtProducedQuantity.Location = new Point(133, 123);
            txtProducedQuantity.MaxLength = 25;
            txtProducedQuantity.Name = "txtProducedQuantity";
            txtProducedQuantity.ReadOnly = true;
            txtProducedQuantity.Size = new Size(133, 27);
            txtProducedQuantity.TabIndex = 20;
            txtProducedQuantity.TabStop = false;
            // 
            // txtProfitRatio
            // 
            txtProfitRatio.Location = new Point(1017, 56);
            txtProfitRatio.MaxLength = 25;
            txtProfitRatio.Name = "txtProfitRatio";
            txtProfitRatio.ReadOnly = true;
            txtProfitRatio.Size = new Size(133, 27);
            txtProfitRatio.TabIndex = 20;
            txtProfitRatio.TabStop = false;
            // 
            // lblProducedQuantity
            // 
            lblProducedQuantity.AutoSize = true;
            lblProducedQuantity.Location = new Point(6, 125);
            lblProducedQuantity.Name = "lblProducedQuantity";
            lblProducedQuantity.Size = new Size(104, 20);
            lblProducedQuantity.TabIndex = 0;
            lblProducedQuantity.Text = "Üretim Miktarı";
            // 
            // lbProfitRatio
            // 
            lbProfitRatio.AutoSize = true;
            lbProfitRatio.Location = new Point(898, 59);
            lbProfitRatio.Name = "lbProfitRatio";
            lbProfitRatio.Size = new Size(99, 20);
            lbProfitRatio.TabIndex = 0;
            lbProfitRatio.Text = "S.G. Kar Oranı";
            // 
            // txtProfitMargin
            // 
            txtProfitMargin.Location = new Point(1017, 23);
            txtProfitMargin.MaxLength = 25;
            txtProfitMargin.Name = "txtProfitMargin";
            txtProfitMargin.ReadOnly = true;
            txtProfitMargin.Size = new Size(133, 27);
            txtProfitMargin.TabIndex = 19;
            txtProfitMargin.TabStop = false;
            // 
            // lbProfitMargin
            // 
            lbProfitMargin.AutoSize = true;
            lbProfitMargin.Location = new Point(898, 27);
            lbProfitMargin.Name = "lbProfitMargin";
            lbProfitMargin.Size = new Size(71, 20);
            lbProfitMargin.TabIndex = 0;
            lbProfitMargin.Text = "Kar Oranı";
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(720, 23);
            txtProfit.MaxLength = 25;
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(133, 27);
            txtProfit.TabIndex = 16;
            txtProfit.TabStop = false;
            // 
            // lbProfit
            // 
            lbProfit.AutoSize = true;
            lbProfit.Location = new Point(606, 27);
            lbProfit.Name = "lbProfit";
            lbProfit.Size = new Size(31, 20);
            lbProfit.TabIndex = 0;
            lbProfit.Text = "Kar";
            // 
            // txtCostWithTax
            // 
            txtCostWithTax.Location = new Point(434, 89);
            txtCostWithTax.MaxLength = 25;
            txtCostWithTax.Name = "txtCostWithTax";
            txtCostWithTax.ReadOnly = true;
            txtCostWithTax.Size = new Size(133, 27);
            txtCostWithTax.TabIndex = 15;
            txtCostWithTax.TabStop = false;
            // 
            // lbCostWithTax
            // 
            lbCostWithTax.AutoSize = true;
            lbCostWithTax.Location = new Point(293, 92);
            lbCostWithTax.Name = "lbCostWithTax";
            lbCostWithTax.Size = new Size(135, 20);
            lbCostWithTax.TabIndex = 0;
            lbCostWithTax.Text = "Vergi Dahil Maliyet";
            // 
            // txtCostTax
            // 
            txtCostTax.Location = new Point(434, 56);
            txtCostTax.MaxLength = 25;
            txtCostTax.Name = "txtCostTax";
            txtCostTax.ReadOnly = true;
            txtCostTax.Size = new Size(133, 27);
            txtCostTax.TabIndex = 14;
            txtCostTax.TabStop = false;
            // 
            // lbCostTax
            // 
            lbCostTax.AutoSize = true;
            lbCostTax.Location = new Point(293, 59);
            lbCostTax.Name = "lbCostTax";
            lbCostTax.Size = new Size(85, 20);
            lbCostTax.TabIndex = 0;
            lbCostTax.Text = "Vergi Tutarı";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(434, 23);
            txtCost.MaxLength = 25;
            txtCost.Name = "txtCost";
            txtCost.ReadOnly = true;
            txtCost.Size = new Size(133, 27);
            txtCost.TabIndex = 13;
            txtCost.TabStop = false;
            // 
            // lbCost
            // 
            lbCost.AutoSize = true;
            lbCost.Location = new Point(293, 27);
            lbCost.Name = "lbCost";
            lbCost.Size = new Size(58, 20);
            lbCost.TabIndex = 0;
            lbCost.Text = "Maliyet";
            // 
            // txtPriceWithTax
            // 
            txtPriceWithTax.Location = new Point(133, 89);
            txtPriceWithTax.MaxLength = 25;
            txtPriceWithTax.Name = "txtPriceWithTax";
            txtPriceWithTax.ReadOnly = true;
            txtPriceWithTax.Size = new Size(133, 27);
            txtPriceWithTax.TabIndex = 12;
            txtPriceWithTax.TabStop = false;
            // 
            // lbPriceWithTax
            // 
            lbPriceWithTax.AutoSize = true;
            lbPriceWithTax.Location = new Point(6, 92);
            lbPriceWithTax.Name = "lbPriceWithTax";
            lbPriceWithTax.Size = new Size(120, 20);
            lbPriceWithTax.TabIndex = 0;
            lbPriceWithTax.Text = "Vergi Dahil Tutar";
            // 
            // txtPriceTax
            // 
            txtPriceTax.Location = new Point(133, 56);
            txtPriceTax.MaxLength = 25;
            txtPriceTax.Name = "txtPriceTax";
            txtPriceTax.ReadOnly = true;
            txtPriceTax.Size = new Size(133, 27);
            txtPriceTax.TabIndex = 11;
            txtPriceTax.TabStop = false;
            // 
            // lbPriceTax
            // 
            lbPriceTax.AutoSize = true;
            lbPriceTax.Location = new Point(6, 59);
            lbPriceTax.Name = "lbPriceTax";
            lbPriceTax.Size = new Size(85, 20);
            lbPriceTax.TabIndex = 0;
            lbPriceTax.Text = "Vergi Tutarı";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(133, 23);
            txtPrice.MaxLength = 25;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(133, 27);
            txtPrice.TabIndex = 10;
            txtPrice.TabStop = false;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(6, 27);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(43, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Tutar";
            // 
            // gbProductionReportDetails
            // 
            gbProductionReportDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbProductionReportDetails.Controls.Add(cbIsOvertime);
            gbProductionReportDetails.Controls.Add(cbCalculateAllInterval);
            gbProductionReportDetails.Controls.Add(label1);
            gbProductionReportDetails.Controls.Add(nudOutgoing);
            gbProductionReportDetails.Controls.Add(gbReportType);
            gbProductionReportDetails.Controls.Add(dtpDate);
            gbProductionReportDetails.Controls.Add(btnCopyTable);
            gbProductionReportDetails.Controls.Add(btnCreateReport);
            gbProductionReportDetails.Controls.Add(gbReportInterval);
            gbProductionReportDetails.Location = new Point(1303, 5);
            gbProductionReportDetails.Name = "gbProductionReportDetails";
            gbProductionReportDetails.Size = new Size(235, 653);
            gbProductionReportDetails.TabIndex = 2;
            gbProductionReportDetails.TabStop = false;
            gbProductionReportDetails.Text = "Rapor Detayları";
            // 
            // cbIsOvertime
            // 
            cbIsOvertime.AutoSize = true;
            cbIsOvertime.Location = new Point(6, 383);
            cbIsOvertime.Name = "cbIsOvertime";
            cbIsOvertime.Size = new Size(122, 24);
            cbIsOvertime.TabIndex = 11;
            cbIsOvertime.Text = "Mesai Raporu";
            cbIsOvertime.UseVisualStyleBackColor = true;
            cbIsOvertime.CheckedChanged += cbIsOvertime_CheckedChanged;
            // 
            // cbCalculateAllInterval
            // 
            cbCalculateAllInterval.AutoSize = true;
            cbCalculateAllInterval.Location = new Point(6, 353);
            cbCalculateAllInterval.Name = "cbCalculateAllInterval";
            cbCalculateAllInterval.Size = new Size(176, 24);
            cbCalculateAllInterval.TabIndex = 8;
            cbCalculateAllInterval.Text = "Gelecek tarihi hesapla";
            cbCalculateAllInterval.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 296);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 7;
            label1.Text = "Günlük Gider";
            // 
            // nudOutgoing
            // 
            nudOutgoing.DecimalPlaces = 2;
            nudOutgoing.Location = new Point(6, 320);
            nudOutgoing.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudOutgoing.Name = "nudOutgoing";
            nudOutgoing.Size = new Size(224, 27);
            nudOutgoing.TabIndex = 7;
            // 
            // gbReportType
            // 
            gbReportType.Controls.Add(rbSales);
            gbReportType.Controls.Add(rbProduction);
            gbReportType.Location = new Point(6, 184);
            gbReportType.Name = "gbReportType";
            gbReportType.Size = new Size(224, 64);
            gbReportType.TabIndex = 5;
            gbReportType.TabStop = false;
            gbReportType.Text = "Rapor Türü";
            // 
            // rbSales
            // 
            rbSales.AutoSize = true;
            rbSales.Location = new Point(119, 27);
            rbSales.Name = "rbSales";
            rbSales.Size = new Size(61, 24);
            rbSales.TabIndex = 4;
            rbSales.Text = "Satış";
            rbSales.UseVisualStyleBackColor = true;
            // 
            // rbProduction
            // 
            rbProduction.AutoSize = true;
            rbProduction.Checked = true;
            rbProduction.Location = new Point(21, 27);
            rbProduction.Name = "rbProduction";
            rbProduction.Size = new Size(75, 24);
            rbProduction.TabIndex = 5;
            rbProduction.TabStop = true;
            rbProduction.Text = "Üretim";
            rbProduction.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(6, 253);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(223, 27);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // btnCopyTable
            // 
            btnCopyTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopyTable.Location = new Point(6, 619);
            btnCopyTable.Name = "btnCopyTable";
            btnCopyTable.Size = new Size(223, 29);
            btnCopyTable.TabIndex = 10;
            btnCopyTable.Text = "Tabloyu Kopyala";
            btnCopyTable.UseVisualStyleBackColor = true;
            btnCopyTable.Click += btnCopyTable_Click;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateReport.Location = new Point(6, 583);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(223, 29);
            btnCreateReport.TabIndex = 9;
            btnCreateReport.Text = "Oluştur";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // gbReportInterval
            // 
            gbReportInterval.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbReportInterval.Controls.Add(rbDaily);
            gbReportInterval.Controls.Add(rbYearly);
            gbReportInterval.Controls.Add(rbWeekly);
            gbReportInterval.Controls.Add(rbMonthly);
            gbReportInterval.Location = new Point(6, 27);
            gbReportInterval.Name = "gbReportInterval";
            gbReportInterval.Size = new Size(224, 152);
            gbReportInterval.TabIndex = 2;
            gbReportInterval.TabStop = false;
            gbReportInterval.Text = "Rapor Dönemi";
            // 
            // rbDaily
            // 
            rbDaily.AutoSize = true;
            rbDaily.Checked = true;
            rbDaily.Location = new Point(21, 27);
            rbDaily.Name = "rbDaily";
            rbDaily.Size = new Size(75, 24);
            rbDaily.TabIndex = 0;
            rbDaily.TabStop = true;
            rbDaily.Text = "Günlük";
            rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbYearly
            // 
            rbYearly.AutoSize = true;
            rbYearly.Location = new Point(21, 116);
            rbYearly.Name = "rbYearly";
            rbYearly.Size = new Size(61, 24);
            rbYearly.TabIndex = 3;
            rbYearly.Text = "Yıllık";
            rbYearly.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            rbWeekly.AutoSize = true;
            rbWeekly.Location = new Point(21, 56);
            rbWeekly.Name = "rbWeekly";
            rbWeekly.Size = new Size(82, 24);
            rbWeekly.TabIndex = 1;
            rbWeekly.Text = "Haftalık";
            rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            rbMonthly.AutoSize = true;
            rbMonthly.Location = new Point(21, 85);
            rbMonthly.Name = "rbMonthly";
            rbMonthly.Size = new Size(62, 24);
            rbMonthly.TabIndex = 2;
            rbMonthly.Text = "Aylık";
            rbMonthly.UseVisualStyleBackColor = true;
            // 
            // gbProductionReport
            // 
            gbProductionReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProductionReport.Controls.Add(dgReport);
            gbProductionReport.Location = new Point(8, 5);
            gbProductionReport.Name = "gbProductionReport";
            gbProductionReport.Size = new Size(1289, 691);
            gbProductionReport.TabIndex = 1;
            gbProductionReport.TabStop = false;
            gbProductionReport.Text = "Rapor";
            // 
            // dgReport
            // 
            dgReport.AllowUserToAddRows = false;
            dgReport.AllowUserToDeleteRows = false;
            dgReport.AllowUserToOrderColumns = true;
            dgReport.AllowUserToResizeColumns = false;
            dgReport.AllowUserToResizeRows = false;
            dgReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgReport.BorderStyle = BorderStyle.None;
            dgReport.ColumnHeadersHeight = 29;
            dgReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgReport.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgReport.Location = new Point(6, 27);
            dgReport.Name = "dgReport";
            dgReport.ReadOnly = true;
            dgReport.RowHeadersVisible = false;
            dgReport.RowHeadersWidth = 51;
            dgReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgReport.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgReport.ShowCellErrors = false;
            dgReport.ShowCellToolTips = false;
            dgReport.ShowEditingIcon = false;
            dgReport.ShowRowErrors = false;
            dgReport.Size = new Size(1275, 656);
            dgReport.TabIndex = 0;
            // 
            // FormMain
            // 
            AcceptButton = btnCreateReport;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 907);
            Controls.Add(tabMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1570, 916);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enezcam ERP";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            Load += Main_Load;
            tabOrders.ResumeLayout(false);
            gbOrders.ResumeLayout(false);
            gbOrders.PerformLayout();
            gbOrdersTotals.ResumeLayout(false);
            gbOrdersTotals.PerformLayout();
            gbDateFilterSettings.ResumeLayout(false);
            gbDateFilterSettings.PerformLayout();
            cmsOrders.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabStock.ResumeLayout(false);
            gbProducts.ResumeLayout(false);
            gbProducts.PerformLayout();
            tabCustomer.ResumeLayout(false);
            gbCustomers.ResumeLayout(false);
            gbCustomers.PerformLayout();
            tabReports.ResumeLayout(false);
            gbTotals.ResumeLayout(false);
            gbTotals.PerformLayout();
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
        private ColumnHeader clmProfit;
        private ColumnHeader clmProfitRatio;
        private TabControl tabMain;
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
        private Button btnCreateReport;
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
        private Button btnCopyTable;
        private GroupBox gbTotals;
        private Label lbPrice;
        private TextBox txtPrice;
        private TextBox txtPriceWithTax;
        private Label lbPriceWithTax;
        private TextBox txtPriceTax;
        private Label lbPriceTax;
        private TextBox txtProfit;
        private Label lbProfit;
        private TextBox txtCostWithTax;
        private Label lbCostWithTax;
        private TextBox txtCostTax;
        private Label lbCostTax;
        private TextBox txtCost;
        private Label lbCost;
        private TextBox txtProfitWithoutOutgoing;
        private Label lbProfitWithoutOutgoing;
        private TextBox txtOutgoing;
        private Label lbOutgoing;
        private TextBox txtProfitMargin;
        private Label lbProfitMargin;
        private TextBox txtProfitRatio;
        private Label lbProfitRatio;
        private ContextMenuStrip cmsOrders;
        private ToolStripMenuItem addOrderToolStripMenuItem;
        private ToolStripMenuItem updateOrderToolStripMenuItem;
        private ToolStripMenuItem deleteOrderToolStripMenuItem;
        private ToolStripMenuItem productionHistoryToolStripMenuItem;
        private ColumnHeader clmCompletedDate;
        private ColumnHeader clmRemainingQuantity;
        private ToolStripMenuItem kalanSiparişiTamamlaToolStripMenuItem;
        private TextBox txtProducedQuantity;
        private Label lblProducedQuantity;
        private TextBox txtProcessQuantity;
        private Label lblProcessQuantity;
        private TextBox txtStockQuantity;
        private Label lblStockQuantity;
        private GroupBox gbOrdersTotals;
        private TextBox txtTotalProducedQuantity;
        private TextBox txtTotalQuantity;
        private Label lblTotalProducedQuantity;
        private Label lblTotalQuantity;
        private TextBox txtTotalRemainingQuantity;
        private Label lblTotalRemainingQuantity;
        private TextBox txtTotalPrice;
        private TextBox txtTotalCost;
        private Label lblTotalPrice;
        private Label lblTotalCost;
        private TextBox txtTotalPriceWithTax;
        private Label lblTotalPriceWithTax;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private ToolStripMenuItem seçimleriKaldırToolStripMenuItem;
        private ToolStripMenuItem aynıMüşterininSiparişleriniSeçToolStripMenuItem;
        private CheckBox cbCalculateAllInterval;
        private ColumnHeader clmTotalPrice;
        private RadioButton rbDeliveryDate;
        private ColumnHeader clmDeliveryDate;
        private CheckBox cbIsOvertime;
        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Button btnLastPage;
        private Button btnFirstPage;
    }
}
