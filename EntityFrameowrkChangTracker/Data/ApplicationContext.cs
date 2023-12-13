using Microsoft.EntityFrameworkCore;

namespace EntityFrameowrkChangTracker.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=EFChangeTracker ;trusted_connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
