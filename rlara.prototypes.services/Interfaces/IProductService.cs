using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IProductService
    {
        ConcurrentBag<Product> GetProductsByCategory(int categoryId);
        Product Get(int id);
        Product Create(Product image);
        Product Update(Product image);
        bool Delete(Product image);
    }
}