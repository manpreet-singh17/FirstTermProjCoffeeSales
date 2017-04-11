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
    public partial class manageEmployees : Form
    {
        public manageEmployees()
        {
            InitializeComponent();
            fillGenderComboBox();//method call to fill combo box of gender.
            fillDataGridView();//method call to fill data grid view.
            
        }
        /********************CRUD OPERATIONS******************/

        //ADD OPERATION.
        private void btnMngEmp_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DbCoffeeContext _db = new DbCoffeeContext();
                Employees empObj = new Employees();

                empObj.UserName = txtMngEmp_userName.Text.Trim();
                empObj.Password = txtMngEmp_Password.Text.Trim();
                empObj.Name = txtMngEmp_Name.Text.Trim();
                if (txtMngEmp_Age.Text.Trim() == string.Empty)
                {
                    throw new InvalidCastException("Please enter employee age.");
                }
                empObj.Age = Convert.ToInt32(txtMngEmp_Age.Text.Trim());

                empObj.Gender = cbMngEmp_Gender.Text.Trim();

                if (txtMngEmp_MobNum.Text.Trim() == string.Empty)
                {
                    throw new InvalidCastException("Please enter employee Mobile Number.");
                }
                empObj.MobileNumber = Convert.ToInt32(txtMngEmp_MobNum.Text.Trim());

                empObj.Address = txtMngEmp_Address.Text.Trim();
                empObj.DateTime = DateTime.Now;

                _db.employees.Add(empObj);
                _db.SaveChanges();
                MessageBox.Show("Employee added.");
                fillDataGridView();//method call to fill data grid view
                emptyAllControls();//method call to empty all controls.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DELETE OPERATION.
        private void btnMngEmp_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int empID = Convert.ToInt32(txtMngEmp_ID.Text);

                    DbCoffeeContext _db = new DbCoffeeContext();
                    var empObj = _db.employees
                        .Where(x => x.ID == empID).FirstOrDefault();
                    _db.employees.Remove(empObj);
                    _db.SaveChanges();
                    fillDataGridView();//filling data grid view.
                    emptyAllControls();//empty all controls.
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        //UPDATE OPERATION.
        private void btnMngEmp_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int empID = Convert.ToInt32(txtMngEmp_ID.Text);

                DbCoffeeContext _db = new DbCoffeeContext();
                var empObj = _db.employees
                    .Where(x => x.ID == empID).FirstOrDefault();
                empObj.ID = empID;
                empObj.Name = txtMngEmp_Name.Text.Trim();
                if (txtMngEmp_Age.Text.Trim() == string.Empty)
                {
                    throw new InvalidCastException("Please enter employee age.");
                }
                empObj.Age = Convert.ToInt32(txtMngEmp_Age.Text.Trim());

                empObj.Gender = cbMngEmp_Gender.Text.Trim();

                if (txtMngEmp_MobNum.Text.Trim() == string.Empty)
                {
                    throw new InvalidCastException("Please enter employee Mobile Number.");
                }
                empObj.MobileNumber = Convert.ToInt32(txtMngEmp_MobNum.Text.Trim());
                empObj.Address = txtMngEmp_Address.Text.Trim();
                _db.Entry(empObj).Property(x => x.Name).IsModified = true;
                _db.Entry(empObj).Property(x => x.Age).IsModified = true;
                _db.Entry(empObj).Property(x => x.Gender).IsModified = true;
                _db.Entry(empObj).Property(x => x.MobileNumber).IsModified = true;
                _db.Entry(empObj).Property(x => x.Address).IsModified = true;
                _db.SaveChanges();
                MessageBox.Show("Employee updated.");
                fillDataGridView();
                emptyAllControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /************************EVENTS******************/
        //EVENT TO CONTROL USERNAME INPUT.
        private void txtMngEmp_userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsDigit(ch) && ch != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only Letters and Digits");
            }
        }

        //EVENT TO CONTROL INPUT OF PASWWROD FIELD.
        private void txtMngEmp_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("Your caps lock is on.");
            }
            if (!char.IsDigit(ch) && !char.IsLetter(ch) && ch != ((char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only  Digits");
            }
        }

        //EVENT TO CONTROL INPUT OF NAME FIELD.
        private void txtMngEmp_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != (char)Keys.Back && ch != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letter.");
            }    
        }

        //EVENT TO HANDLE INPUT OF AGE.
        private void txtMngEmp_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != ((char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only  Digits");
            }
        }

        //EVENT TO CONTROL INPUT OF GENDER FIELD.
        private void txtMngEmp_Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) || char.IsLetter(ch) || ch == (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("You can't write here.");
            }
        }

        //EVENT TO CONTROL INPUT OF MOBILE NUMBER FIELD.
        private void txtMngEmp_MobNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != ((char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only  Digits");
            }
        }

        //EVENT TO CONTROL INPUT OF ADDRESS FIELD.
        private void txtMngEmp_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsDigit(ch) && ch != (char)Keys.Back && ch != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters, digits and space.");
            }
        }

        //EVENT TO GET ROW FROM DATA GRID VIEW.
        private void dgvMngEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvMngEmp.CurrentRow;
                int recId = Convert.ToInt32(row.Cells[0].Value);

                DbCoffeeContext _db = new DbCoffeeContext();
                var empObj = _db.employees.Where(x => x.ID == recId).FirstOrDefault();

                txtMngEmp_ID.Text = empObj.ID.ToString();
                txtMngEmp_userName.Text = empObj.UserName;
                txtMngEmp_Password.Text = empObj.Password;
                txtMngEmp_Name.Text = empObj.Name;
                txtMngEmp_Age.Text = empObj.Age.ToString();
                cbMngEmp_Gender.Text = empObj.Gender;
                txtMngEmp_MobNum.Text = empObj.MobileNumber.ToString();
                txtMngEmp_Address.Text = empObj.Address;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*****************METHODS*************/
        void fillGenderComboBox()
        {
            cbMngEmp_Gender.Items.Add("Male");
            cbMngEmp_Gender.Items.Add("Female");
        }

        //METHOD TO FILL DATAGRID VIEW.
        void fillDataGridView()
        {
            DbCoffeeContext _db = new DbCoffeeContext();
            dgvMngEmp.DataSource = _db.employees.ToList();
        } 

        //  method to empty all controls.
        void emptyAllControls()
        {
            txtMngEmp_ID.Text = string.Empty;
            txtMngEmp_userName.Text = string.Empty;
            txtMngEmp_Password.Text = string.Empty;
            txtMngEmp_Name.Text = string.Empty;
            txtMngEmp_Age.Text = string.Empty;
            cbMngEmp_Gender.Text = string.Empty;
            txtMngEmp_MobNum.Text = string.Empty;
            txtMngEmp_Address.Text = string.Empty;
        }
    }
}
