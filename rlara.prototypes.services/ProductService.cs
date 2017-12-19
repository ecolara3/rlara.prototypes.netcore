using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;

namespace rlara.prototypes.services
{
    public class ProductService:IProductService
    {
        public ConcurrentBag<Product> GetProductsByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Create(Product image)
        {
            throw new System.NotImplementedException();
        }

        public Product Update(Product image)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Product image)
        {
            throw new System.NotImplementedException();
        }
    }
}