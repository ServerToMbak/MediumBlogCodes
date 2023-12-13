using Bogus;

namespace EntityFrameowrkChangTracker.Data;

public static class Seed
{

    public static void SeedProducts()
    {
        ApplicationContext context = new();
        context.Database.EnsureCreated();
        if(!context.Products.Any())
        {

            var products = new Faker<Product>("tr")
                .RuleFor(i => i.Name, i => i.Random.Word())
                .RuleFor(i => i.Id, i => Guid.NewGuid())
                .RuleFor(i => i.Price, i => i.Random.Int())
                .Generate(50);
            context.AddRange(products); 
        }
        context.SaveChanges();
    }
}
