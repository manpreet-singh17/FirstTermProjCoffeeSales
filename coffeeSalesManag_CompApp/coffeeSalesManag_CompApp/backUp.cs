using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using coffeeSalesManag_CompApp.Models;
using System.Windows.Forms;

namespace coffeeSalesManag_CompApp
{
    class backUp
    {
        DbCoffeeContext _db = new DbCoffeeContext();
        
        public void CreateConnection()
        {
            string database = _db.Database.Connection.Database;
            MessageBox.Show(database);
            

        }
    }
}
