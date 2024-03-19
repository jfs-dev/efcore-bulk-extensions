using efcore_bulk_extensions.Models;
using Microsoft.EntityFrameworkCore;

namespace efcore_bulk_extensions.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Data/SQLite.db");
    }
}