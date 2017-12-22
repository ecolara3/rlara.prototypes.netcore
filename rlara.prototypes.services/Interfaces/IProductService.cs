using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IProductService
    {
        ConcurrentBag<ProductDomainModel> GetProductsByCategory(int categoryId);
        ProductDomainModel Get(int id);
        ProductDomainModel Create(ProductDomainModel image);
        ProductDomainModel Update(ProductDomainModel image);
        bool Delete(ProductDomainModel image);
    }
}