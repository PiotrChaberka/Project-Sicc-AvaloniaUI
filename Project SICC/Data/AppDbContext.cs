using Microsoft.EntityFrameworkCore;

namespace Project_SICC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }  // keep this for your code usage

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=clientdb;Username=postgres;Password=1215");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Keep Clients table excluded from future migrations since it already exists
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Clients");
                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", true);
            });

            modelBuilder.Entity<Contractor>().ToTable("Contractors");
            modelBuilder.Entity<Contract>().ToTable("Contracts");
            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<Contract>()
                .HasOne(c => c.Contractor)
                .WithMany(ct => ct.Contracts)
                .HasForeignKey(c => c.ContractorID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}