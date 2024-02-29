using Microsoft.EntityFrameworkCore;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Data
{
    internal class SalesContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales   { get; set; }
        public DbSet <Store> Stores{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YASSMINE\SQLEXPRESS;Initial Catalog=Sales;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(e => e.Name).HasMaxLength(100).IsUnicode(true);

            modelBuilder.Entity<Customer>().Property(e => e.Name).HasMaxLength(100).IsUnicode(true);
        
            modelBuilder.Entity<Customer>().Property(e=>e.Email).HasMaxLength(80).IsUnicode(false);
            modelBuilder.Entity<Store>().Property(e => e.Name).HasMaxLength(80).IsUnicode(true);




            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales)
                .WithMany(e => e.Products);

            modelBuilder.Entity<Sale>()
                .HasOne(e => e.Customer)
                .WithMany(e => e.Sales);
            modelBuilder.Entity<Sale>()
                .HasOne(e => e.Store)
                .WithMany(e => e.Sales);

            modelBuilder.Entity<Product>().Property(e => e.Descreption).HasMaxLength(250).IsUnicode(true).HasDefaultValue("N0 description");

            modelBuilder.Entity<Sale>().Property(e => e.Date).HasDefaultValueSql("GETDATE()");





                
                





        }







    }
}
