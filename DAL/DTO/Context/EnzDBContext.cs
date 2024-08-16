using DAL.DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DTO.Context
{
    public class EnzDBContext : DbContext
    {
        public EnzDBContext()
        {
            this.ChangeTracker.LazyLoadingEnabled = true;
            //Database.EnsureCreated();
            //Database.Migrate();
        }

        private static EnzDBContext? _context;
        //public static EnzDBContext _context;

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
        public DbSet<Spec> Specs { get; set; }
        public DbSet<OrderDetailSpec> OrderDetailsSpecs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EnezcamERP;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceHistory>()
                .Property(e => e.LastCost)
                .HasPrecision(18, 2);

            modelBuilder.Entity<PriceHistory>()
                .Property(e => e.LastPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 2);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>().HavePrecision(18, 3);
        }
    }
}
