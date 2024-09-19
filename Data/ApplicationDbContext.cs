using JWT_ProductManager.Models;
using JWT_ProductManager.Seeders;
using Microsoft.EntityFrameworkCore;

namespace JWT_ProductManager.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ProductSeeder.Seed(modelBuilder,1000);
    }

}
