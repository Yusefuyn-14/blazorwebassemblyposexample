using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using YGate.Shared.Concretes;

namespace YGate.Postgresql.Entityframework
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=myDataBase;Pooling=true;Connection Lifetime=0;");
            }
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<IndividualCustomer> ICustomer { get; set; }
        public DbSet<CorporateCustomer> CCustomer { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<PayType> PayTypes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
