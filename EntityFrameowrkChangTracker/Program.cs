using EntityFrameowrkChangTracker;
using EntityFrameowrkChangTracker.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Seed.SeedProducts(); // fake data ekleme bogus paketini kullanarak

ApplicationContext context = new();


context.Products.ToList();
var allproducts = context.ChangeTracker.Entries();



Product product = new();
var EntitystateDetached = context.Entry(product).State;
Console.WriteLine(EntitystateDetached);                     // Detached Durumu

var product1 = context.Products.FirstOrDefault(p => p.Name == "ürün"); 
var Entitystate = context.Entry(product1).State;            // UnChanged 
Console.WriteLine(Entitystate);

product1.Name = "isim güncellendi state Modified olacak";
var stateUpdated = context.Entry(product1).State;

Console.WriteLine(stateUpdated);

context.Remove(product1);
var stateDeleted = context.Entry(product1).State; // ChangeTracker Delete durumu

Console.WriteLine(stateDeleted);

context.SaveChanges();  // Deðiþikliklerin kaydedilmesi

context.Products.AsNoTracking().ToList(); // veriler takip edilmez - ChangeTracker Disable durumu




var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
