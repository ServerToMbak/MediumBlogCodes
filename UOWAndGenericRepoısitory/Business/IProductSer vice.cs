using UOWAndGenericRepoısitory.Entities;

namespace UOWAndGenericRepoısitory.Business
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
    }
}
