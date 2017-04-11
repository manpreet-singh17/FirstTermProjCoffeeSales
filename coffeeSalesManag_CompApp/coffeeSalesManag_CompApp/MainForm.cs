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

namespace coffeeSalesManag_CompApp
{
    public partial class MainForm : Form
    {
        string userName;

        public MainForm()
        {
            InitializeComponent();
            fillCoffeeComboBox();//fillComboBox method call.
            fillDataGridView();//Fill data grid view.
            disableAllControls();//disable all controls.
            loadBarChart();//method call to load bar chart.
        }

        //EVENT TO ADD SALE TO DB.
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();

                //PREPARE SALE OBJ.
                Sale saleObj = new Sale();
                saleObj.CoffeeName = cbMainForm_CoffeeName.Text;
                saleObj.Price = Convert.ToDouble(txtMainFrm_Price.Text);
                saleObj.Quantity = Convert.ToInt32(txtMainFrm_Quantity.Text);
                saleObj.Total = Convert.ToDouble(txtMainForm_Total.Text);
                saleObj.Date = DateTime.Now.Date;
                saleObj.Time = DateTime.Now.TimeOfDay;
                saleObj.AddBy = userName;


                //PREPARE CUSTOMER OBJ.
                Customer custObj = new Customer()
                {
                    CustomerName = txtMainFrm_CustName.Text,
                    Age = Convert.ToInt32(txtMainFrm_CustAge.Text),
                    Gender = cbMainFrm_Gender.Text,
                    MobileNumber = Convert.ToInt32(txtMainFrm_CustMobNum.Text),
                    DateTime = DateTime.Now
                };

                //SALE OBJ ADDED.
                _db.Sales.Add(saleObj);
                //CUST OBJ ADDED.
                _db.Customers.Add(custObj);

                //SAVING CHANGES DB.
                _db.SaveChanges();
                MessageBox.Show("Data Added.");
                fillDataGridView();//Fill data grid view.
                loadBarChart();// method call to load bar chart.

                cbMainForm_CoffeeName.Text = string.Empty;
                txtMainFrm_Price.Text = string.Empty;
                txtMainFrm_Quantity.Text = string.Empty;
                txtMainForm_Total.Text = string.Empty;
                txtMainFrm_CustName.Text = string.Empty;
                txtMainFrm_CustAge.Text = string.Empty;
                txtMainFrm_CustMobNum.Text = string.Empty;
                cbMainFrm_Gender.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //event for refresh button.
        private void btnRefreshFields_Click(object sender, EventArgs e)
        {
            cbMainForm_CoffeeName.Text = string.Empty;
            txtMainFrm_Price.Text = string.Empty;
            txtMainFrm_Quantity.Text = string.Empty;
            txtMainForm_Total.Text = string.Empty;
            txtMainFrm_CustName.Text = string.Empty;
            txtMainFrm_CustAge.Text = string.Empty;
            txtMainFrm_CustMobNum.Text = string.Empty;
            cbMainFrm_Gender.Text = string.Empty;
        }

        /********************************Events Section.*********************************/

        //event to show ManageCoffeeForm
        private void showManageCoffeeForm(object sender, EventArgs e)
        {
            try
            {
                manageCoffeesForm managCoffeeFrm = new manageCoffeesForm();
                managCoffeeFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //event to show Manage Sales Form.
        private void showManageSalesForm(object sender, EventArgs e)
        {
            try
            {
                manageSalesForm managSaleFrm = new manageSalesForm();
                managSaleFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //event to show Manage Customer Form.
        private void showManageCustForm(object sender, EventArgs e)
        {
            try
            {
                ManageCustomerForm mngCust = new ManageCustomerForm();
                mngCust.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        //EVENT TO SHOW MANAGE EMPLOYEE FORM.
        private void manageEmp_Click(object sender, EventArgs e)
        {
            try
            {
                manageEmployees empFrm = new manageEmployees();
                empFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        //Event to show back up form.
        private void backUp_Click(object sender, EventArgs e)
        {
            try
            {
                BackUpForm bckUp = new BackUpForm();
                bckUp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //EVENT FOR EXIT MENU STRIP ITEM.
        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Exit Window", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //LEAVE event for quantity.
        private void txtMainFrm_Quantity_Leave(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtMainFrm_Quantity.Text);
                double price = Convert.ToDouble(txtMainFrm_Price.Text);
                double total = (quantity * price);

                txtMainForm_Total.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //EVENT TO CONTROL INPUT OF COFFEE NAMES.
        private void cbCoffeeNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            cbMainForm_CoffeeName.Text = string.Empty;//removing text from coffee name combo box.
            MessageBox.Show("You can't write here.");
        }

        //EVENT TO CONTROL INPUT OF QUANTITY.
        private void txtMainFrm_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !(ch == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only whole number less than 500.");
            }
        }

        //EVENT TO CONTROL INPUT OF CUSTOMER NAME.
        private void txtMainFrm_CustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && ch != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Please enter text only.");
            }
        }

        //EVENT TO CONTROL INPUT OF CUSTOMER AGE.
        private void txtMainFrm_CustAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numeric value only.");
            }
        }

        //EVENT TO CONTROL INPUT OF CUSTOMER MOBILE NUMBER.
        private void txtMainFrm_CustMobNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numeric value only.");
            }
        }

        //EVENT TO CONTROL INPUT OF GENDER COMBO BOX.
        private void cbMainFrm_Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            cbMainFrm_Gender.Text = string.Empty;//removing text from coffee name combo box.
            MessageBox.Show("You can't write here.");
        }

        //EVETNT for LOG IN operation.
        private void btnMainFrm_Login_Click(object sender, EventArgs e)
        {
            try
            {
                userName = txtMainFrm_userName.Text.Trim();
                string password = txtMainFrm_Password.Text.Trim();

                if (userName != string.Empty && password != string.Empty)
                {
                    DbCoffeeContext _db = new DbCoffeeContext();
                    var resultObj = _db.employees
                            .Where(x => x.UserName == userName && x.Password == password)
                            .FirstOrDefault();

                    if (resultObj != null)
                    {
                        lblMainFrm_userName.Visible = false;
                        lblMainFrm_Password.Visible = false;
                        txtMainFrm_userName.Visible = false;
                        txtMainFrm_Password.Visible = false;
                        btnMainFrm_Login.Visible = false;

                        menuStripItem_logOut.Text = string.Format("{0} {1}", "Log Out", userName);
                        enableAllControls();//method call to enable all controls.

                        if (userName == "Admin" || userName == "admin")
                        {
                            manageCoffees.Visible = true;
                            manageSales.Visible = true;
                            manageCust.Visible = true;
                            manageEmp.Visible = true;
                            
                        }
                        else
                        {
                            manageCoffees.Visible = false;
                            manageSales.Visible = false;
                            manageCust.Visible = false;
                            manageEmp.Visible = false;
                        }
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
        //LOGOUT CLICK EVENT.
        private void menuStripItem_logOut_Click(object sender, EventArgs e)
        {
            disableAllControls();
            lblMainFrm_userName.Visible = true;
            lblMainFrm_Password.Visible = true;
            txtMainFrm_userName.Visible = true;
            txtMainFrm_Password.Visible = true;
            btnMainFrm_Login.Visible = true;

            txtMainFrm_userName.Text = string.Empty;
            txtMainFrm_Password.Text = string.Empty;
        }

        /****************************METHODS*****************************/
        //Method to fill coffe names.
        void fillCoffeeComboBox()
        {
            DbCoffeeContext _db = new DbCoffeeContext();
            cbMainForm_CoffeeName.Items.Clear();
            var coffeeObj = _db.Coffee.ToList();
            foreach (var item in coffeeObj)
            {
                cbMainForm_CoffeeName.Items.Add(item.CoffeeName.ToString());
            }
        }

        //METHOD TO DISABLE ALL CONTROLS.
        void disableAllControls()
        {
            menuStripMainForm.Enabled = false;
            dataGridViewMainWindow.Enabled = false;

            
            btnAddSale.Enabled = false;
            btnRefreshFields.Enabled = false;

            lblCoffeeName.Enabled = false;
            lblCoffeeQuantity.Enabled = false;
            lblCoffeePrice.Enabled = false;
            lblCoffeeTotal.Enabled = false;
            lblCustomerName.Enabled = false;
            lblMainFormMobNum.Enabled = false;
            lblCustomerAge.Enabled = false;
            lblMainFrm_Gender.Enabled = false;
            lblMainForm_SaleCountHeading.Enabled = false;

            cbMainForm_CoffeeName.Enabled = false;
            cbMainFrm_Gender.Enabled = false;

            txtMainFrm_Price.Enabled = false;
            txtMainForm_Total.Enabled = false;
            txtMainFrm_Quantity.Enabled = false;
            txtMainFrm_CustName.Enabled = false;
            txtMainFrm_CustAge.Enabled = false;
            txtMainFrm_CustMobNum.Enabled = false;

            menuStripItem_logOut.Visible = false;
            txtMainForm_SaleCount.Enabled = false;
        }

        //Method for enable al controls.
        public void enableAllControls()
        {
            menuStripMainForm.Enabled = true;
            dataGridViewMainWindow.Enabled = true;

            btnAddSale.Enabled = true;
            btnRefreshFields.Enabled = true;

            lblCoffeeName.Enabled = true;
            lblCoffeeQuantity.Enabled = true;
            lblCoffeePrice.Enabled = true;
            lblCoffeeTotal.Enabled = true;
            lblCustomerName.Enabled = true;
            lblMainFormMobNum.Enabled = true;
            lblCustomerAge.Enabled = true;
            lblMainFrm_Gender.Enabled = true;
            lblMainForm_SaleCountHeading.Enabled = true;

            cbMainForm_CoffeeName.Enabled = true;
            cbMainFrm_Gender.Enabled = true;

            txtMainFrm_Price.Enabled = true;
            txtMainForm_Total.Enabled = true;
            txtMainFrm_Quantity.Enabled = true;
            txtMainFrm_CustName.Enabled = true;
            txtMainFrm_CustAge.Enabled = true;
            txtMainFrm_CustMobNum.Enabled = true;
            txtMainForm_SaleCount.Enabled = true;

            menuStripItem_logOut.Visible = true;
            
        }

        

        //EVENT for selected index changed.
        private void cbCoffeeNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();
                string coffeeName = cbMainForm_CoffeeName.Text;
                string price = _db.Coffee
                        .Where(x => x.CoffeeName == coffeeName)
                        .Select(x => x.CoffePrice)
                        .FirstOrDefault();

                txtMainFrm_Price.Text = price;   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to fill data grid view of home page.
        void fillDataGridView()
        {
            DbCoffeeContext _db = new DbCoffeeContext();
            DateTime todayDateTime = DateTime.Now;

            var saleObjs = _db.Sales
                                .Where(x => x.Date == todayDateTime.Date)
                                .ToList();

            txtMainForm_SaleCount.Text = saleObjs.Count.ToString();

            dataGridViewMainWindow.DataSource = saleObjs;
        }

        void loadBarChart()
        {
            barChart.Series["Sale"].Points.Clear();
            int hotChocCount = 0;
            int capaCount = 0;
            DbCoffeeContext _db = new DbCoffeeContext();

            DateTime todayDate = DateTime.Now.Date;


            List<Sale> sales = _db.Sales
                            .Where(x => x.Date == todayDate)
                            .ToList();
            foreach (var item in sales)
            {
                switch (item.CoffeeName)
                {
                    case "hot choclate":
                        hotChocCount += 1;
                        break;
                    case "capa":
                        capaCount += 1;
                        break;
                    default:
                        hotChocCount = 0;
                        capaCount = 0;
                        break;
                }
            }
            barChart.Series["Sale"].Points.AddXY("Capa", capaCount);
            barChart.Series["Sale"].Points.AddXY("Hot Choclate", hotChocCount);
            this.barChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.barChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }
    }
}
