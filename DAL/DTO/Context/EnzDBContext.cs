using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DTO.Context
{
    public class EnzDBContext : DbContext
    {
        public EnzDBContext()
        {
            this.ChangeTracker.LazyLoadingEnabled = true;
            Database.EnsureCreated();
        }

        private static EnzDBContext? _context;

        public static EnzDBContext GetInstance
        {
            get
            {
                _context ??= new EnzDBContext();
                return _context;
            }
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProducedOrder> ProducedOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PriceHistory> PricesHistory { get; set; }
        public DbSet<MonthlyOutgoing> MonthlyOutgoings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EnezcamERP;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>().HavePrecision(18, 3);
        }
    }
}
