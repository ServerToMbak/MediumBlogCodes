using UOWAndGenericRepoısitory.Data;
using UOWAndGenericRepoısitory.Entities;

namespace UOWAndGenericRepoısitory.Business
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Add(Product product)
        {
            _productRepository.Add(product);   
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }
    }
}
