using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DTO.Context
{
    public class EnzDBContext : DbContext
    {
        public EnzDBContext()
        {
            Database.EnsureCreated();
            
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProducedOrder> ProducedOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EnezcamERP;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
