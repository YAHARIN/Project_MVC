using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Project_MVC.ModelView;

namespace Project_MVC.DL
{
    public class UserDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Customers");
            modelBuilder.Entity<Manager>().ToTable("Managers");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Purchase>().ToTable("Purchase");
        }
        public DbSet<User> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
    }
}