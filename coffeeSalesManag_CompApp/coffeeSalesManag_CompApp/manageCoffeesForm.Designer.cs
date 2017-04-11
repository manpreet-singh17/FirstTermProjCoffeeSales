namespace coffeeSalesManag_CompApp
{
    partial class manageCoffeesForm
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
            this.components = new System.ComponentModel.Container();
            this.lblManageCoffeeCoffeeNameAdd = new System.Windows.Forms.Label();
            this.txtMngCof_CofName_Add = new System.Windows.Forms.TextBox();
            this.lblManageCoffeeAddCoffeeHeading = new System.Windows.Forms.Label();
            this.btnMngCof_AddCoff = new System.Windows.Forms.Button();
            this.btnMngCof_DeleteCoffee = new System.Windows.Forms.Button();
            this.lblManageCoffeeUpdateCoffeeHeading = new System.Windows.Forms.Label();
            this.btnManageCoffeeUpdateCoffee = new System.Windows.Forms.Button();
            this.lblManageCoffeeCoffeeNameUpdate = new System.Windows.Forms.Label();
            this.cbMngCof_CofName_Update = new System.Windows.Forms.ComboBox();
            this.lblManageCoffeeUpdatedCoffeeName = new System.Windows.Forms.Label();
            this.txtMngCof_UpdatedCofName_Update = new System.Windows.Forms.TextBox();
            this.dgvManageCoffee = new System.Windows.Forms.DataGridView();
            this.coffeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet = new coffeeSalesManag_CompApp._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet();
            this.lblManageCoffeeAllCoffees = new System.Windows.Forms.Label();
            this.lblManageCoffee_CoffeePrice = new System.Windows.Forms.Label();
            this.lblManageCoffe_CoffErr_Add = new System.Windows.Forms.Label();
            this.txt_MngCof_Price_Add = new System.Windows.Forms.TextBox();
            this.lblManageCoffeeDeleteCoffee = new System.Windows.Forms.Label();
            this.lblManageCoffeeCoffeeNameDelete = new System.Windows.Forms.Label();
            this.cbMngCof_DeleteCof_Del = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMngCof_Price_Del = new System.Windows.Forms.TextBox();
            this.coffeesTableAdapter = new coffeeSalesManag_CompApp._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSetTableAdapters.CoffeesTableAdapter();
            this.lblManageForm_Coff_Price_Update = new System.Windows.Forms.Label();
            this.txtMngCof_CoffPrice_Update = new System.Windows.Forms.TextBox();
            this.lblManageForm_NewPrice_Update = new System.Windows.Forms.Label();
            this.txtManageForm_NewPrice_Update = new System.Windows.Forms.TextBox();
            this.btnManageCoffeePrevious = new System.Windows.Forms.Button();
            this.btnManageCoffeeNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageCoffeeCoffeeNameAdd
            // 
            this.lblManageCoffeeCoffeeNameAdd.AutoSize = true;
            this.lblManageCoffeeCoffeeNameAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeCoffeeNameAdd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeCoffeeNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeCoffeeNameAdd.Location = new System.Drawing.Point(7, 331);
            this.lblManageCoffeeCoffeeNameAdd.Name = "lblManageCoffeeCoffeeNameAdd";
            this.lblManageCoffeeCoffeeNameAdd.Size = new System.Drawing.Size(113, 18);
            this.lblManageCoffeeCoffeeNameAdd.TabIndex = 0;
            this.lblManageCoffeeCoffeeNameAdd.Text = "Coffee Name:";
            // 
            // txtMngCof_CofName_Add
            // 
            this.txtMngCof_CofName_Add.Location = new System.Drawing.Point(126, 332);
            this.txtMngCof_CofName_Add.Name = "txtMngCof_CofName_Add";
            this.txtMngCof_CofName_Add.Size = new System.Drawing.Size(150, 20);
            this.txtMngCof_CofName_Add.TabIndex = 1;
            // 
            // lblManageCoffeeAddCoffeeHeading
            // 
            this.lblManageCoffeeAddCoffeeHeading.AutoSize = true;
            this.lblManageCoffeeAddCoffeeHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeAddCoffeeHeading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeAddCoffeeHeading.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeAddCoffeeHeading.Location = new System.Drawing.Point(49, 282);
            this.lblManageCoffeeAddCoffeeHeading.Name = "lblManageCoffeeAddCoffeeHeading";
            this.lblManageCoffeeAddCoffeeHeading.Size = new System.Drawing.Size(162, 18);
            this.lblManageCoffeeAddCoffeeHeading.TabIndex = 2;
            this.lblManageCoffeeAddCoffeeHeading.Text = "Add  New Coffee:";
            // 
            // btnMngCof_AddCoff
            // 
            this.btnMngCof_AddCoff.BackColor = System.Drawing.Color.DarkRed;
            this.btnMngCof_AddCoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMngCof_AddCoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMngCof_AddCoff.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngCof_AddCoff.ForeColor = System.Drawing.Color.White;
            this.btnMngCof_AddCoff.Location = new System.Drawing.Point(126, 396);
            this.btnMngCof_AddCoff.Name = "btnMngCof_AddCoff";
            this.btnMngCof_AddCoff.Size = new System.Drawing.Size(75, 35);
            this.btnMngCof_AddCoff.TabIndex = 3;
            this.btnMngCof_AddCoff.Text = "ADD";
            this.btnMngCof_AddCoff.UseVisualStyleBackColor = false;
            this.btnMngCof_AddCoff.Click += new System.EventHandler(this.AddCoffee);
            // 
            // btnMngCof_DeleteCoffee
            // 
            this.btnMngCof_DeleteCoffee.BackColor = System.Drawing.Color.DarkRed;
            this.btnMngCof_DeleteCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMngCof_DeleteCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMngCof_DeleteCoffee.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngCof_DeleteCoffee.ForeColor = System.Drawing.Color.White;
            this.btnMngCof_DeleteCoffee.Location = new System.Drawing.Point(701, 396);
            this.btnMngCof_DeleteCoffee.Name = "btnMngCof_DeleteCoffee";
            this.btnMngCof_DeleteCoffee.Size = new System.Drawing.Size(75, 35);
            this.btnMngCof_DeleteCoffee.TabIndex = 11;
            this.btnMngCof_DeleteCoffee.Text = "DELETE";
            this.btnMngCof_DeleteCoffee.UseVisualStyleBackColor = false;
            this.btnMngCof_DeleteCoffee.Click += new System.EventHandler(this.btnManageCoffeeDeleteCoffee_Click);
            // 
            // lblManageCoffeeUpdateCoffeeHeading
            // 
            this.lblManageCoffeeUpdateCoffeeHeading.AutoSize = true;
            this.lblManageCoffeeUpdateCoffeeHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeUpdateCoffeeHeading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeUpdateCoffeeHeading.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeUpdateCoffeeHeading.Location = new System.Drawing.Point(333, 282);
            this.lblManageCoffeeUpdateCoffeeHeading.Name = "lblManageCoffeeUpdateCoffeeHeading";
            this.lblManageCoffeeUpdateCoffeeHeading.Size = new System.Drawing.Size(142, 18);
            this.lblManageCoffeeUpdateCoffeeHeading.TabIndex = 9;
            this.lblManageCoffeeUpdateCoffeeHeading.Text = "Update Coffee:";
            // 
            // btnManageCoffeeUpdateCoffee
            // 
            this.btnManageCoffeeUpdateCoffee.BackColor = System.Drawing.Color.DarkRed;
            this.btnManageCoffeeUpdateCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageCoffeeUpdateCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCoffeeUpdateCoffee.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCoffeeUpdateCoffee.ForeColor = System.Drawing.Color.White;
            this.btnManageCoffeeUpdateCoffee.Location = new System.Drawing.Point(415, 457);
            this.btnManageCoffeeUpdateCoffee.Name = "btnManageCoffeeUpdateCoffee";
            this.btnManageCoffeeUpdateCoffee.Size = new System.Drawing.Size(75, 35);
            this.btnManageCoffeeUpdateCoffee.TabIndex = 8;
            this.btnManageCoffeeUpdateCoffee.Text = "UPDATE";
            this.btnManageCoffeeUpdateCoffee.UseVisualStyleBackColor = false;
            this.btnManageCoffeeUpdateCoffee.Click += new System.EventHandler(this.btnManageCoffeeUpdateCoffee_Click);
            // 
            // lblManageCoffeeCoffeeNameUpdate
            // 
            this.lblManageCoffeeCoffeeNameUpdate.AutoSize = true;
            this.lblManageCoffeeCoffeeNameUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeCoffeeNameUpdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeCoffeeNameUpdate.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeCoffeeNameUpdate.Location = new System.Drawing.Point(286, 331);
            this.lblManageCoffeeCoffeeNameUpdate.Name = "lblManageCoffeeCoffeeNameUpdate";
            this.lblManageCoffeeCoffeeNameUpdate.Size = new System.Drawing.Size(113, 18);
            this.lblManageCoffeeCoffeeNameUpdate.TabIndex = 10;
            this.lblManageCoffeeCoffeeNameUpdate.Text = "Coffee Name:";
            // 
            // cbMngCof_CofName_Update
            // 
            this.cbMngCof_CofName_Update.FormattingEnabled = true;
            this.cbMngCof_CofName_Update.Location = new System.Drawing.Point(415, 332);
            this.cbMngCof_CofName_Update.Name = "cbMngCof_CofName_Update";
            this.cbMngCof_CofName_Update.Size = new System.Drawing.Size(150, 21);
            this.cbMngCof_CofName_Update.TabIndex = 4;
            this.cbMngCof_CofName_Update.SelectedIndexChanged += new System.EventHandler(this.cbManageCoffee_CofName_Update_SelectedIndexChanged);
            // 
            // lblManageCoffeeUpdatedCoffeeName
            // 
            this.lblManageCoffeeUpdatedCoffeeName.AutoSize = true;
            this.lblManageCoffeeUpdatedCoffeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeUpdatedCoffeeName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeUpdatedCoffeeName.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeUpdatedCoffeeName.Location = new System.Drawing.Point(286, 396);
            this.lblManageCoffeeUpdatedCoffeeName.Name = "lblManageCoffeeUpdatedCoffeeName";
            this.lblManageCoffeeUpdatedCoffeeName.Size = new System.Drawing.Size(97, 18);
            this.lblManageCoffeeUpdatedCoffeeName.TabIndex = 14;
            this.lblManageCoffeeUpdatedCoffeeName.Text = "New Name:";
            // 
            // txtMngCof_UpdatedCofName_Update
            // 
            this.txtMngCof_UpdatedCofName_Update.Location = new System.Drawing.Point(415, 397);
            this.txtMngCof_UpdatedCofName_Update.Name = "txtMngCof_UpdatedCofName_Update";
            this.txtMngCof_UpdatedCofName_Update.Size = new System.Drawing.Size(150, 20);
            this.txtMngCof_UpdatedCofName_Update.TabIndex = 6;
            this.txtMngCof_UpdatedCofName_Update.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMngCof_UpdatedCofName_Update_KeyPress);
            // 
            // dgvManageCoffee
            // 
            this.dgvManageCoffee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageCoffee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvManageCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageCoffee.Location = new System.Drawing.Point(12, 30);
            this.dgvManageCoffee.Name = "dgvManageCoffee";
            this.dgvManageCoffee.ReadOnly = true;
            this.dgvManageCoffee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvManageCoffee.Size = new System.Drawing.Size(839, 186);
            this.dgvManageCoffee.TabIndex = 16;
            // 
            // coffeesBindingSource
            // 
            this.coffeesBindingSource.DataMember = "Coffees";
            this.coffeesBindingSource.DataSource = this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet;
            // 
            // _coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet
            // 
            this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet.DataSetName = "_coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet";
            this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblManageCoffeeAllCoffees
            // 
            this.lblManageCoffeeAllCoffees.AutoSize = true;
            this.lblManageCoffeeAllCoffees.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeAllCoffees.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeAllCoffees.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeAllCoffees.Location = new System.Drawing.Point(12, 9);
            this.lblManageCoffeeAllCoffees.Name = "lblManageCoffeeAllCoffees";
            this.lblManageCoffeeAllCoffees.Size = new System.Drawing.Size(155, 18);
            this.lblManageCoffeeAllCoffees.TabIndex = 17;
            this.lblManageCoffeeAllCoffees.Text = "Available Coffees:";
            // 
            // lblManageCoffee_CoffeePrice
            // 
            this.lblManageCoffee_CoffeePrice.AutoSize = true;
            this.lblManageCoffee_CoffeePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffee_CoffeePrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffee_CoffeePrice.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffee_CoffeePrice.Location = new System.Drawing.Point(7, 363);
            this.lblManageCoffee_CoffeePrice.Name = "lblManageCoffee_CoffeePrice";
            this.lblManageCoffee_CoffeePrice.Size = new System.Drawing.Size(104, 18);
            this.lblManageCoffee_CoffeePrice.TabIndex = 18;
            this.lblManageCoffee_CoffeePrice.Text = "Coffee Price:";
            // 
            // lblManageCoffe_CoffErr_Add
            // 
            this.lblManageCoffe_CoffErr_Add.AutoSize = true;
            this.lblManageCoffe_CoffErr_Add.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffe_CoffErr_Add.Location = new System.Drawing.Point(115, 342);
            this.lblManageCoffe_CoffErr_Add.Name = "lblManageCoffe_CoffErr_Add";
            this.lblManageCoffe_CoffErr_Add.Size = new System.Drawing.Size(0, 16);
            this.lblManageCoffe_CoffErr_Add.TabIndex = 22;
            this.lblManageCoffe_CoffErr_Add.Visible = false;
            // 
            // txt_MngCof_Price_Add
            // 
            this.txt_MngCof_Price_Add.Location = new System.Drawing.Point(126, 364);
            this.txt_MngCof_Price_Add.Name = "txt_MngCof_Price_Add";
            this.txt_MngCof_Price_Add.Size = new System.Drawing.Size(100, 20);
            this.txt_MngCof_Price_Add.TabIndex = 2;
            // 
            // lblManageCoffeeDeleteCoffee
            // 
            this.lblManageCoffeeDeleteCoffee.AutoSize = true;
            this.lblManageCoffeeDeleteCoffee.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeDeleteCoffee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeDeleteCoffee.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeDeleteCoffee.Location = new System.Drawing.Point(625, 282);
            this.lblManageCoffeeDeleteCoffee.Name = "lblManageCoffeeDeleteCoffee";
            this.lblManageCoffeeDeleteCoffee.Size = new System.Drawing.Size(135, 18);
            this.lblManageCoffeeDeleteCoffee.TabIndex = 4;
            this.lblManageCoffeeDeleteCoffee.Text = "Delete Coffee:";
            // 
            // lblManageCoffeeCoffeeNameDelete
            // 
            this.lblManageCoffeeCoffeeNameDelete.AutoSize = true;
            this.lblManageCoffeeCoffeeNameDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCoffeeCoffeeNameDelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCoffeeCoffeeNameDelete.ForeColor = System.Drawing.Color.White;
            this.lblManageCoffeeCoffeeNameDelete.Location = new System.Drawing.Point(577, 331);
            this.lblManageCoffeeCoffeeNameDelete.Name = "lblManageCoffeeCoffeeNameDelete";
            this.lblManageCoffeeCoffeeNameDelete.Size = new System.Drawing.Size(113, 18);
            this.lblManageCoffeeCoffeeNameDelete.TabIndex = 5;
            this.lblManageCoffeeCoffeeNameDelete.Text = "Coffee Name:";
            // 
            // cbMngCof_DeleteCof_Del
            // 
            this.cbMngCof_DeleteCof_Del.FormattingEnabled = true;
            this.cbMngCof_DeleteCof_Del.Location = new System.Drawing.Point(701, 332);
            this.cbMngCof_DeleteCof_Del.Name = "cbMngCof_DeleteCof_Del";
            this.cbMngCof_DeleteCof_Del.Size = new System.Drawing.Size(150, 21);
            this.cbMngCof_DeleteCof_Del.TabIndex = 9;
            this.cbMngCof_DeleteCof_Del.SelectedValueChanged += new System.EventHandler(this.cbManageCoffeeDeleteCoffee_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(577, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Coffee Price:";
            // 
            // txtMngCof_Price_Del
            // 
            this.txtMngCof_Price_Del.Enabled = false;
            this.txtMngCof_Price_Del.Location = new System.Drawing.Point(701, 364);
            this.txtMngCof_Price_Del.Name = "txtMngCof_Price_Del";
            this.txtMngCof_Price_Del.Size = new System.Drawing.Size(100, 20);
            this.txtMngCof_Price_Del.TabIndex = 10;
            this.txtMngCof_Price_Del.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManageCoffeDelete_KeyPress);
            // 
            // coffeesTableAdapter
            // 
            this.coffeesTableAdapter.ClearBeforeFill = true;
            // 
            // lblManageForm_Coff_Price_Update
            // 
            this.lblManageForm_Coff_Price_Update.AutoSize = true;
            this.lblManageForm_Coff_Price_Update.BackColor = System.Drawing.Color.Transparent;
            this.lblManageForm_Coff_Price_Update.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageForm_Coff_Price_Update.ForeColor = System.Drawing.Color.White;
            this.lblManageForm_Coff_Price_Update.Location = new System.Drawing.Point(286, 363);
            this.lblManageForm_Coff_Price_Update.Name = "lblManageForm_Coff_Price_Update";
            this.lblManageForm_Coff_Price_Update.Size = new System.Drawing.Size(104, 18);
            this.lblManageForm_Coff_Price_Update.TabIndex = 25;
            this.lblManageForm_Coff_Price_Update.Text = "Coffee Price:";
            // 
            // txtMngCof_CoffPrice_Update
            // 
            this.txtMngCof_CoffPrice_Update.Enabled = false;
            this.txtMngCof_CoffPrice_Update.Location = new System.Drawing.Point(415, 364);
            this.txtMngCof_CoffPrice_Update.Name = "txtMngCof_CoffPrice_Update";
            this.txtMngCof_CoffPrice_Update.Size = new System.Drawing.Size(100, 20);
            this.txtMngCof_CoffPrice_Update.TabIndex = 5;
            // 
            // lblManageForm_NewPrice_Update
            // 
            this.lblManageForm_NewPrice_Update.AutoSize = true;
            this.lblManageForm_NewPrice_Update.BackColor = System.Drawing.Color.Transparent;
            this.lblManageForm_NewPrice_Update.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageForm_NewPrice_Update.ForeColor = System.Drawing.Color.White;
            this.lblManageForm_NewPrice_Update.Location = new System.Drawing.Point(286, 430);
            this.lblManageForm_NewPrice_Update.Name = "lblManageForm_NewPrice_Update";
            this.lblManageForm_NewPrice_Update.Size = new System.Drawing.Size(88, 18);
            this.lblManageForm_NewPrice_Update.TabIndex = 27;
            this.lblManageForm_NewPrice_Update.Text = "New Price:";
            // 
            // txtManageForm_NewPrice_Update
            // 
            this.txtManageForm_NewPrice_Update.Location = new System.Drawing.Point(415, 431);
            this.txtManageForm_NewPrice_Update.Name = "txtManageForm_NewPrice_Update";
            this.txtManageForm_NewPrice_Update.Size = new System.Drawing.Size(100, 20);
            this.txtManageForm_NewPrice_Update.TabIndex = 7;
            this.txtManageForm_NewPrice_Update.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManageForm_NewPrice_Update_KeyPress);
            // 
            // btnManageCoffeePrevious
            // 
            this.btnManageCoffeePrevious.BackColor = System.Drawing.Color.DarkRed;
            this.btnManageCoffeePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageCoffeePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCoffeePrevious.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCoffeePrevious.ForeColor = System.Drawing.Color.Transparent;
            this.btnManageCoffeePrevious.Location = new System.Drawing.Point(725, 222);
            this.btnManageCoffeePrevious.Name = "btnManageCoffeePrevious";
            this.btnManageCoffeePrevious.Size = new System.Drawing.Size(60, 35);
            this.btnManageCoffeePrevious.TabIndex = 12;
            this.btnManageCoffeePrevious.Text = "<<";
            this.btnManageCoffeePrevious.UseVisualStyleBackColor = false;
            this.btnManageCoffeePrevious.Click += new System.EventHandler(this.btnManageCoffeePrevious_Click);
            // 
            // btnManageCoffeeNext
            // 
            this.btnManageCoffeeNext.BackColor = System.Drawing.Color.DarkRed;
            this.btnManageCoffeeNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageCoffeeNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCoffeeNext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCoffeeNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnManageCoffeeNext.Location = new System.Drawing.Point(791, 222);
            this.btnManageCoffeeNext.Name = "btnManageCoffeeNext";
            this.btnManageCoffeeNext.Size = new System.Drawing.Size(60, 35);
            this.btnManageCoffeeNext.TabIndex = 13;
            this.btnManageCoffeeNext.Text = ">>";
            this.btnManageCoffeeNext.UseVisualStyleBackColor = false;
            this.btnManageCoffeeNext.Click += new System.EventHandler(this.btnManageCoffeeNext_Click);
            // 
            // manageCoffeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 523);
            this.Controls.Add(this.btnManageCoffeeNext);
            this.Controls.Add(this.btnManageCoffeePrevious);
            this.Controls.Add(this.txtManageForm_NewPrice_Update);
            this.Controls.Add(this.lblManageForm_NewPrice_Update);
            this.Controls.Add(this.txtMngCof_CoffPrice_Update);
            this.Controls.Add(this.lblManageForm_Coff_Price_Update);
            this.Controls.Add(this.txtMngCof_Price_Del);
            this.Controls.Add(this.txt_MngCof_Price_Add);
            this.Controls.Add(this.lblManageCoffe_CoffErr_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblManageCoffee_CoffeePrice);
            this.Controls.Add(this.lblManageCoffeeAllCoffees);
            this.Controls.Add(this.dgvManageCoffee);
            this.Controls.Add(this.txtMngCof_UpdatedCofName_Update);
            this.Controls.Add(this.lblManageCoffeeUpdatedCoffeeName);
            this.Controls.Add(this.cbMngCof_CofName_Update);
            this.Controls.Add(this.btnManageCoffeeUpdateCoffee);
            this.Controls.Add(this.lblManageCoffeeCoffeeNameUpdate);
            this.Controls.Add(this.lblManageCoffeeUpdateCoffeeHeading);
            this.Controls.Add(this.cbMngCof_DeleteCof_Del);
            this.Controls.Add(this.btnMngCof_DeleteCoffee);
            this.Controls.Add(this.lblManageCoffeeCoffeeNameDelete);
            this.Controls.Add(this.lblManageCoffeeDeleteCoffee);
            this.Controls.Add(this.btnMngCof_AddCoff);
            this.Controls.Add(this.lblManageCoffeeAddCoffeeHeading);
            this.Controls.Add(this.txtMngCof_CofName_Add);
            this.Controls.Add(this.lblManageCoffeeCoffeeNameAdd);
            this.Name = "manageCoffeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Coffees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageCoffeeCoffeeNameAdd;
        private System.Windows.Forms.TextBox txtMngCof_CofName_Add;
        private System.Windows.Forms.Label lblManageCoffeeAddCoffeeHeading;
        private System.Windows.Forms.Button btnMngCof_AddCoff;
        private System.Windows.Forms.Button btnMngCof_DeleteCoffee;
        private System.Windows.Forms.Label lblManageCoffeeUpdateCoffeeHeading;
        private System.Windows.Forms.Button btnManageCoffeeUpdateCoffee;
        private System.Windows.Forms.Label lblManageCoffeeCoffeeNameUpdate;
        private System.Windows.Forms.ComboBox cbMngCof_CofName_Update;
        private System.Windows.Forms.Label lblManageCoffeeUpdatedCoffeeName;
        private System.Windows.Forms.TextBox txtMngCof_UpdatedCofName_Update;
        private System.Windows.Forms.DataGridView dgvManageCoffee;
        private System.Windows.Forms.Label lblManageCoffeeAllCoffees;
        private System.Windows.Forms.Label lblManageCoffee_CoffeePrice;
        private System.Windows.Forms.Label lblManageCoffe_CoffErr_Add;
        private System.Windows.Forms.TextBox txt_MngCof_Price_Add;
        private System.Windows.Forms.Label lblManageCoffeeDeleteCoffee;
        private System.Windows.Forms.Label lblManageCoffeeCoffeeNameDelete;
        private System.Windows.Forms.ComboBox cbMngCof_DeleteCof_Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMngCof_Price_Del;
        private _coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet _coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet;
        private System.Windows.Forms.BindingSource coffeesBindingSource;
        private _coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSetTableAdapters.CoffeesTableAdapter coffeesTableAdapter;
        private System.Windows.Forms.Label lblManageForm_Coff_Price_Update;
        private System.Windows.Forms.TextBox txtMngCof_CoffPrice_Update;
        private System.Windows.Forms.Label lblManageForm_NewPrice_Update;
        private System.Windows.Forms.TextBox txtManageForm_NewPrice_Update;
        private System.Windows.Forms.Button btnManageCoffeePrevious;
        private System.Windows.Forms.Button btnManageCoffeeNext;
    }
}