namespace coffeeSalesManag_CompApp
{
    partial class AdminPanel
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
            this.btnAdminPanel_Coffee = new System.Windows.Forms.Button();
            this.btnAdminPanel_Customer = new System.Windows.Forms.Button();
            this.btnAdminPanel_Sales = new System.Windows.Forms.Button();
            this.btnAdminPanel_Employees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminPanel_Coffee
            // 
            this.btnAdminPanel_Coffee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel_Coffee.Location = new System.Drawing.Point(183, 118);
            this.btnAdminPanel_Coffee.Name = "btnAdminPanel_Coffee";
            this.btnAdminPanel_Coffee.Size = new System.Drawing.Size(170, 80);
            this.btnAdminPanel_Coffee.TabIndex = 1;
            this.btnAdminPanel_Coffee.Text = "Manage Coffee";
            this.btnAdminPanel_Coffee.UseVisualStyleBackColor = true;
            this.btnAdminPanel_Coffee.Click += new System.EventHandler(this.btnAdminPanel_Coffee_Click);
            // 
            // btnAdminPanel_Customer
            // 
            this.btnAdminPanel_Customer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel_Customer.Location = new System.Drawing.Point(375, 118);
            this.btnAdminPanel_Customer.Name = "btnAdminPanel_Customer";
            this.btnAdminPanel_Customer.Size = new System.Drawing.Size(170, 80);
            this.btnAdminPanel_Customer.TabIndex = 3;
            this.btnAdminPanel_Customer.Text = "Manage Customer";
            this.btnAdminPanel_Customer.UseVisualStyleBackColor = true;
            this.btnAdminPanel_Customer.Click += new System.EventHandler(this.btnAdminPanel_Customer_Click);
            // 
            // btnAdminPanel_Sales
            // 
            this.btnAdminPanel_Sales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel_Sales.Location = new System.Drawing.Point(375, 241);
            this.btnAdminPanel_Sales.Name = "btnAdminPanel_Sales";
            this.btnAdminPanel_Sales.Size = new System.Drawing.Size(170, 80);
            this.btnAdminPanel_Sales.TabIndex = 4;
            this.btnAdminPanel_Sales.Text = "Manage Sales";
            this.btnAdminPanel_Sales.UseVisualStyleBackColor = true;
            this.btnAdminPanel_Sales.Click += new System.EventHandler(this.btnAdminPanel_Sales_Click);
            // 
            // btnAdminPanel_Employees
            // 
            this.btnAdminPanel_Employees.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel_Employees.Location = new System.Drawing.Point(183, 241);
            this.btnAdminPanel_Employees.Name = "btnAdminPanel_Employees";
            this.btnAdminPanel_Employees.Size = new System.Drawing.Size(170, 80);
            this.btnAdminPanel_Employees.TabIndex = 2;
            this.btnAdminPanel_Employees.Text = "Manage Employees";
            this.btnAdminPanel_Employees.UseVisualStyleBackColor = true;
            this.btnAdminPanel_Employees.Click += new System.EventHandler(this.btnAdminPanel_Employees_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 443);
            this.Controls.Add(this.btnAdminPanel_Employees);
            this.Controls.Add(this.btnAdminPanel_Sales);
            this.Controls.Add(this.btnAdminPanel_Customer);
            this.Controls.Add(this.btnAdminPanel_Coffee);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminPanel_Coffee;
        private System.Windows.Forms.Button btnAdminPanel_Customer;
        private System.Windows.Forms.Button btnAdminPanel_Sales;
        private System.Windows.Forms.Button btnAdminPanel_Employees;
    }
}