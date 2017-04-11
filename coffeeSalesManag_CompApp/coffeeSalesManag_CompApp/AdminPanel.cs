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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnAdminPanel_Coffee_Click(object sender, EventArgs e)
        {
            manageCoffeesForm mngCofFrm = new manageCoffeesForm();
            mngCofFrm.Show();
        }

        private void btnAdminPanel_Customer_Click(object sender, EventArgs e)
        {
            ManageCustomerForm custFrm = new ManageCustomerForm();
            custFrm.Show();
        }

        private void btnAdminPanel_Employees_Click(object sender, EventArgs e)
        {
            manageEmployees empFrm = new manageEmployees();
            empFrm.Show();
        }

        private void btnAdminPanel_Sales_Click(object sender, EventArgs e)
        {
            manageSalesForm saleFrm = new manageSalesForm();
            saleFrm.Show();
        }
    }
}
