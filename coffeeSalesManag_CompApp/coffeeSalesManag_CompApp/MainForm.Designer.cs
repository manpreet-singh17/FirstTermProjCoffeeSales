namespace coffeeSalesManag_CompApp
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.lblCoffeeQuantity = new System.Windows.Forms.Label();
            this.lblCoffeePrice = new System.Windows.Forms.Label();
            this.lblCoffeeTotal = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbMainForm_CoffeeName = new System.Windows.Forms.ComboBox();
            this.lblCustomerAge = new System.Windows.Forms.Label();
            this.txtMainFrm_Price = new System.Windows.Forms.TextBox();
            this.txtMainForm_Total = new System.Windows.Forms.TextBox();
            this.txtMainFrm_CustName = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnRefreshFields = new System.Windows.Forms.Button();
            this.dataGridViewMainWindow = new System.Windows.Forms.DataGridView();
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.manageCoffees = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSales = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCust = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem_logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.backUp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainFormMobNum = new System.Windows.Forms.Label();
            this.txtMainFrm_CustMobNum = new System.Windows.Forms.TextBox();
            this.txtMainFrm_Quantity = new System.Windows.Forms.TextBox();
            this.txtMainFrm_CustAge = new System.Windows.Forms.TextBox();
            this.txtMainFrm_Password = new System.Windows.Forms.TextBox();
            this.txtMainFrm_userName = new System.Windows.Forms.TextBox();
            this.lblMainFrm_Password = new System.Windows.Forms.Label();
            this.lblMainFrm_userName = new System.Windows.Forms.Label();
            this.btnMainFrm_Login = new System.Windows.Forms.Button();
            this.lblMainFrm_Gender = new System.Windows.Forms.Label();
            this.cbMainFrm_Gender = new System.Windows.Forms.ComboBox();
            this.lblMainForm_SaleCountHeading = new System.Windows.Forms.Label();
            this.txtMainForm_SaleCount = new System.Windows.Forms.Label();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainWindow)).BeginInit();
            this.menuStripMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeName.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeName.Location = new System.Drawing.Point(6, 36);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(121, 18);
            this.lblCoffeeName.TabIndex = 0;
            this.lblCoffeeName.Text = "Coffee Name:";
            // 
            // lblCoffeeQuantity
            // 
            this.lblCoffeeQuantity.AutoSize = true;
            this.lblCoffeeQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeQuantity.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeQuantity.Location = new System.Drawing.Point(6, 105);
            this.lblCoffeeQuantity.Name = "lblCoffeeQuantity";
            this.lblCoffeeQuantity.Size = new System.Drawing.Size(86, 18);
            this.lblCoffeeQuantity.TabIndex = 1;
            this.lblCoffeeQuantity.Text = "Quantity:";
            // 
            // lblCoffeePrice
            // 
            this.lblCoffeePrice.AutoSize = true;
            this.lblCoffeePrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeePrice.ForeColor = System.Drawing.Color.White;
            this.lblCoffeePrice.Location = new System.Drawing.Point(7, 68);
            this.lblCoffeePrice.Name = "lblCoffeePrice";
            this.lblCoffeePrice.Size = new System.Drawing.Size(54, 18);
            this.lblCoffeePrice.TabIndex = 2;
            this.lblCoffeePrice.Text = "Price:";
            // 
            // lblCoffeeTotal
            // 
            this.lblCoffeeTotal.AutoSize = true;
            this.lblCoffeeTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeTotal.ForeColor = System.Drawing.Color.White;
            this.lblCoffeeTotal.Location = new System.Drawing.Point(7, 134);
            this.lblCoffeeTotal.Name = "lblCoffeeTotal";
            this.lblCoffeeTotal.Size = new System.Drawing.Size(55, 18);
            this.lblCoffeeTotal.TabIndex = 3;
            this.lblCoffeeTotal.Text = "Total:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(10, 40);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(146, 18);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // cbMainForm_CoffeeName
            // 
            this.cbMainForm_CoffeeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMainForm_CoffeeName.FormattingEnabled = true;
            this.cbMainForm_CoffeeName.Location = new System.Drawing.Point(161, 33);
            this.cbMainForm_CoffeeName.Name = "cbMainForm_CoffeeName";
            this.cbMainForm_CoffeeName.Size = new System.Drawing.Size(150, 26);
            this.cbMainForm_CoffeeName.TabIndex = 4;
            this.cbMainForm_CoffeeName.SelectedIndexChanged += new System.EventHandler(this.cbCoffeeNames_SelectedIndexChanged);
            this.cbMainForm_CoffeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCoffeeNames_KeyPress);
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.AutoSize = true;
            this.lblCustomerAge.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAge.ForeColor = System.Drawing.Color.White;
            this.lblCustomerAge.Location = new System.Drawing.Point(10, 72);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(46, 18);
            this.lblCustomerAge.TabIndex = 6;
            this.lblCustomerAge.Text = "Age:";
            // 
            // txtMainFrm_Price
            // 
            this.txtMainFrm_Price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMainFrm_Price.Location = new System.Drawing.Point(160, 65);
            this.txtMainFrm_Price.Name = "txtMainFrm_Price";
            this.txtMainFrm_Price.ReadOnly = true;
            this.txtMainFrm_Price.Size = new System.Drawing.Size(151, 26);
            this.txtMainFrm_Price.TabIndex = 5;
            // 
            // txtMainForm_Total
            // 
            this.txtMainForm_Total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMainForm_Total.Location = new System.Drawing.Point(160, 131);
            this.txtMainForm_Total.Name = "txtMainForm_Total";
            this.txtMainForm_Total.ReadOnly = true;
            this.txtMainForm_Total.Size = new System.Drawing.Size(151, 26);
            this.txtMainForm_Total.TabIndex = 7;
            // 
            // txtMainFrm_CustName
            // 
            this.txtMainFrm_CustName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMainFrm_CustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainFrm_CustName.Location = new System.Drawing.Point(174, 37);
            this.txtMainFrm_CustName.Name = "txtMainFrm_CustName";
            this.txtMainFrm_CustName.Size = new System.Drawing.Size(150, 26);
            this.txtMainFrm_CustName.TabIndex = 8;
            this.txtMainFrm_CustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMainFrm_CustName_KeyPress);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSale.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSale.ForeColor = System.Drawing.Color.White;
            this.btnAddSale.Location = new System.Drawing.Point(12, 646);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(90, 35);
            this.btnAddSale.TabIndex = 12;
            this.btnAddSale.Text = "ADD SALE";
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnRefreshFields
            // 
            this.btnRefreshFields.BackColor = System.Drawing.Color.DarkRed;
            this.btnRefreshFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshFields.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshFields.ForeColor = System.Drawing.Color.White;
            this.btnRefreshFields.Location = new System.Drawing.Point(111, 646);
            this.btnRefreshFields.Name = "btnRefreshFields";
            this.btnRefreshFields.Size = new System.Drawing.Size(90, 35);
            this.btnRefreshFields.TabIndex = 13;
            this.btnRefreshFields.Text = "REFRESH";
            this.btnRefreshFields.UseVisualStyleBackColor = false;
            this.btnRefreshFields.Click += new System.EventHandler(this.btnRefreshFields_Click);
            // 
            // dataGridViewMainWindow
            // 
            this.dataGridViewMainWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainWindow.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewMainWindow.Name = "dataGridViewMainWindow";
            this.dataGridViewMainWindow.ReadOnly = true;
            this.dataGridViewMainWindow.Size = new System.Drawing.Size(847, 124);
            this.dataGridViewMainWindow.TabIndex = 14;
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCoffees,
            this.manageSales,
            this.manageCust,
            this.manageEmp,
            this.exit,
            this.menuStripItem_logOut,
            this.backUp});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(1362, 24);
            this.menuStripMainForm.TabIndex = 15;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // manageCoffees
            // 
            this.manageCoffees.Name = "manageCoffees";
            this.manageCoffees.Size = new System.Drawing.Size(105, 20);
            this.manageCoffees.Text = "Manage Coffees";
            this.manageCoffees.Click += new System.EventHandler(this.showManageCoffeeForm);
            // 
            // manageSales
            // 
            this.manageSales.Name = "manageSales";
            this.manageSales.Size = new System.Drawing.Size(91, 20);
            this.manageSales.Text = "Manage Sales";
            this.manageSales.Click += new System.EventHandler(this.showManageSalesForm);
            // 
            // manageCust
            // 
            this.manageCust.Name = "manageCust";
            this.manageCust.Size = new System.Drawing.Size(122, 20);
            this.manageCust.Text = "Manage Customers";
            this.manageCust.Click += new System.EventHandler(this.showManageCustForm);
            // 
            // manageEmp
            // 
            this.manageEmp.Name = "manageEmp";
            this.manageEmp.Size = new System.Drawing.Size(117, 20);
            this.manageEmp.Text = "Manage Employee";
            this.manageEmp.Click += new System.EventHandler(this.manageEmp_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(37, 20);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menuStripItem_logOut
            // 
            this.menuStripItem_logOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuStripItem_logOut.Name = "menuStripItem_logOut";
            this.menuStripItem_logOut.Size = new System.Drawing.Size(62, 20);
            this.menuStripItem_logOut.Text = "Log Out";
            this.menuStripItem_logOut.Click += new System.EventHandler(this.menuStripItem_logOut_Click);
            // 
            // backUp
            // 
            this.backUp.Name = "backUp";
            this.backUp.Size = new System.Drawing.Size(59, 20);
            this.backUp.Text = "BackUp";
            this.backUp.Click += new System.EventHandler(this.backUp_Click);
            // 
            // lblMainFormMobNum
            // 
            this.lblMainFormMobNum.AutoSize = true;
            this.lblMainFormMobNum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainFormMobNum.ForeColor = System.Drawing.Color.White;
            this.lblMainFormMobNum.Location = new System.Drawing.Point(10, 105);
            this.lblMainFormMobNum.Name = "lblMainFormMobNum";
            this.lblMainFormMobNum.Size = new System.Drawing.Size(137, 18);
            this.lblMainFormMobNum.TabIndex = 23;
            this.lblMainFormMobNum.Text = "Mobile Number:";
            // 
            // txtMainFrm_CustMobNum
            // 
            this.txtMainFrm_CustMobNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMainFrm_CustMobNum.Location = new System.Drawing.Point(172, 102);
            this.txtMainFrm_CustMobNum.Name = "txtMainFrm_CustMobNum";
            this.txtMainFrm_CustMobNum.Size = new System.Drawing.Size(151, 26);
            this.txtMainFrm_CustMobNum.TabIndex = 10;
            this.txtMainFrm_CustMobNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMainFrm_CustMobNum_KeyPress);
            // 
            // txtMainFrm_Quantity
            // 
            this.txtMainFrm_Quantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMainFrm_Quantity.Location = new System.Drawing.Point(160, 100);
            this.txtMainFrm_Quantity.Name = "txtMainFrm_Quantity";
            this.txtMainFrm_Quantity.Size = new System.Drawing.Size(151, 26);
            this.txtMainFrm_Quantity.TabIndex = 6;
            this.txtMainFrm_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMainFrm_Quantity_KeyPress);
            this.txtMainFrm_Quantity.Leave += new System.EventHandler(this.txtMainFrm_Quantity_Leave);
            // 
            // txtMainFrm_CustAge
            // 
            this.txtMainFrm_CustAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMainFrm_CustAge.Location = new System.Drawing.Point(173, 69);
            this.txtMainFrm_CustAge.Name = "txtMainFrm_CustAge";
            this.txtMainFrm_CustAge.Size = new System.Drawing.Size(150, 26);
            this.txtMainFrm_CustAge.TabIndex = 9;
            this.txtMainFrm_CustAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMainFrm_CustAge_KeyPress);
            // 
            // txtMainFrm_Password
            // 
            this.txtMainFrm_Password.Location = new System.Drawing.Point(1192, 58);
            this.txtMainFrm_Password.Name = "txtMainFrm_Password";
            this.txtMainFrm_Password.PasswordChar = '*';
            this.txtMainFrm_Password.Size = new System.Drawing.Size(150, 20);
            this.txtMainFrm_Password.TabIndex = 2;
            // 
            // txtMainFrm_userName
            // 
            this.txtMainFrm_userName.Location = new System.Drawing.Point(1192, 27);
            this.txtMainFrm_userName.Name = "txtMainFrm_userName";
            this.txtMainFrm_userName.Size = new System.Drawing.Size(150, 20);
            this.txtMainFrm_userName.TabIndex = 1;
            // 
            // lblMainFrm_Password
            // 
            this.lblMainFrm_Password.AutoSize = true;
            this.lblMainFrm_Password.BackColor = System.Drawing.Color.Transparent;
            this.lblMainFrm_Password.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainFrm_Password.ForeColor = System.Drawing.Color.White;
            this.lblMainFrm_Password.Location = new System.Drawing.Point(1071, 57);
            this.lblMainFrm_Password.Name = "lblMainFrm_Password";
            this.lblMainFrm_Password.Size = new System.Drawing.Size(87, 18);
            this.lblMainFrm_Password.TabIndex = 31;
            this.lblMainFrm_Password.Text = "Password:";
            // 
            // lblMainFrm_userName
            // 
            this.lblMainFrm_userName.AutoSize = true;
            this.lblMainFrm_userName.BackColor = System.Drawing.Color.Transparent;
            this.lblMainFrm_userName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainFrm_userName.ForeColor = System.Drawing.Color.White;
            this.lblMainFrm_userName.Location = new System.Drawing.Point(1071, 26);
            this.lblMainFrm_userName.Name = "lblMainFrm_userName";
            this.lblMainFrm_userName.Size = new System.Drawing.Size(98, 18);
            this.lblMainFrm_userName.TabIndex = 32;
            this.lblMainFrm_userName.Text = "User Name:";
            // 
            // btnMainFrm_Login
            // 
            this.btnMainFrm_Login.BackColor = System.Drawing.Color.DarkRed;
            this.btnMainFrm_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainFrm_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainFrm_Login.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainFrm_Login.ForeColor = System.Drawing.Color.White;
            this.btnMainFrm_Login.Location = new System.Drawing.Point(1192, 94);
            this.btnMainFrm_Login.Name = "btnMainFrm_Login";
            this.btnMainFrm_Login.Size = new System.Drawing.Size(80, 35);
            this.btnMainFrm_Login.TabIndex = 3;
            this.btnMainFrm_Login.Text = "LOG IN";
            this.btnMainFrm_Login.UseVisualStyleBackColor = false;
            this.btnMainFrm_Login.Click += new System.EventHandler(this.btnMainFrm_Login_Click);
            // 
            // lblMainFrm_Gender
            // 
            this.lblMainFrm_Gender.AutoSize = true;
            this.lblMainFrm_Gender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainFrm_Gender.ForeColor = System.Drawing.Color.White;
            this.lblMainFrm_Gender.Location = new System.Drawing.Point(10, 138);
            this.lblMainFrm_Gender.Name = "lblMainFrm_Gender";
            this.lblMainFrm_Gender.Size = new System.Drawing.Size(73, 18);
            this.lblMainFrm_Gender.TabIndex = 34;
            this.lblMainFrm_Gender.Text = "Gender:";
            // 
            // cbMainFrm_Gender
            // 
            this.cbMainFrm_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMainFrm_Gender.FormattingEnabled = true;
            this.cbMainFrm_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbMainFrm_Gender.Location = new System.Drawing.Point(173, 135);
            this.cbMainFrm_Gender.Name = "cbMainFrm_Gender";
            this.cbMainFrm_Gender.Size = new System.Drawing.Size(150, 26);
            this.cbMainFrm_Gender.TabIndex = 11;
            this.cbMainFrm_Gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMainFrm_Gender_KeyPress);
            // 
            // lblMainForm_SaleCountHeading
            // 
            this.lblMainForm_SaleCountHeading.AutoSize = true;
            this.lblMainForm_SaleCountHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblMainForm_SaleCountHeading.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm_SaleCountHeading.ForeColor = System.Drawing.Color.White;
            this.lblMainForm_SaleCountHeading.Location = new System.Drawing.Point(9, 244);
            this.lblMainForm_SaleCountHeading.Name = "lblMainForm_SaleCountHeading";
            this.lblMainForm_SaleCountHeading.Size = new System.Drawing.Size(155, 18);
            this.lblMainForm_SaleCountHeading.TabIndex = 36;
            this.lblMainForm_SaleCountHeading.Text = "Today\'s Total Sales:";
            // 
            // txtMainForm_SaleCount
            // 
            this.txtMainForm_SaleCount.AutoSize = true;
            this.txtMainForm_SaleCount.BackColor = System.Drawing.Color.Transparent;
            this.txtMainForm_SaleCount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainForm_SaleCount.ForeColor = System.Drawing.Color.White;
            this.txtMainForm_SaleCount.Location = new System.Drawing.Point(170, 244);
            this.txtMainForm_SaleCount.Name = "txtMainForm_SaleCount";
            this.txtMainForm_SaleCount.Size = new System.Drawing.Size(85, 18);
            this.txtMainForm_SaleCount.TabIndex = 37;
            this.txtMainForm_SaleCount.Text = "_______";
            // 
            // barChart
            // 
            this.barChart.BackColor = System.Drawing.Color.OrangeRed;
            this.barChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.barChart.BorderSkin.BorderColor = System.Drawing.Color.Gold;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(733, 337);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Aqua;
            series1.LabelBackColor = System.Drawing.Color.DimGray;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Sale";
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(516, 303);
            this.barChart.TabIndex = 38;
            this.barChart.Text = "Sales Chart";
            this.barChart.Click += new System.EventHandler(this.barChart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblCoffeeName);
            this.groupBox1.Controls.Add(this.lblCoffeeQuantity);
            this.groupBox1.Controls.Add(this.lblCoffeePrice);
            this.groupBox1.Controls.Add(this.lblCoffeeTotal);
            this.groupBox1.Controls.Add(this.cbMainForm_CoffeeName);
            this.groupBox1.Controls.Add(this.txtMainFrm_Price);
            this.groupBox1.Controls.Add(this.txtMainForm_Total);
            this.groupBox1.Controls.Add(this.txtMainFrm_Quantity);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 178);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCustomerName);
            this.groupBox2.Controls.Add(this.lblCustomerAge);
            this.groupBox2.Controls.Add(this.txtMainFrm_CustName);
            this.groupBox2.Controls.Add(this.lblMainFormMobNum);
            this.groupBox2.Controls.Add(this.txtMainFrm_CustMobNum);
            this.groupBox2.Controls.Add(this.cbMainFrm_Gender);
            this.groupBox2.Controls.Add(this.txtMainFrm_CustAge);
            this.groupBox2.Controls.Add(this.lblMainFrm_Gender);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 178);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.txtMainForm_SaleCount);
            this.Controls.Add(this.lblMainForm_SaleCountHeading);
            this.Controls.Add(this.btnMainFrm_Login);
            this.Controls.Add(this.lblMainFrm_userName);
            this.Controls.Add(this.lblMainFrm_Password);
            this.Controls.Add(this.txtMainFrm_userName);
            this.Controls.Add(this.txtMainFrm_Password);
            this.Controls.Add(this.dataGridViewMainWindow);
            this.Controls.Add(this.btnRefreshFields);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.menuStripMainForm);
            this.MainMenuStrip = this.menuStripMainForm;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainWindow)).EndInit();
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.Label lblCoffeeQuantity;
        private System.Windows.Forms.Label lblCoffeePrice;
        private System.Windows.Forms.Label lblCoffeeTotal;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cbMainForm_CoffeeName;
        private System.Windows.Forms.Label lblCustomerAge;
        private System.Windows.Forms.TextBox txtMainFrm_Price;
        private System.Windows.Forms.TextBox txtMainForm_Total;
        private System.Windows.Forms.TextBox txtMainFrm_CustName;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnRefreshFields;
        private System.Windows.Forms.DataGridView dataGridViewMainWindow;
        private System.Windows.Forms.ToolStripMenuItem manageCoffees;
        private System.Windows.Forms.ToolStripMenuItem manageSales;
        private System.Windows.Forms.ToolStripMenuItem manageCust;
        private System.Windows.Forms.Label lblMainFormMobNum;
        private System.Windows.Forms.TextBox txtMainFrm_CustMobNum;
        private System.Windows.Forms.ToolStripMenuItem manageEmp;
        public System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.TextBox txtMainFrm_Quantity;
        private System.Windows.Forms.TextBox txtMainFrm_CustAge;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_logOut;
        private System.Windows.Forms.TextBox txtMainFrm_Password;
        private System.Windows.Forms.TextBox txtMainFrm_userName;
        private System.Windows.Forms.Label lblMainFrm_Password;
        private System.Windows.Forms.Label lblMainFrm_userName;
        private System.Windows.Forms.Button btnMainFrm_Login;
        private System.Windows.Forms.Label lblMainFrm_Gender;
        private System.Windows.Forms.ComboBox cbMainFrm_Gender;
        private System.Windows.Forms.Label lblMainForm_SaleCountHeading;
        private System.Windows.Forms.Label txtMainForm_SaleCount;
        private System.Windows.Forms.ToolStripMenuItem backUp;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

