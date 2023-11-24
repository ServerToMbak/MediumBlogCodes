using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQ.Entites
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
    }
}
