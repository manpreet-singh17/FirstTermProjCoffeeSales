using coffeeSalesManag_CompApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeSalesManag_CompApp
{
    public partial class BackUpForm : Form
    {
        //create db connection.
        DbCoffeeContext _db = new DbCoffeeContext();

        public BackUpForm()
        {
            InitializeComponent();
        }
        

        //event for browse button.
        private void backUpFrm_btnBrowse_Click(object sender, EventArgs e)
        {
            //create form dialog browser.
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            //check for ok selected
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //assign selected path to location text.
                backUpFrm_txtLocation.Text = dlg.SelectedPath;
                //turn on Back up btn.
                backUpFrm_btnBackUp.Enabled = true;
            }
        }

        //event backup btn.
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            //check if location field is empty or not.
            if (backUpFrm_txtLocation.Text == string.Empty)
            {
                MessageBox.Show("Please select a path for back up file.");
            }
            //connctn string.
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=coffeeSalesManag_CompApp.Models.DbCoffeeContext;Integrated Security=True";

            //create sql connection obj.
            SqlConnection conn = new SqlConnection(connStr);

            //get database name using entity framework.
            string database = _db.Database.Connection.Database;

            try
            {
                //make cmd for backup database in sql.
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '"+backUpFrm_txtLocation.Text+"\\"+"example.bak"+"'";
                //MessageBox.Show(cmd);

                //create sqlcmd object.
                using (SqlCommand sqlCmd = new SqlCommand(cmd, conn))
                {
                    //check if connection is open or not.
                    if (conn.State != ConnectionState.Open)
                    {
                        //if not thenopen the cnnection
                        conn.Open();
                    }
                    //execute cmd.
                    sqlCmd.ExecuteNonQuery();
                    //close connection.
                    conn.Close();
                    MessageBox.Show("Back up completed.");
                    backUpFrm_btnBackUp.Enabled = false;//disable backup butn.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
