using UOWAndGenericRepoýsitory.Data;
using Microsoft.EntityFrameworkCore;
using UOWAndGenericRepoýsitory.Business;
using UOWAndGenericRepoýsitory.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DesignPatterns;trusted_connection=true"));

        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IProductService, ProductService>();
        
        


        var app = builder.Build();


        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var productService = services.GetRequiredService<IProductService>();

            // Now, you can use productService
            Product product = new Product
            {
                Name = "Test",
                Price = 10
            };
            
            productService.Add(product);
        }

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }


}