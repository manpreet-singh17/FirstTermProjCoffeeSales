namespace coffeeSalesManag_CompApp
{
    partial class LoginForm
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
            this.lblLogin_userName = new System.Windows.Forms.Label();
            this.lblLogin_Password = new System.Windows.Forms.Label();
            this.txtLogin_userName = new System.Windows.Forms.TextBox();
            this.txtLogin_Password = new System.Windows.Forms.TextBox();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin_userName
            // 
            this.lblLogin_userName.AutoSize = true;
            this.lblLogin_userName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_userName.Location = new System.Drawing.Point(97, 110);
            this.lblLogin_userName.Name = "lblLogin_userName";
            this.lblLogin_userName.Size = new System.Drawing.Size(98, 18);
            this.lblLogin_userName.TabIndex = 0;
            this.lblLogin_userName.Text = "User Name:";
            // 
            // lblLogin_Password
            // 
            this.lblLogin_Password.AutoSize = true;
            this.lblLogin_Password.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_Password.Location = new System.Drawing.Point(97, 164);
            this.lblLogin_Password.Name = "lblLogin_Password";
            this.lblLogin_Password.Size = new System.Drawing.Size(87, 18);
            this.lblLogin_Password.TabIndex = 1;
            this.lblLogin_Password.Text = "Password:";
            // 
            // txtLogin_userName
            // 
            this.txtLogin_userName.Location = new System.Drawing.Point(224, 111);
            this.txtLogin_userName.Name = "txtLogin_userName";
            this.txtLogin_userName.Size = new System.Drawing.Size(182, 20);
            this.txtLogin_userName.TabIndex = 2;
            // 
            // txtLogin_Password
            // 
            this.txtLogin_Password.Location = new System.Drawing.Point(224, 162);
            this.txtLogin_Password.Name = "txtLogin_Password";
            this.txtLogin_Password.PasswordChar = '*';
            this.txtLogin_Password.Size = new System.Drawing.Size(182, 20);
            this.txtLogin_Password.TabIndex = 3;
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_Login.Location = new System.Drawing.Point(224, 207);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(87, 29);
            this.btnLogin_Login.TabIndex = 4;
            this.btnLogin_Login.Text = "LogIn";
            this.btnLogin_Login.UseVisualStyleBackColor = true;
            this.btnLogin_Login.Click += new System.EventHandler(this.btnLogin_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 437);
            this.Controls.Add(this.btnLogin_Login);
            this.Controls.Add(this.txtLogin_Password);
            this.Controls.Add(this.txtLogin_userName);
            this.Controls.Add(this.lblLogin_Password);
            this.Controls.Add(this.lblLogin_userName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin_userName;
        private System.Windows.Forms.Label lblLogin_Password;
        private System.Windows.Forms.TextBox txtLogin_Password;
        private System.Windows.Forms.Button btnLogin_Login;
        public System.Windows.Forms.TextBox txtLogin_userName;
    }
}