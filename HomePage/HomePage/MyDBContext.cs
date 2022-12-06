namespace HomePage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HomePage.Models;
    using Microsoft.EntityFrameworkCore;

    public class MyDBContext: DbContext
    {
        public MyDBContext(): base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            //optionsBuilder.UseSqlServer("Data Source =DESKTOP-UDAJ3HN\\SQLEXPRESS;Initial Catalog= Test_base;Integrated Security =True;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Data Source =TEHARMEN\\SQLEXPRESS01;Initial Catalog= Test_base;Integrated Security =True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // var CustomerINFO = modelBuilder.Entity<CustomerInfo>();

            // CustomerINFO.HasKey(m => m.CustomerID);
            // var Customer = modelBuilder.Entity<Customer>();

            // var Login = modelBuilder.Entity<LoginPortal>();

            // Customer.HasKey(m => m.customerID);

            // Login.HasKey(m => m.userID);
        }
    }
}
