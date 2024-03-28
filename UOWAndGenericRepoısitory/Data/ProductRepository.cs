using UOWAndGenericRepoısitory.Data;
using UOWAndGenericRepoısitory.Entities;

namespace UOWAndGenericRepoısitory.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
