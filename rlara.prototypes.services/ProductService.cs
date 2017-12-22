using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;

namespace rlara.prototypes.services
{
    public class ProductService:IProductService
    {
        public ConcurrentBag<ProductDomainModel> GetProductsByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public ProductDomainModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProductDomainModel Create(ProductDomainModel image)
        {
            throw new System.NotImplementedException();
        }

        public ProductDomainModel Update(ProductDomainModel image)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(ProductDomainModel image)
        {
            throw new System.NotImplementedException();
        }
    }
}