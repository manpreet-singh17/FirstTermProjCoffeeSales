namespace coffeeSalesManag_CompApp
{
    partial class ManageCustomerForm
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
            this.lblMangCust_Name = new System.Windows.Forms.Label();
            this.lblMangCust_Age = new System.Windows.Forms.Label();
            this.btnMangCust_Add = new System.Windows.Forms.Button();
            this.btnMangCust_Update = new System.Windows.Forms.Button();
            this.btnMangCust_Delete = new System.Windows.Forms.Button();
            this.txtMangCust_Name = new System.Windows.Forms.TextBox();
            this.lblMangCust_MobNum = new System.Windows.Forms.Label();
            this.lblMangCust_Gender = new System.Windows.Forms.Label();
            this.txtMangCust_MobNum = new System.Windows.Forms.TextBox();
            this.RbMangCust_Male = new System.Windows.Forms.RadioButton();
            this.RbMangCust_FeMale = new System.Windows.Forms.RadioButton();
            this.lblMangCust_Heading = new System.Windows.Forms.Label();
            this.txtMangCust_Age = new System.Windows.Forms.TextBox();
            this.dgvMangCust = new System.Windows.Forms.DataGridView();
            this.lblMangCust_ID = new System.Windows.Forms.Label();
            this.txtMangCust_ID = new System.Windows.Forms.TextBox();
            this.lblManageCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangCust)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMangCust_Name
            // 
            this.lblMangCust_Name.AutoSize = true;
            this.lblMangCust_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblMangCust_Name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangCust_Name.ForeColor = System.Drawing.Color.White;
            this.lblMangCust_Name.Location = new System.Drawing.Point(13, 317);
            this.lblMangCust_Name.Name = "lblMangCust_Name";
            this.lblMangCust_Name.Size = new System.Drawing.Size(143, 18);
            this.lblMangCust_Name.TabIndex = 0;
            this.lblMangCust_Name.Text = "Customer Name: ";
            // 
            // lblMangCust_Age
            // 
            this.lblMangCust_Age.AutoSize = true;
            this.lblMangCust_Age.BackColor = System.Drawing.Color.Transparent;
            this.lblMangCust_Age.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangCust_Age.ForeColor = System.Drawing.Color.White;
            this.lblMangCust_Age.Location = new System.Drawing.Point(14, 345);
            this.lblMangCust_Age.Name = "lblMangCust_Age";
            this.lblMangCust_Age.Size = new System.Drawing.Size(122, 18);
            this.lblMangCust_Age.TabIndex = 1;
            this.lblMangCust_Age.Text = "Customer Age:";
            // 
            // btnMangCust_Add
            // 
            this.btnMangCust_Add.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangCust_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangCust_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangCust_Add.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangCust_Add.ForeColor = System.Drawing.Color.White;
            this.btnMangCust_Add.Location = new System.Drawing.Point(444, 281);
            this.btnMangCust_Add.Name = "btnMangCust_Add";
            this.btnMangCust_Add.Size = new System.Drawing.Size(75, 35);
            this.btnMangCust_Add.TabIndex = 7;
            this.btnMangCust_Add.Text = "ADD";
            this.btnMangCust_Add.UseVisualStyleBackColor = false;
            this.btnMangCust_Add.Click += new System.EventHandler(this.btnMangCust_Add_Click);
            // 
            // btnMangCust_Update
            // 
            this.btnMangCust_Update.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangCust_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangCust_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangCust_Update.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangCust_Update.ForeColor = System.Drawing.Color.White;
            this.btnMangCust_Update.Location = new System.Drawing.Point(444, 336);
            this.btnMangCust_Update.Name = "btnMangCust_Update";
            this.btnMangCust_Update.Size = new System.Drawing.Size(75, 35);
            this.btnMangCust_Update.TabIndex = 8;
            this.btnMangCust_Update.Text = "UPDATE";
            this.btnMangCust_Update.UseVisualStyleBackColor = false;
            this.btnMangCust_Update.Click += new System.EventHandler(this.btnMangCust_Update_Click);
            // 
            // btnMangCust_Delete
            // 
            this.btnMangCust_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangCust_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangCust_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangCust_Delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangCust_Delete.ForeColor = System.Drawing.Color.White;
            this.btnMangCust_Delete.Location = new System.Drawing.Point(444, 391);
            this.btnMangCust_Delete.Name = "btnMangCust_Delete";
            this.btnMangCust_Delete.Size = new System.Drawing.Size(75, 35);
            this.btnMangCust_Delete.TabIndex = 9;
            this.btnMangCust_Delete.Text = "DELETE";
            this.btnMangCust_Delete.UseVisualStyleBackColor = false;
            this.btnMangCust_Delete.Click += new System.EventHandler(this.btnMangCust_Delete_Click);
            // 
            // txtMangCust_Name
            // 
            this.txtMangCust_Name.Location = new System.Drawing.Point(180, 318);
            this.txtMangCust_Name.Name = "txtMangCust_Name";
            this.txtMangCust_Name.Size = new System.Drawing.Size(150, 20);
            this.txtMangCust_Name.TabIndex = 2;
            this.txtMangCust_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMangCust_Name_KeyPress);
            // 
            // lblMangCust_MobNum
            // 
            this.lblMangCust_MobNum.AutoSize = true;
            this.lblMangCust_MobNum.BackColor = System.Drawing.Color.Transparent;
            this.lblMangCust_MobNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangCust_MobNum.ForeColor = System.Drawing.Color.White;
            this.lblMangCust_MobNum.Location = new System.Drawing.Point(14, 374);
            this.lblMangCust_MobNum.Name = "lblMangCust_MobNum";
            this.lblMangCust_MobNum.Size = new System.Drawing.Size(126, 18);
            this.lblMangCust_MobNum.TabIndex = 9;
            this.lblMangCust_MobNum.Text = "Mobile Number:";
            // 
            // lblMangCust_Gender
            // 
            this.lblMangCust_Gender.AutoSize = true;
            this.lblMangCust_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lblMangCust_Gender.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangCust_Gender.ForeColor = System.Drawing.Color.White;
            this.lblMangCust_Gender.Location = new System.Drawing.Point(14, 406);
            this.lblMangCust_Gender.Name = "lblMangCust_Gender";
            this.lblMangCust_Gender.Size = new System.Drawing.Size(69, 18);
            this.lblMangCust_Gender.TabIndex = 10;
            this.lblMangCust_Gender.Text = "Gender:";
            // 
            // txtMangCust_MobNum
            // 
            this.txtMangCust_MobNum.Location = new System.Drawing.Point(180, 375);
            this.txtMangCust_MobNum.MaxLength = 12;
            this.txtMangCust_MobNum.Name = "txtMangCust_MobNum";
            this.txtMangCust_MobNum.Size = new System.Drawing.Size(150, 20);
            this.txtMangCust_MobNum.TabIndex = 4;
            this.txtMangCust_MobNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMangCust_MobNum_KeyPress);
            // 
            // RbMangCust_Male
            // 
            this.RbMangCust_Male.AutoSize = true;
            this.RbMangCust_Male.BackColor = System.Drawing.Color.Transparent;
            this.RbMangCust_Male.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMangCust_Male.ForeColor = System.Drawing.Color.White;
            this.RbMangCust_Male.Location = new System.Drawing.Point(180, 406);
            this.RbMangCust_Male.Name = "RbMangCust_Male";
            this.RbMangCust_Male.Size = new System.Drawing.Size(56, 20);
            this.RbMangCust_Male.TabIndex = 5;
            this.RbMangCust_Male.TabStop = true;
            this.RbMangCust_Male.Text = "Male";
            this.RbMangCust_Male.UseVisualStyleBackColor = false;
            // 
            // RbMangCust_FeMale
            // 
            this.RbMangCust_FeMale.AutoSize = true;
            this.RbMangCust_FeMale.BackColor = System.Drawing.Color.Transparent;
            this.RbMangCust_FeMale.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMangCust_FeMale.ForeColor = System.Drawing.Color.White;
            this.RbMangCust_FeMale.Location = new System.Drawing.Point(242, 406);
            this.RbMangCust_FeMale.Name = "RbMangCust_FeMale";
            this.RbMangCust_FeMale.Size = new System.Drawing.Size(72, 20);
            this.RbMangCust_FeMale.TabIndex = 6;
            this.RbMangCust_FeMale.TabStop = true;
            this.RbMangCust_FeMale.Text = "Female";
            this.RbMangCust_FeMale.UseVisualStyleBackColor = false;
            // 
            // lblMangCust_Heading
            // 
            this.lblMangCust_Heading.AutoSize = true;
            this.lblMangCust_Heading.BackColor = System.Drawing.Color.Transparent;
            this.lblMangCust_Heading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangCust_Heading.ForeColor = System.Drawing.Color.White;
            this.lblMangCust_Heading.Location = new System.Drawing.Point(31, 248);
            this.lblMangCust_Heading.Name = "lblMangCust_Heading";
            this.lblMangCust_Heading.Size = new System.Drawing.Size(168, 18);
            this.lblMangCust_Heading.TabIndex = 15;
            this.lblMangCust_Heading.Text = "Manage Customer";
            // 
            // txtMangCust_Age
            // 
            this.txtMangCust_Age.Location = new System.Drawing.Point(180, 346);
            this.txtMangCust_Age.MaxLength = 3;
            this.txtMangCust_Age.Name = "txtMangCust_Age";
            this.txtMangCust_Age.Size = new System.Drawing.Size(149, 20);
            this.txtMangCust_Age.TabIndex = 3;
            this.txtMangCust_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMangCust_Age_KeyPress);
            // 
            // dgvMangCust
            // 
            this.dgvMangCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangCust.Location = new System.Drawing.Point(12, 30);
            this.dgvMangCust.Name = "dgvMangCust";
            this.dgvMangCust.ReadOnly = true;
            this.dgvMangCust.Size = new System.Drawing.Size(650, 183);
            this.dgvMangCust.TabIndex = 17;
            this.dgvMangCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMangCust_CellClick);
            // 
            // lblMangCust_ID
            // 
            this.lblMangCust_ID.AutoSize = true;
            this.lblMangCust_ID.BackColor = System.Drawing.Color.Transparent;
            this.lblMangCust_ID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangCust_ID.ForeColor = System.Drawing.Color.White;
            this.lblMangCust_ID.Location = new System.Drawing.Point(14, 288);
            this.lblMangCust_ID.Name = "lblMangCust_ID";
            this.lblMangCust_ID.Size = new System.Drawing.Size(31, 18);
            this.lblMangCust_ID.TabIndex = 18;
            this.lblMangCust_ID.Text = "ID:";
            // 
            // txtMangCust_ID
            // 
            this.txtMangCust_ID.Location = new System.Drawing.Point(180, 289);
            this.txtMangCust_ID.Name = "txtMangCust_ID";
            this.txtMangCust_ID.ReadOnly = true;
            this.txtMangCust_ID.Size = new System.Drawing.Size(150, 20);
            this.txtMangCust_ID.TabIndex = 1;
            // 
            // lblManageCustomer
            // 
            this.lblManageCustomer.AutoSize = true;
            this.lblManageCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCustomer.ForeColor = System.Drawing.Color.White;
            this.lblManageCustomer.Location = new System.Drawing.Point(12, 9);
            this.lblManageCustomer.Name = "lblManageCustomer";
            this.lblManageCustomer.Size = new System.Drawing.Size(108, 18);
            this.lblManageCustomer.TabIndex = 19;
            this.lblManageCustomer.Text = "Customers:";
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 466);
            this.Controls.Add(this.lblManageCustomer);
            this.Controls.Add(this.txtMangCust_ID);
            this.Controls.Add(this.lblMangCust_ID);
            this.Controls.Add(this.dgvMangCust);
            this.Controls.Add(this.txtMangCust_Age);
            this.Controls.Add(this.lblMangCust_Heading);
            this.Controls.Add(this.RbMangCust_FeMale);
            this.Controls.Add(this.RbMangCust_Male);
            this.Controls.Add(this.txtMangCust_MobNum);
            this.Controls.Add(this.lblMangCust_Gender);
            this.Controls.Add(this.lblMangCust_MobNum);
            this.Controls.Add(this.txtMangCust_Name);
            this.Controls.Add(this.btnMangCust_Delete);
            this.Controls.Add(this.btnMangCust_Update);
            this.Controls.Add(this.btnMangCust_Add);
            this.Controls.Add(this.lblMangCust_Age);
            this.Controls.Add(this.lblMangCust_Name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ManageCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMangCust_Name;
        private System.Windows.Forms.Label lblMangCust_Age;
        private System.Windows.Forms.Button btnMangCust_Add;
        private System.Windows.Forms.Button btnMangCust_Update;
        private System.Windows.Forms.Button btnMangCust_Delete;
        private System.Windows.Forms.TextBox txtMangCust_Name;
        private System.Windows.Forms.Label lblMangCust_MobNum;
        private System.Windows.Forms.Label lblMangCust_Gender;
        private System.Windows.Forms.TextBox txtMangCust_MobNum;
        private System.Windows.Forms.RadioButton RbMangCust_Male;
        private System.Windows.Forms.RadioButton RbMangCust_FeMale;
        private System.Windows.Forms.Label lblMangCust_Heading;
        private System.Windows.Forms.TextBox txtMangCust_Age;
        private System.Windows.Forms.DataGridView dgvMangCust;
        private System.Windows.Forms.Label lblMangCust_ID;
        private System.Windows.Forms.TextBox txtMangCust_ID;
        private System.Windows.Forms.Label lblManageCustomer;
    }
}