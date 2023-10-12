using NorthwindFormsApp.Entities;
using System.Data.Entity;

namespace NorthwindFormsApp.Data
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext() : base("name=NorthwindConnection")
        {
            // Enable SQL logging
            //Database.Log = Console.Write;
        }

        // DbSets for commonly used tables
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Category entity
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryID);

            // Configure relationships
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOptional(p => p.Category)
                .HasForeignKey(p => p.CategoryID);

            // Configure Customer entity
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerID);

            // Configure relationships
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o.CustomerID);

            // Configure Employee entity
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeID);

            // Configure relationships
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithOptional(o => o.Employee)
                .HasForeignKey(o => o.EmployeeID);

            // Configure Order entity
            modelBuilder.Entity<Order>()
                .HasKey(o => o.OrderID);

            // Configure relationships
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerID);

            modelBuilder.Entity<Order>()
                .HasOptional(o => o.Employee)
                .WithMany(e => e.Orders)
                .HasForeignKey(o => o.EmployeeID);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithRequired(od => od.Order)
                .HasForeignKey(od => od.OrderID);

            // Configure OrderDetail entity
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderID, od.ProductID });

            // Configure relationships
            modelBuilder.Entity<OrderDetail>()
                .HasRequired(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID);

            // Configure Product entity
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductID);

            // Configure relationships
            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderDetails)
                .WithRequired(od => od.Product)
                .HasForeignKey(od => od.ProductID);

            modelBuilder.Entity<Product>()
                .HasOptional(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);

            modelBuilder.Entity<Product>()
                .HasOptional(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierID);

            // Configure Supplier entity
            modelBuilder.Entity<Supplier>()
                .HasKey(s => s.SupplierID);

            // Configure relationships
            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.Products)
                .WithOptional(p => p.Supplier)
                .HasForeignKey(p => p.SupplierID);

            base.OnModelCreating(modelBuilder);
        }
    }
}