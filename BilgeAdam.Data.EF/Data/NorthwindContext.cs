using BilgeAdam.Data.EF.Entities;
using System.Data.Entity;

namespace BilgeAdam.Data.EF.Data
{
    internal class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("CnnStr")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}