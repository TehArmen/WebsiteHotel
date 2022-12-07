﻿namespace HomePage
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

       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-UDAJ3HN\\SQLEXPRESS;Initial Catalog= Test_base;Integrated Security =True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source =TEHARMEN\\SQLEXPRESS01;Initial Catalog= Test_base;Integrated Security =True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var CustomerINFO = modelBuilder.Entity<CustomerInfo>();
            CustomerINFO.HasKey(m => m.CustomerID);

            var Login = modelBuilder.Entity<LoginPortal>();
          
            Login.HasKey(m => m.userID);

            var Rooms = modelBuilder.Entity<HotelRooms>();

            Rooms.HasKey(m => m.roomID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
