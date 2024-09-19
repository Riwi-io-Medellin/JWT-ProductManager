using Bogus;
using JWT_ProductManager.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_ProductManager.Seeders;
public class ProductSeeder
{
    public static void Seed(ModelBuilder modelBuilder, int amount)
    {
        var products = GenerateProducts(amount);
        modelBuilder.Entity<Product>().HasData(products);
    }

    private static IEnumerable<Product> GenerateProducts(int count)
    {
        var faker = new Faker<Product>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Cost, f => f.Random.Double(1, 1000));

        return faker.Generate(count);
    }

}
