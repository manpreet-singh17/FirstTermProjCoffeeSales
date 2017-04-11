using coffeeSalesManag_CompApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace coffeeSalesManag_CompApp
{
    public partial class manageSalesForm : Form
    {
        public manageSalesForm()
        {
            InitializeComponent();
            fillDataGridView();
            populatecbCoffee(cbMangSale_coffName);//populating combo box with coffee names.
            fillCB_FilterBy();//fiiling combo box with property names.
            EnableDisablePreviousButton();//method call to disable previous button.
            EnableDisableNextButton();//method call to disable next button.
        }

        /********************CRUD OPERATION*******************/

        //ADD operation.
        private void btnMangSale_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Sale saleObj = new Sale();//DECLARE OBJECT OF SALE TYPE.
                //POPULATING OBJECT.
                saleObj.CoffeeName = cbMangSale_coffName.Text;
                saleObj.Price = Convert.ToDouble(txtMangSale_Price.Text);
                saleObj.Quantity = Convert.ToInt32(txtMangSale_Quantity.Text);
                saleObj.Total = Convert.ToDouble(txtMangSale_Total.Text);
                saleObj.Date = DateTime.Now.Date;
                saleObj.Time = DateTime.Now.TimeOfDay;
                saleObj.AddBy = "Manpreet";

                DbCoffeeContext _db = new DbCoffeeContext();//intialise db object.
                _db.Sales.Add(saleObj);//adding sale obj to db.
                _db.SaveChanges();//saving changes to db.
                MessageBox.Show("Sale Added.");
                emptyAllControls();//method call to emptyAllControls.
                fillDataGridView();//method call to fillDataGridView.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //UPDATE OPERATION.
        private void btnMangSale_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                //method call to get specific object.
                var originalSaleObj = returnSpecificSaleObj();

                Sale saleObj = new Sale();
                saleObj.ID = Convert.ToInt32(txtMangSale_saleID.Text);
                saleObj.CoffeeName = cbMangSale_coffName.Text.Trim();
                saleObj.Price = Convert.ToDouble(txtMangSale_Price.Text);
                saleObj.Quantity = Convert.ToInt32(txtMangSale_Quantity.Text);
                saleObj.Total = Convert.ToDouble(txtMangSale_Total.Text);
                saleObj.Date = originalSaleObj.Date;
                saleObj.Time = originalSaleObj.Time;
                saleObj.AddBy = originalSaleObj.AddBy;

                DbCoffeeContext _db = new DbCoffeeContext();
                _db.Entry(saleObj).State = EntityState.Modified;
                _db.SaveChanges();

                //_db.Configuration.ValidateOnSaveEnabled = false;
                MessageBox.Show("Updated.");
                emptyAllControls();//method call to emptyAllControls.
                fillDataGridView();//method call to fillDataGridView.
            }
            //catch (DbEntityValidationException err)
            //{
            //    MessageBox.Show(err.Message);
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //DELETE OPERATION.
        private void btnMangSale_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this sale?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DbCoffeeContext _db = new DbCoffeeContext();//create context.
                    Sale saleObj = new Sale();//create sale obj.
                    saleObj.ID = Convert.ToInt32(txtMangSale_saleID.Text);//enter id of rec.
                    _db.Sales.Attach(saleObj);//attach sale obj to context.
                    _db.Sales.Remove(saleObj);//remove specific object.
                    _db.SaveChanges();//saving changes.
                    MessageBox.Show("Record Deleted");
                    emptyAllControls();//method call to emptyAllControls.
                    fillDataGridView();//method call to fillDataGridView.
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /************************** EVENTS ****************************/

        //EVENT TO STOP WRITING IN COMBO FILTERBY.
        private void cbMangSale_FilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            cbMangSale_FilterBy.Text = string.Empty ;//REMOVING ALL CONTENT FROM COMBO.    
            MessageBox.Show("You can't write here");
        }

        //EVENT TO FILTER ROWS IN DATA GRID VIEW UPON SELECTED INDEX CHANGE OF ORDERBY.
        private void cbMangSale_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbCoffeeContext _db = new DbCoffeeContext();
            if (cbMangSale_FilterBy.Text == "ID")
            {
                var resultObjs = _db.Sales
                    .OrderBy(x => x.ID).ToList();
                dgvMangSale.DataSource = null;
                dgvMangSale.DataSource = resultObjs;
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
            else if (cbMangSale_FilterBy.Text == "CoffeeName")
            {
                var resultObjs = _db.Sales
                    .OrderBy(x => x.CoffeeName).ToList();
                dgvMangSale.DataSource = null;
                dgvMangSale.DataSource = resultObjs;
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
            else if (cbMangSale_FilterBy.Text == "AddBy")
            {
                var resultObjs = _db.Sales
                    .OrderBy(x => x.AddBy).ToList();
                dgvMangSale.DataSource = null;
                dgvMangSale.DataSource = resultObjs;
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
            else if (cbMangSale_FilterBy.Text == "Date")
            {
                var resultObjs = _db.Sales
                    .OrderBy(x => x.Date).ToList();
                dgvMangSale.DataSource = null;
                dgvMangSale.DataSource = resultObjs;
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
            else if (cbMangSale_FilterBy.Text == "All")
            {
                fillDataGridView();//calling fill data grid view.
                EnableDisablePreviousButton();//method call to disable previous btn.
                EnableDisableNextButton();//method call to disable next btn.
            }
        }

        //EVENT TO CALL SHOW COFFEE PRICE METHOD.
        private void cbMangSale_coffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //METHOD TO SHOWCOFFPRICE.
            showCoffPrice(cbMangSale_coffName.Text, txtMangSale_Price);
            //METHOD CALL TO CALCULATE TOTAL.
            calculateTotal(txtMangSale_Price, txtMangSale_Quantity);
        }

        //EVENT TO CONTROL WRITING IN COFFEE COMBO BOX.
        private void cbMangSale_coffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            cbMangSale_coffName.Text = string.Empty;//removing text from coffee name combo box.
            MessageBox.Show("You can't write here.");
        }
        
        //EVENT TO CONTROL INPUT OF NEW COFFEE NAME.
        private void txtMangSale_NewCofName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters.");
            }
        }

        //EVENT TO CNTROL INPUT IN PRICE FEILD.
        private void txtMangSale_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !(ch == (char)Keys.Back) && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter on decimal number.");
            }
        }

        //KEYPRESS EVENT TO MAKE SURE QUANTITY IS NUMBER.
        private void txtMangSale_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !(ch == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only whole number less than 500.");
            }
        }
        //EVENT CALLED WHEN QUANTITY VALUE CHANGES AND CAN'T BE MORE THAN 500.
        private void txtMangSale_Quantity_TextChanged(object sender, EventArgs e)
        {
            //getting value from quantity field.
            string quantityFieldValue = txtMangSale_Quantity.Text.Trim();
            int quantity;//declare quantity varibale.
            //check if quantity has empty string.
            if (quantityFieldValue == string.Empty)
            {
                quantity = 1;//if true -> set quantity degfault value 1.
            }
            else
            {
                //if false -> convert to value.
                quantity = Convert.ToInt32(txtMangSale_Quantity.Text.Trim());
            }
            //check if quantity more than 500.
            if (quantity > 500)
            {
                MessageBox.Show("Quantity can't be more than 500.");
                txtMangSale_Quantity.Text = string.Empty;
            }
        }
        //EVENT CALLED WHEN QUANTITY FIELD LEFT.
        private void txtMangSale_Quantity_Leave(object sender, EventArgs e)
        {
            //Method call to calculate total from peice and quantity.
            calculateTotal(txtMangSale_Price, txtMangSale_Quantity);
        }

        //EVENT TO GET NEXT FIVE RECORDS.
        private void btnMangSale_Next_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dgvMangSale.Rows.Count - 1;
            //MessageBox.Show(lastRowIndex.ToString());
            int lastRecId = (int)dgvMangSale.Rows[lastRowIndex].Cells[0].Value;

            DbCoffeeContext _db = new DbCoffeeContext();
            //fetching next five objects from data base.
            var fiveNextObjs = _db.Sales
                .Where(x => x.ID > lastRecId).Take(5).ToList();

            dgvMangSale.DataSource = null;//clear the data grid view.
            dgvMangSale.DataSource = fiveNextObjs;//setting objects in datagrid view.
            EnableDisablePreviousButton();//method call to disable previous btn.
            EnableDisableNextButton();//method call to disable next btn.
        }

        //EVENT TO GET FIVE PREVIOUS RECORDS.
        private void btnMangSale_Prev_Click(object sender, EventArgs e)
        {
            int firstRowIndex = dgvMangSale.Rows[0].Index;//fetch first row from dgv.
            //fetch id value for first record.
            int firstRecId = (int)dgvMangSale.Rows[firstRowIndex].Cells[0].Value;

            DbCoffeeContext _db = new DbCoffeeContext();
            //fetching previous five objects from data base.
            var fivePrevObjs = _db.Sales
                .Where(x => x.ID < firstRecId).Take(5).ToList();

            dgvMangSale.DataSource = null;//clear the data grid view.
            dgvMangSale.DataSource = fivePrevObjs;//setting objects in datagrid view.
            EnableDisablePreviousButton();//method call to disable previous btn.
            EnableDisableNextButton();//method call to disable next btn.
        }
        
        //EVENT TO GET CURRENT ROW DATA.
        private void dgvMangSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var saleObj = returnSpecificSaleObj();

            txtMangSale_saleID.Text = saleObj.ID.ToString();
            cbMangSale_coffName.Text = saleObj.CoffeeName;
            cbMangSale_coffName.Text = saleObj.CoffeeName;
            txtMangSale_Price.Text = saleObj.Price.ToString();
            txtMangSale_Quantity.Text = saleObj.Quantity.ToString();
            txtMangSale_Total.Text = saleObj.Total.ToString();
        }

        /*************************** METHODS ********************************/

        //method to populate Combo Box for coffe name.
        void populatecbCoffee(ComboBox cbName)
        {
            DbCoffeeContext _db = new DbCoffeeContext();

            var coffList = _db.Coffee.ToList();//getting all record from db.
            cbMangSale_coffName.Items.Clear();//clearing the cheeck box first.
            //foreach for all objects.
            foreach (var item in coffList)
            {
                //adding coffee names to check box.
                cbName.Items.Add(item.CoffeeName);
            }
        }

        //METHOD TO SHOW COFFEE PRICE USING COFFEE NAME.
        void showCoffPrice(string coffeeName, TextBox txtBoxName)
        {
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();

                //getting coffee obj for specific coffee name.
                var resultObj = _db.Coffee
                    .Where(x => x.CoffeeName == coffeeName).FirstOrDefault();

                //setting coffee price.
                txtMangSale_Price.Text = resultObj.CoffePrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //METHOD TO CALCULATE TOTAL.
        void calculateTotal(TextBox priceBox, TextBox quantityBox)
        {
            try
            {
                //CHECK IF BOTH PRICE AND QUANTITY ARE NOT EMPTY.
                if (priceBox.Text != string.Empty && quantityBox.Text != string.Empty)
                {
                    int quantity;//declare quantity variable.
                    double price = Convert.ToDouble(priceBox.Text);//convert price to double.
                    //if condition to check quantity is empty or not.
                    if (quantityBox.Text == string.Empty)
                    {
                        quantity = 1;//set to 1 if empty.
                    }
                    else
                    {
                        quantity = Convert.ToInt32(quantityBox.Text);//convert quantity to int.   
                    }
                    double total = (price * quantity);//cal total.
                    txtMangSale_Total.Text = total.ToString();//seting total to TOTAL feild.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //METHOD TO FILL COMBO BOX FILTERBY.
        void fillCB_FilterBy()
        {
            Sale saleObj = new Sale();//creating object of sale.
            //setting property names in combo box.
            cbMangSale_FilterBy.Items.Add("All");
            cbMangSale_FilterBy.Items.Add(nameof(saleObj.ID));
            cbMangSale_FilterBy.Items.Add(nameof(saleObj.CoffeeName));
            cbMangSale_FilterBy.Items.Add(nameof(saleObj.Date));
            cbMangSale_FilterBy.Items.Add(nameof(saleObj.AddBy));
        }

        //Method to fill data grid view.
        void fillDataGridView()
        {
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();
                dgvMangSale.DataSource = _db.Sales.Take(5).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //METHOD TO DISABLE PREVIOUS BUTTON IF NO RECORDS ARE THERE ON LEFT SIDE.
        void EnableDisablePreviousButton()
        {
            int firstRowIndex = dgvMangSale.Rows[0].Index;
            int firstRecId = (int)dgvMangSale.Rows[firstRowIndex].Cells[0].Value;
            DbCoffeeContext _db = new DbCoffeeContext();
            var resultObjs = _db.Sales
                .Where(x => x.ID < firstRecId).ToList();
            if (resultObjs.Count == 0)
            {
                btnMangSale_Prev.Enabled = false;
            }
            else
            {
                btnMangSale_Prev.Enabled = true;
            }
        }

        //METHOD TO DISABLE NEXT BUTTON IF NO RECORDS ARE THERE ON RIGHT.
        void EnableDisableNextButton()
        {
            int lastRowIndex = dgvMangSale.Rows.Count - 1;
            int lastRecId = (int)dgvMangSale.Rows[lastRowIndex].Cells[0].Value;
            DbCoffeeContext _db = new DbCoffeeContext();
            var resultObj = _db.Sales
                .Where(x => x.ID > lastRecId).ToList();
            if (resultObj.Count == 0)
            {
                btnMangSale_Next.Enabled = false;
            }
            else
            {
                btnMangSale_Next.Enabled = true;
            }
        }

        //METHOD TO EMPTY ALL CONTROLS.
        void emptyAllControls()
        {
            txtMangSale_saleID.Text = string.Empty;
            cbMangSale_coffName.Text = string.Empty;
            cbMangSale_coffName.Text = string.Empty;
            txtMangSale_Price.Text = string.Empty;
            txtMangSale_Quantity.Text = string.Empty;
            txtMangSale_Total.Text = string.Empty;
        }

        //RETURN SPECIFIC SALE OBJECT.
        Sale returnSpecificSaleObj()
        {
            DataGridViewRow row = dgvMangSale.CurrentRow;
            int recId = (int)row.Cells[0].Value;
            //MessageBox.Show(recId.ToString());

            DbCoffeeContext _db = new DbCoffeeContext();
            var saleObj = _db.Sales
                .Where(x => x.ID == recId).FirstOrDefault();
            return saleObj;
        }
    }
}
