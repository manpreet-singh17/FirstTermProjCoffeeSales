namespace coffeeSalesManag_CompApp
{
    partial class BackUpForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backUpFrm_btnBackUp = new System.Windows.Forms.Button();
            this.backUpFrm_txtLocation = new System.Windows.Forms.TextBox();
            this.backUpFrm_btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backUpFrm_btnBrowse);
            this.groupBox1.Controls.Add(this.backUpFrm_txtLocation);
            this.groupBox1.Controls.Add(this.backUpFrm_btnBackUp);
            this.groupBox1.Location = new System.Drawing.Point(94, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back Up";
            // 
            // backUpFrm_btnBackUp
            // 
            this.backUpFrm_btnBackUp.Enabled = false;
            this.backUpFrm_btnBackUp.Location = new System.Drawing.Point(382, 105);
            this.backUpFrm_btnBackUp.Name = "backUpFrm_btnBackUp";
            this.backUpFrm_btnBackUp.Size = new System.Drawing.Size(75, 23);
            this.backUpFrm_btnBackUp.TabIndex = 0;
            this.backUpFrm_btnBackUp.Text = "BackUp";
            this.backUpFrm_btnBackUp.UseVisualStyleBackColor = true;
            this.backUpFrm_btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // backUpFrm_txtLocation
            // 
            this.backUpFrm_txtLocation.Location = new System.Drawing.Point(23, 42);
            this.backUpFrm_txtLocation.Name = "backUpFrm_txtLocation";
            this.backUpFrm_txtLocation.Size = new System.Drawing.Size(295, 20);
            this.backUpFrm_txtLocation.TabIndex = 1;
            // 
            // backUpFrm_btnBrowse
            // 
            this.backUpFrm_btnBrowse.Location = new System.Drawing.Point(324, 39);
            this.backUpFrm_btnBrowse.Name = "backUpFrm_btnBrowse";
            this.backUpFrm_btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.backUpFrm_btnBrowse.TabIndex = 2;
            this.backUpFrm_btnBrowse.Text = "Browse";
            this.backUpFrm_btnBrowse.UseVisualStyleBackColor = true;
            this.backUpFrm_btnBrowse.Click += new System.EventHandler(this.backUpFrm_btnBrowse_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "BackUpForm";
            this.Text = "BackUpForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backUpFrm_btnBackUp;
        private System.Windows.Forms.Button backUpFrm_btnBrowse;
        private System.Windows.Forms.TextBox backUpFrm_txtLocation;
    }
}