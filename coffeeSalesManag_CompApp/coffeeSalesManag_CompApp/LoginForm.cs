using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeSalesManag_CompApp.Models;

namespace coffeeSalesManag_CompApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        //event for login btn.
        private void btnLogin_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtLogin_userName.Text.Trim();
                string password = txtLogin_Password.Text.Trim();

                if (userName != string.Empty && password != string.Empty)
                {
                    DbCoffeeContext _db = new DbCoffeeContext();
                    var resultObj = _db.employees
                            .Where(x => x.UserName == userName && x.Password == password)
                            .FirstOrDefault();
                    
                    if (resultObj != null)
                    {
                        this.Hide();
                        MainForm mainFrm = new MainForm();
                        mainFrm.Show();
                        mainFrm.enableAllControls();
                        mainFrm.btnMainFrm_LogOut.Text = string.Format("{0} {1}","Log Out", userName);
                    }
                    else
                    {
                        throw new Exception("Wrong username or password.");
                    }   
                }
                else
                {
                    MessageBox.Show("Please enter user name and password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
