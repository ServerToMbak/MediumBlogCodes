using Bogus;
using LINQ.Entites;
using Microsoft.AspNetCore.Builder;

namespace LINQ.Data;

public static class SeedData
{
    public static  void AddFakeDataWithBogus(IApplicationBuilder applicationBuilder)
    {

        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();
            if(!context.Categories.Any())
            {

                    var guids = Enumerable.Range(0, 150).Select(i => Guid.NewGuid()).ToList();
                    int counter = 0;
                    var category = new Faker<Category>("tr")
                        .RuleFor(i => i.Id, i => guids[counter++])
                        .RuleFor(i => i.Name, i => i.Lorem.Word())
                    .Generate(150);

                context.Categories.AddRange(category);

                    var products = new Faker<Product>("tr")
                             .RuleFor(i => i.Id, i => Guid.NewGuid())
                              .RuleFor(i => i.Name, i => i.Lorem.Word())
                             .RuleFor(i => i.CategoryId, i => i.PickRandom(guids))
                    .Generate(1000);
                context.Products.AddRange(products);

                context.SaveChanges();
            }
            

        }
    }
}