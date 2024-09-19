using JWT_ProductManager.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_ProductManager.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

}
