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
using coffeeSalesManag_CompApp.Models.CoffeeManagement;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Data.Entity;

namespace coffeeSalesManag_CompApp
{
    public partial class manageCoffeesForm : Form
    {
        int coffObjectID;
        public manageCoffeesForm()
        {
            
            InitializeComponent();
            
            //populating combo boxes.
            populatecbCoffee(cbMngCof_CofName_Update);
            populatecbCoffee(cbMngCof_DeleteCof_Del);
            fillDataGridView();//fill datagrid view.
            EnableDisablePreviousButton();//method call to disable previous btn.
            EnableDisableNextButton();//method call to disable next btn.
        }

        /****************************DB operations**************************/

        //Event for ADD Coffee.
        private void AddCoffee(object sender, EventArgs e)
        {
            bool flag = false;//flag variable for final db operation.
            bool isCoffeNameExits = false;//var to check coffee name exists or not.

            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();//creating db connection.
                var coffObj = new Coffee();//creating object of model class.
                
                //setting returned value by checkCoffeeName
                isCoffeNameExits = checkCoffeeName(txtMngCof_CofName_Add.Text);

                //if coffee doesn't exist then populate our coffee obj.
                if (isCoffeNameExits)
                {
                    MessageBox.Show("Coffe name already exits.");
                }
                else
                {
                    //adding all values in model object.
                    coffObj.CoffeeName = txtMngCof_CofName_Add.Text.Trim().ToLower();
                    coffObj.CoffePrice = txt_MngCof_Price_Add.Text.Trim();
                    coffObj.DateTimeStamp = DateTime.Now;//adding date time to object.
                    flag = true;//shows all validations done.
                }
                //if all validations are ok then flag will set to true.
                if (flag)
                {
                    _db.Coffee.Add(coffObj);//adding model object to db.
                    _db.SaveChanges();//saving changes to db.

                    MessageBox.Show("Coffee Added.");
                    fillDataGridView();
                    EnableDisablePreviousButton();//method call to disable previous btn.
                    EnableDisableNextButton();//method call to disable next btn.

                    //empty the text boxes.
                    txtMngCof_CofName_Add.Text = "";
                    txt_MngCof_Price_Add.Text = "";
                    //calling populate Combo box to update Combo boxes.
                    populatecbCoffee(cbMngCof_CofName_Update);
                    populatecbCoffee(cbMngCof_DeleteCof_Del);
                }
            }
            //if any exception in upper block then it will catch by this block.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//eception message.
            }    
        }
        /**********Code for DELETE operation************/

        //event to check selected coffee name changed or not.
        private void cbManageCoffeeDeleteCoffee_SelectedValueChanged(object sender, EventArgs e)
        {
            showCoffPrice(cbMngCof_DeleteCof_Del.Text, txtMngCof_Price_Del);
        }

        //event to stop writing something in coffe price field.
        private void txtManageCoffeDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMngCof_Price_Del.Enabled = false;
            char ch = e.KeyChar;
            if (char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                MessageBox.Show("You can't write in this box.");
            }
        }

        //event to DELETE cofffee.
        private void btnManageCoffeeDeleteCoffee_Click(object sender, EventArgs e)
        {
            //checking if user gives feedback as OK.
            if (MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    //creating db contex.
                    DbCoffeeContext _db = new DbCoffeeContext();
                    //fetching reslts from coffee table depend on coffee name.
                    var result = _db.Coffee
                                 .Where(x => x.CoffeeName == cbMngCof_DeleteCof_Del.Text)
                                 .FirstOrDefault();

                    _db.Coffee.Remove(result);//removing coffee object.
                    _db.SaveChanges();//saving changes to db.
                    MessageBox.Show("Record Deleted");
                    fillDataGridView();
                    EnableDisablePreviousButton();//method call to disable previous btn.
                    EnableDisableNextButton();//method call to disable next btn.
                    populatecbCoffee(cbMngCof_CofName_Update);
                    populatecbCoffee(cbMngCof_DeleteCof_Del);
                    //poulating combo boxes.
                    populatecbCoffee(cbMngCof_DeleteCof_Del);
                    populatecbCoffee(cbMngCof_CofName_Update);
                    txtMngCof_Price_Del.Text = string.Empty;//empty text field.
                    cbMngCof_DeleteCof_Del.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /**********UPDATE COFFEE CODE***************/

        //event to show coffe price when selected index changed.
        private void cbManageCoffee_CofName_Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            showCoffPrice(cbMngCof_CofName_Update.Text, txtMngCof_CoffPrice_Update);
            txtMngCof_CoffPrice_Update.Enabled = false;
        }

        //keyPress event for updated New Coffee Name.
        private void txtMngCof_UpdatedCofName_Update_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != 8)//8 is for space.
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters.");
                
            }
        }

        //keypress event to allow only letter backspace and .
        private void txtManageForm_NewPrice_Update_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !(ch == (char)Keys.Back) && !(ch == 46))// 46 is for .
            {
                e.Handled = true;
                MessageBox.Show("Please enter Decimel values only.");
            }
        }

        //event to UPDATE the coffe name.
        private void btnManageCoffeeUpdateCoffee_Click(object sender, EventArgs e)
        {
            bool isExist;
            try
            {   
                DbCoffeeContext _db = new DbCoffeeContext();
                Coffee objCof = new Coffee();

                isExist = checkCoffeeName(txtMngCof_UpdatedCofName_Update.Text);
                if (isExist)
                {
                    MessageBox.Show("Coffee name already exists.");
                }
                else
                {
                    objCof.CoffeeName = txtMngCof_UpdatedCofName_Update.Text.Trim();
                    objCof.CoffePrice = txtManageForm_NewPrice_Update.Text.Trim();
                    objCof.ID = coffObjectID;//assigning id of record to obj for EF tracking.
                    _db.Coffee.Attach(objCof);//attach method calling to update coffee record.
                    //setting both properties to modified true mode.
                    _db.Entry(objCof).Property(x => x.CoffeeName).IsModified = true;
                    _db.Entry(objCof).Property(x => x.CoffePrice).IsModified = true;
                    _db.SaveChanges();//saving changes to db.
                    MessageBox.Show("Updated");
                    fillDataGridView();
                    EnableDisablePreviousButton();//method call to disable previous btn.
                    EnableDisableNextButton();//method call to disable next btn.
                    populatecbCoffee(cbMngCof_CofName_Update);
                    populatecbCoffee(cbMngCof_DeleteCof_Del);

                    cbMngCof_CofName_Update.Text = string.Empty;
                    txtMngCof_CoffPrice_Update.Text = string.Empty;
                    txtMngCof_UpdatedCofName_Update.Text = string.Empty;
                    txtManageForm_NewPrice_Update.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /*****************************Method and events sections*************************/

        //method to populate Combo Box for coffe name.
        void populatecbCoffee(ComboBox cbName)
        {
            DbCoffeeContext _db = new DbCoffeeContext();

            var coffList = _db.Coffee.ToList();//getting all record from db.
            cbName.Items.Clear();//clearing the cheeck box first.
            //foreach for aall objects.
            foreach (var item in coffList)
            {
                //adding coffee names to check box.
                cbName.Items.Add(item.CoffeeName);
            }          
        }
        
        //method to show coffe price for both delete and update operation depend on combo box.
        void showCoffPrice(string CoffName, TextBox txtBoxName)
        {
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();
                //getting coffee obj for specific coffee name.
                var resultObj = _db.Coffee
                    .Where(x => x.CoffeeName == CoffName).FirstOrDefault();
                //setting coffee price.
                txtBoxName.Text = resultObj.CoffePrice;
                //setting ID to a class level variable.
                coffObjectID = resultObj.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mehtod to check coffee name exits or not.
        private bool checkCoffeeName(string coffName)
        {
            DbCoffeeContext _db = new DbCoffeeContext();//creating db connection.
            var coffObj = new Coffee();//creating object of model class.

            var coffeList = _db.Coffee.ToList();//getting all coffees from DB.
            //loop to check cooffee name exists or not.
            foreach (var item in coffeList)
            {
                //condition to check coffe name matches or not.
                if (item.CoffeeName == coffName)
                {
                    //return true if coffe name already exists.
                    return true;
                }
            }
            //return false if coffee name doesn't exits.
            return false;
        }












        void fillDataGridView()
        {
            DbCoffeeContext _db = new DbCoffeeContext();
            dgvManageCoffee.DataSource = _db.Coffee.Take(5).ToList();
        }

        //private void manageCoffeesForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the '_coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet.Coffees' table. You can move, or remove it, as needed.
        //    this.coffeesTableAdapter.Fill(this._coffeeSalesManag_CompApp_Models_DbCoffeeContextDataSet.Coffees);

        //    DbCoffeeContext _db = new DbCoffeeContext();//creating db connection.
        //    //fetching all coffee objects from db .
        //    dgvManageCoffee.DataSource = _db.Coffee.Take(10).ToList();
        //}







        //METHOD TO DISABLE PREVIOUS BUTTON IF NO RECORDS ARE THERE ON LEFT SIDE.
        void EnableDisablePreviousButton()
        {
            int firstRowIndex = dgvManageCoffee.Rows[0].Index;
            int firstRecId = (int)dgvManageCoffee.Rows[firstRowIndex].Cells[0].Value;
            DbCoffeeContext _db = new DbCoffeeContext();
            var resultObjs = _db.Coffee
                .Where(x => x.ID < firstRecId).ToList();
            if (resultObjs.Count == 0)
            {
                btnManageCoffeePrevious.Enabled = false;
            }
            else
            {
                btnManageCoffeePrevious.Enabled = true;
            }
        }

        //METHOD TO DISABLE NEXT BUTTON IF NO RECORDS ARE THERE ON RIGHT.
        void EnableDisableNextButton()
        {
            int lastRowIndex = dgvManageCoffee.Rows.Count - 1;
            int lastRecId = (int)dgvManageCoffee.Rows[lastRowIndex].Cells[0].Value;
            DbCoffeeContext _db = new DbCoffeeContext();
            var resultObj = _db.Coffee
                .Where(x => x.ID > lastRecId).ToList();
            if (resultObj.Count == 0)
            {
                btnManageCoffeeNext.Enabled = false;
            }
            else
            {
                btnManageCoffeeNext.Enabled = true;
            }
        }

        private void btnManageCoffeePrevious_Click(object sender, EventArgs e)
        {
            int firstRowIndex = dgvManageCoffee.Rows[0].Index;//fetch first row from dgv.
            //fetch id value for first record.
            int firstRecId = (int)dgvManageCoffee.Rows[firstRowIndex].Cells[0].Value;
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();
                //fetching previous five objects from data base.
                var fivePrevObjs = _db.Coffee
                    .Where(x => x.ID < firstRecId).Take(5).ToList();

                dgvManageCoffee.DataSource = null;//clear the data grid view.
                dgvManageCoffee.DataSource = fivePrevObjs;//setting objects in datagrid view.
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
            catch (Exception)
            {
                MessageBox.Show("No reocrds behind.");
            }
        }

        private void btnManageCoffeeNext_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dgvManageCoffee.Rows.Count - 1;
            //MessageBox.Show(lastRowIndex.ToString());
            int lastRecId = (int)dgvManageCoffee.Rows[lastRowIndex].Cells[0].Value;
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();
                //fetching next five objects from data base.
                var fiveNextObjs = _db.Coffee
                    .Where(x => x.ID > lastRecId).Take(5).ToList();
                dgvManageCoffee.DataSource = null;//clear the data grid view.
                dgvManageCoffee.DataSource = fiveNextObjs;//setting objects in datagrid view.
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
            catch (Exception)
            {
                MessageBox.Show("No Records further.");
            }
        }
    }
}
