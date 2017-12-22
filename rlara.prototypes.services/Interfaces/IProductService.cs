using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IProductService
    {
        ConcurrentBag<ProductDomainModel> GetProductsByCategory(int productId);
        ProductDomainModel Get(int productId);
        ProductDomainModel Create(ProductDomainModel productDomainModel);
        ProductDomainModel Update(ProductDomainModel productDomainModel);
        bool Delete(ProductDomainModel productDomainModel);
    }
}