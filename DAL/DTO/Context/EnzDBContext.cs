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

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync();
        }

        void AddTimestamps()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var now = DateTime.Now;

                if(entry.State == EntityState.Added)
                    ((BaseEntity)entry.Entity).CreatedAt = now;
                else
                    ((BaseEntity)entry.Entity).UpdatedAt = now;
            }
        }
    }
}
