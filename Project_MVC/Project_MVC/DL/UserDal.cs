using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project_MVC.DL
{
    public class UserDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Customers");
            modelBuilder.Entity<Manager>().ToTable("Managers");
        }
        public DbSet<User> Users { get; set; }
    }
}