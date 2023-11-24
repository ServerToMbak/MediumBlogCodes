using System.ComponentModel.DataAnnotations;

namespace LINQ.Entites
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } // Every category can have more than one Product
    }
}
