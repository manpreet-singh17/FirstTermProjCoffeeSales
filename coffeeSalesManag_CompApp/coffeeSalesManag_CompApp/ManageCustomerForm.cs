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
    public partial class ManageCustomerForm : Form
    {
        public ManageCustomerForm()
        {
            InitializeComponent();
            fillDataGridView();//METHOD CALL TO FILL DATA GRID VIEW.
        }

        /********************CRUD Operations***************/

        //ADD OPERATION.
        private void btnMangCust_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE DB CONTEXT.
                DbCoffeeContext _db = new DbCoffeeContext();
                Customer custObj = new Customer();//BLANK CUST OBJECT.

                //FILLING OBJECT WITH VALUES.
                custObj.CustomerName = txtMangCust_Name.Text.Trim();
                custObj.Age = Convert.ToInt32(txtMangCust_Age.Text.Trim());
                custObj.MobileNumber = Convert.ToInt32(txtMangCust_MobNum.Text.Trim());
                custObj.DateTime = DateTime.Now;

                //CHECK WHICH RADIO BUTTON IS CLICKED.
                if (RbMangCust_Male.Checked)
                {
                    custObj.Gender = "Male";
                }
                else
                {
                    custObj.Gender = "Female";
                }
                
                _db.Customers.Add(custObj);//ADDING OBJECT TO DATABASE.

                _db.SaveChanges();//SAVING CHANGES
                MessageBox.Show("Customer Added.");
                fillDataGridView();
                emptyAllControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DELETE OPERATION.
        private void btnMangCust_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DbCoffeeContext _db = new DbCoffeeContext();
                    int recId = Convert.ToInt32(txtMangCust_ID.Text);

                    var custObj = _db.Customers
                        .Where(x => x.ID == recId)
                        .FirstOrDefault();

                    _db.Customers.Remove(custObj);
                    _db.SaveChanges();
                    MessageBox.Show("Customer Deleted");
                    fillDataGridView();
                    emptyAllControls();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        //UPDATE OPERATION.
        private void btnMangCust_Update_Click(object sender, EventArgs e)
        {
            try
            {
                //create db context.
                DbCoffeeContext _db = new DbCoffeeContext();
                //get record ID from UI.
                int recId = Convert.ToInt32(txtMangCust_ID.Text);

                //getting customer obj depend on ID.
                Customer cObj = _db.Customers
                    .Where(x => x.ID == recId).FirstOrDefault();

                //Modifying values of object.
                cObj.ID = Convert.ToInt32(txtMangCust_ID.Text);

                cObj.CustomerName = txtMangCust_Name.Text;

                if (txtMangCust_Age.Text == string.Empty)
                {
                    throw new InvalidCastException("Please enter customer age.");
                } 

                if (txtMangCust_MobNum.Text == string.Empty)
                {
                    throw new InvalidCastException("Please enter customer Mobile Number.");
                }
                
                cObj.Age = Convert.ToInt32(txtMangCust_Age.Text);
                cObj.MobileNumber = Convert.ToInt32(txtMangCust_MobNum.Text);

                if (RbMangCust_Male.Checked)
                {
                    cObj.Gender = "Male";
                }
                else
                {
                    cObj.Gender = "Female";
                }

                //_db.Entry(cObj).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                MessageBox.Show("Customer Updated.");
                fillDataGridView();//method call to fill datagridview.
                emptyAllControls();//method to emptyAllControls.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //EVENT TO CONTROL INPUT OF CUSTOMER NAME.
        private void txtMangCust_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && ch != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Please enter text only.");
            }
        }

        //EVENT TO CONTROL INPUT OF CUSTOMER AGE.
        private void txtMangCust_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numeric value only.");
            }
        }

        //EVENT TO CONTROL INPUT OF CUSTOMER MOBILE NUMBER.
        private void txtMangCust_MobNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numeric value only.");
            }
        }

        //EVENT FOR CELL CLICK TO READ A ROW.
        private void dgvMangCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int recID = getIdOfCurrentRow();//method call to get rec id.
            DbCoffeeContext _db = new DbCoffeeContext();//create instance of db context
            //getting obj from table customers.
            var custObj = _db.Customers.Where(x => x.ID == recID).FirstOrDefault();
            //filling feilds on UI.
            txtMangCust_ID.Text = custObj.ID.ToString();
            txtMangCust_Name.Text = custObj.CustomerName;
            txtMangCust_Age.Text = custObj.Age.ToString();
            txtMangCust_MobNum.Text = custObj.MobileNumber.ToString();
            if (custObj.Gender == "Male" )
            {
                RbMangCust_Male.Checked = true;
            }
            else
            {
                RbMangCust_FeMale.Checked = true;
            }
        }

        /****************METHODS********************/

        //METHOD TO FILL DATA GRID VIEW.
        void fillDataGridView()
        {
            DbCoffeeContext _db = new DbCoffeeContext();
            //FILLING DATASOURCE OF DATA GRID VIEW.
            dgvMangCust.DataSource = _db.Customers.ToList();
        }

        //method to get id of current selected row of data grid view.
        int getIdOfCurrentRow()
        {
            //getting current selected row.
            DataGridViewRow currentRow = dgvMangCust.CurrentRow;
            //geting ID from row.
            int recID = Convert.ToInt32(currentRow.Cells[0].Value);
            return recID;//returning ID.
        }

        //empty all controls.
        void emptyAllControls()
        {
            //set all controls to empty state.
            txtMangCust_ID.Text = string.Empty;
            txtMangCust_Name.Text = string.Empty;
            txtMangCust_Age.Text = string.Empty;
            txtMangCust_MobNum.Text = string.Empty;
            RbMangCust_FeMale.Checked = false;
            RbMangCust_Male.Checked = false;
        }
    }
}
