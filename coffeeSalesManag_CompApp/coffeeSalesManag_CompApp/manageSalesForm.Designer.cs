namespace coffeeSalesManag_CompApp
{
    partial class manageSalesForm
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
            this.lblMangSale = new System.Windows.Forms.Label();
            this.lblMangSale_CoffName = new System.Windows.Forms.Label();
            this.lblMangSale_Quantity = new System.Windows.Forms.Label();
            this.lblMangSale_Price = new System.Windows.Forms.Label();
            this.lblMangSale_Total = new System.Windows.Forms.Label();
            this.btnMangSale_Add = new System.Windows.Forms.Button();
            this.dgvMangSale = new System.Windows.Forms.DataGridView();
            this.lblManageFormAllSalesHeading = new System.Windows.Forms.Label();
            this.txtMangSale_Quantity = new System.Windows.Forms.TextBox();
            this.txtMangSale_Price = new System.Windows.Forms.TextBox();
            this.txtMangSale_Total = new System.Windows.Forms.TextBox();
            this.btnMangSale_Update = new System.Windows.Forms.Button();
            this.btnMangSale_Delete = new System.Windows.Forms.Button();
            this.lblMangSale_ID = new System.Windows.Forms.Label();
            this.txtMangSale_saleID = new System.Windows.Forms.TextBox();
            this.cbMangSale_coffName = new System.Windows.Forms.ComboBox();
            this.cbMangSale_FilterBy = new System.Windows.Forms.ComboBox();
            this.btnMangSale_Next = new System.Windows.Forms.Button();
            this.btnMangSale_Prev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMangSale
            // 
            this.lblMangSale.AutoSize = true;
            this.lblMangSale.BackColor = System.Drawing.Color.Transparent;
            this.lblMangSale.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangSale.ForeColor = System.Drawing.Color.White;
            this.lblMangSale.Location = new System.Drawing.Point(74, 284);
            this.lblMangSale.Name = "lblMangSale";
            this.lblMangSale.Size = new System.Drawing.Size(135, 18);
            this.lblMangSale.TabIndex = 0;
            this.lblMangSale.Text = "Manage Sales:";
            // 
            // lblMangSale_CoffName
            // 
            this.lblMangSale_CoffName.AutoSize = true;
            this.lblMangSale_CoffName.BackColor = System.Drawing.Color.Transparent;
            this.lblMangSale_CoffName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangSale_CoffName.ForeColor = System.Drawing.Color.White;
            this.lblMangSale_CoffName.Location = new System.Drawing.Point(12, 367);
            this.lblMangSale_CoffName.Name = "lblMangSale_CoffName";
            this.lblMangSale_CoffName.Size = new System.Drawing.Size(113, 18);
            this.lblMangSale_CoffName.TabIndex = 2;
            this.lblMangSale_CoffName.Text = "Coffee Name:";
            // 
            // lblMangSale_Quantity
            // 
            this.lblMangSale_Quantity.AutoSize = true;
            this.lblMangSale_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lblMangSale_Quantity.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangSale_Quantity.ForeColor = System.Drawing.Color.White;
            this.lblMangSale_Quantity.Location = new System.Drawing.Point(9, 429);
            this.lblMangSale_Quantity.Name = "lblMangSale_Quantity";
            this.lblMangSale_Quantity.Size = new System.Drawing.Size(78, 18);
            this.lblMangSale_Quantity.TabIndex = 3;
            this.lblMangSale_Quantity.Text = "Quantity:";
            // 
            // lblMangSale_Price
            // 
            this.lblMangSale_Price.AutoSize = true;
            this.lblMangSale_Price.BackColor = System.Drawing.Color.Transparent;
            this.lblMangSale_Price.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangSale_Price.ForeColor = System.Drawing.Color.White;
            this.lblMangSale_Price.Location = new System.Drawing.Point(12, 397);
            this.lblMangSale_Price.Name = "lblMangSale_Price";
            this.lblMangSale_Price.Size = new System.Drawing.Size(50, 18);
            this.lblMangSale_Price.TabIndex = 4;
            this.lblMangSale_Price.Text = "Price:";
            // 
            // lblMangSale_Total
            // 
            this.lblMangSale_Total.AutoSize = true;
            this.lblMangSale_Total.BackColor = System.Drawing.Color.Transparent;
            this.lblMangSale_Total.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangSale_Total.ForeColor = System.Drawing.Color.White;
            this.lblMangSale_Total.Location = new System.Drawing.Point(12, 460);
            this.lblMangSale_Total.Name = "lblMangSale_Total";
            this.lblMangSale_Total.Size = new System.Drawing.Size(50, 18);
            this.lblMangSale_Total.TabIndex = 5;
            this.lblMangSale_Total.Text = "Total:";
            // 
            // btnMangSale_Add
            // 
            this.btnMangSale_Add.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangSale_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangSale_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangSale_Add.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangSale_Add.ForeColor = System.Drawing.Color.White;
            this.btnMangSale_Add.Location = new System.Drawing.Point(417, 328);
            this.btnMangSale_Add.Name = "btnMangSale_Add";
            this.btnMangSale_Add.Size = new System.Drawing.Size(75, 35);
            this.btnMangSale_Add.TabIndex = 7;
            this.btnMangSale_Add.Text = "ADD";
            this.btnMangSale_Add.UseVisualStyleBackColor = false;
            this.btnMangSale_Add.Click += new System.EventHandler(this.btnMangSale_Add_Click);
            // 
            // dgvMangSale
            // 
            this.dgvMangSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMangSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMangSale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMangSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangSale.Location = new System.Drawing.Point(12, 49);
            this.dgvMangSale.Name = "dgvMangSale";
            this.dgvMangSale.ReadOnly = true;
            this.dgvMangSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMangSale.Size = new System.Drawing.Size(704, 191);
            this.dgvMangSale.TabIndex = 51;
            this.dgvMangSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMangSale_CellClick);
            // 
            // lblManageFormAllSalesHeading
            // 
            this.lblManageFormAllSalesHeading.AutoSize = true;
            this.lblManageFormAllSalesHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblManageFormAllSalesHeading.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageFormAllSalesHeading.ForeColor = System.Drawing.Color.White;
            this.lblManageFormAllSalesHeading.Location = new System.Drawing.Point(12, 15);
            this.lblManageFormAllSalesHeading.Name = "lblManageFormAllSalesHeading";
            this.lblManageFormAllSalesHeading.Size = new System.Drawing.Size(87, 18);
            this.lblManageFormAllSalesHeading.TabIndex = 52;
            this.lblManageFormAllSalesHeading.Text = "Order By:";
            // 
            // txtMangSale_Quantity
            // 
            this.txtMangSale_Quantity.Location = new System.Drawing.Point(132, 428);
            this.txtMangSale_Quantity.Name = "txtMangSale_Quantity";
            this.txtMangSale_Quantity.Size = new System.Drawing.Size(150, 20);
            this.txtMangSale_Quantity.TabIndex = 5;
            this.txtMangSale_Quantity.TextChanged += new System.EventHandler(this.txtMangSale_Quantity_TextChanged);
            this.txtMangSale_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMangSale_Quantity_KeyPress);
            this.txtMangSale_Quantity.Leave += new System.EventHandler(this.txtMangSale_Quantity_Leave);
            // 
            // txtMangSale_Price
            // 
            this.txtMangSale_Price.Location = new System.Drawing.Point(132, 397);
            this.txtMangSale_Price.Name = "txtMangSale_Price";
            this.txtMangSale_Price.Size = new System.Drawing.Size(150, 20);
            this.txtMangSale_Price.TabIndex = 4;
            this.txtMangSale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMangSale_Price_KeyPress);
            // 
            // txtMangSale_Total
            // 
            this.txtMangSale_Total.Location = new System.Drawing.Point(132, 459);
            this.txtMangSale_Total.Name = "txtMangSale_Total";
            this.txtMangSale_Total.ReadOnly = true;
            this.txtMangSale_Total.Size = new System.Drawing.Size(100, 20);
            this.txtMangSale_Total.TabIndex = 6;
            // 
            // btnMangSale_Update
            // 
            this.btnMangSale_Update.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangSale_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangSale_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangSale_Update.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangSale_Update.ForeColor = System.Drawing.Color.White;
            this.btnMangSale_Update.Location = new System.Drawing.Point(417, 382);
            this.btnMangSale_Update.Name = "btnMangSale_Update";
            this.btnMangSale_Update.Size = new System.Drawing.Size(75, 35);
            this.btnMangSale_Update.TabIndex = 8;
            this.btnMangSale_Update.Text = "UPDATE";
            this.btnMangSale_Update.UseVisualStyleBackColor = false;
            this.btnMangSale_Update.Click += new System.EventHandler(this.btnMangSale_Edit_Click);
            // 
            // btnMangSale_Delete
            // 
            this.btnMangSale_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangSale_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangSale_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangSale_Delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangSale_Delete.ForeColor = System.Drawing.Color.White;
            this.btnMangSale_Delete.Location = new System.Drawing.Point(417, 436);
            this.btnMangSale_Delete.Name = "btnMangSale_Delete";
            this.btnMangSale_Delete.Size = new System.Drawing.Size(75, 35);
            this.btnMangSale_Delete.TabIndex = 9;
            this.btnMangSale_Delete.Text = "DELETE";
            this.btnMangSale_Delete.UseVisualStyleBackColor = false;
            this.btnMangSale_Delete.Click += new System.EventHandler(this.btnMangSale_Delete_Click);
            // 
            // lblMangSale_ID
            // 
            this.lblMangSale_ID.AutoSize = true;
            this.lblMangSale_ID.BackColor = System.Drawing.Color.Transparent;
            this.lblMangSale_ID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangSale_ID.ForeColor = System.Drawing.Color.White;
            this.lblMangSale_ID.Location = new System.Drawing.Point(12, 337);
            this.lblMangSale_ID.Name = "lblMangSale_ID";
            this.lblMangSale_ID.Size = new System.Drawing.Size(29, 18);
            this.lblMangSale_ID.TabIndex = 58;
            this.lblMangSale_ID.Text = "Id:";
            // 
            // txtMangSale_saleID
            // 
            this.txtMangSale_saleID.Location = new System.Drawing.Point(132, 336);
            this.txtMangSale_saleID.Name = "txtMangSale_saleID";
            this.txtMangSale_saleID.ReadOnly = true;
            this.txtMangSale_saleID.Size = new System.Drawing.Size(100, 20);
            this.txtMangSale_saleID.TabIndex = 2;
            // 
            // cbMangSale_coffName
            // 
            this.cbMangSale_coffName.FormattingEnabled = true;
            this.cbMangSale_coffName.Location = new System.Drawing.Point(132, 366);
            this.cbMangSale_coffName.Name = "cbMangSale_coffName";
            this.cbMangSale_coffName.Size = new System.Drawing.Size(150, 21);
            this.cbMangSale_coffName.TabIndex = 3;
            this.cbMangSale_coffName.SelectedIndexChanged += new System.EventHandler(this.cbMangSale_coffName_SelectedIndexChanged);
            this.cbMangSale_coffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMangSale_coffName_KeyPress);
            // 
            // cbMangSale_FilterBy
            // 
            this.cbMangSale_FilterBy.FormattingEnabled = true;
            this.cbMangSale_FilterBy.Location = new System.Drawing.Point(105, 16);
            this.cbMangSale_FilterBy.Name = "cbMangSale_FilterBy";
            this.cbMangSale_FilterBy.Size = new System.Drawing.Size(121, 21);
            this.cbMangSale_FilterBy.TabIndex = 1;
            this.cbMangSale_FilterBy.SelectedIndexChanged += new System.EventHandler(this.cbMangSale_FilterBy_SelectedIndexChanged);
            this.cbMangSale_FilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMangSale_FilterBy_KeyPress);
            // 
            // btnMangSale_Next
            // 
            this.btnMangSale_Next.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangSale_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangSale_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangSale_Next.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangSale_Next.ForeColor = System.Drawing.Color.White;
            this.btnMangSale_Next.Location = new System.Drawing.Point(658, 246);
            this.btnMangSale_Next.Name = "btnMangSale_Next";
            this.btnMangSale_Next.Size = new System.Drawing.Size(60, 35);
            this.btnMangSale_Next.TabIndex = 11;
            this.btnMangSale_Next.Text = ">>";
            this.btnMangSale_Next.UseVisualStyleBackColor = false;
            this.btnMangSale_Next.Click += new System.EventHandler(this.btnMangSale_Next_Click);
            // 
            // btnMangSale_Prev
            // 
            this.btnMangSale_Prev.BackColor = System.Drawing.Color.DarkRed;
            this.btnMangSale_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMangSale_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMangSale_Prev.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangSale_Prev.ForeColor = System.Drawing.Color.White;
            this.btnMangSale_Prev.Location = new System.Drawing.Point(592, 246);
            this.btnMangSale_Prev.Name = "btnMangSale_Prev";
            this.btnMangSale_Prev.Size = new System.Drawing.Size(60, 35);
            this.btnMangSale_Prev.TabIndex = 10;
            this.btnMangSale_Prev.Text = "<<";
            this.btnMangSale_Prev.UseVisualStyleBackColor = false;
            this.btnMangSale_Prev.Click += new System.EventHandler(this.btnMangSale_Prev_Click);
            // 
            // manageSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 496);
            this.Controls.Add(this.btnMangSale_Next);
            this.Controls.Add(this.btnMangSale_Prev);
            this.Controls.Add(this.cbMangSale_FilterBy);
            this.Controls.Add(this.txtMangSale_saleID);
            this.Controls.Add(this.lblMangSale_ID);
            this.Controls.Add(this.btnMangSale_Delete);
            this.Controls.Add(this.btnMangSale_Update);
            this.Controls.Add(this.txtMangSale_Total);
            this.Controls.Add(this.txtMangSale_Price);
            this.Controls.Add(this.txtMangSale_Quantity);
            this.Controls.Add(this.lblManageFormAllSalesHeading);
            this.Controls.Add(this.dgvMangSale);
            this.Controls.Add(this.cbMangSale_coffName);
            this.Controls.Add(this.btnMangSale_Add);
            this.Controls.Add(this.lblMangSale_Total);
            this.Controls.Add(this.lblMangSale_Price);
            this.Controls.Add(this.lblMangSale_Quantity);
            this.Controls.Add(this.lblMangSale_CoffName);
            this.Controls.Add(this.lblMangSale);
            this.Name = "manageSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageSalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMangSale;
        private System.Windows.Forms.Label lblMangSale_CoffName;
        private System.Windows.Forms.Label lblMangSale_Quantity;
        private System.Windows.Forms.Label lblMangSale_Price;
        private System.Windows.Forms.Label lblMangSale_Total;
        private System.Windows.Forms.Button btnMangSale_Add;
        private System.Windows.Forms.DataGridView dgvMangSale;
        private System.Windows.Forms.Label lblManageFormAllSalesHeading;
        private System.Windows.Forms.TextBox txtMangSale_Quantity;
        private System.Windows.Forms.TextBox txtMangSale_Price;
        private System.Windows.Forms.TextBox txtMangSale_Total;
        private System.Windows.Forms.Button btnMangSale_Update;
        private System.Windows.Forms.Button btnMangSale_Delete;
        private System.Windows.Forms.Label lblMangSale_ID;
        private System.Windows.Forms.TextBox txtMangSale_saleID;
        private System.Windows.Forms.ComboBox cbMangSale_coffName;
        private System.Windows.Forms.ComboBox cbMangSale_FilterBy;
        private System.Windows.Forms.Button btnMangSale_Next;
        private System.Windows.Forms.Button btnMangSale_Prev;
    }
}