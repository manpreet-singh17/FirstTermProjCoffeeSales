using coffeeSalesManag_CompApp.Models.CoffeeManagement;
using System.Data.Entity;


namespace coffeeSalesManag_CompApp.Models
{
    public class DbCoffeeContext : DbContext
    {
        public DbSet<Coffee> Coffee { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employees> employees { get; set; }
    }
}
