using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PTCar
{
    internal class ASMDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB ;Database = PTCar;Trusted_Connection = True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<Inventory> inventories { get; set; }
        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductID); // Xác định khóa chính
            modelBuilder.Entity<Supplier>()
                .HasKey(p => p.SupplierID);
            modelBuilder.Entity<Order>()
                .HasKey(p => p.OrderID);
            modelBuilder.Entity<Invoice>()
               .HasKey(p => p.InvoiceID);
            modelBuilder.Entity<Staff>()
               .HasKey(p => p.StaffID);
            modelBuilder.Entity<Customer>()
               .HasKey(p => p.CustomerID);
            modelBuilder.Entity<Inventory>()
               .HasKey(p => p.InventoryID);
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(50);
            });
        }
    }
}
