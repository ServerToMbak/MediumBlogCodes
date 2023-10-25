using AutoMapper_DTO.Model;
using Microsoft.EntityFrameworkCore;

namespace AutoMapper_DTO.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Post> posts { get; set; } 
        DbSet<Comment> Comments { get; set; }
    }
    
}
