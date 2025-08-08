using Microsoft.EntityFrameworkCore;

namespace Project_SICC.Data;

public class AppDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=clientdb;Username=postgres;Password=1215");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().ToTable("Clients");
    }
    
}
