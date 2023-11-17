using Microsoft.EntityFrameworkCore;
namespace Crm.DataAccess;

public sealed class CrmDbContext : DbContext
{
    public DbSet<Client> Clients {get; set;}
    public DbSet<Order> Orders {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        optionsBuilder.UseNpgsql(DatabaseHelper.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }

}
