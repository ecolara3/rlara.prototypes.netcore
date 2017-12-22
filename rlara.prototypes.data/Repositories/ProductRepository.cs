using System.Collections.Concurrent;
using System.Linq;
using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;
using rlara.prototypes.data.Interfaces;

namespace rlara.prototypes.data.Repositories
{

    public class ProductRepository:BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreDBContext storeDbContext) : base(storeDbContext)
        {
        }

        public ConcurrentBag<Product> GetProductsByCategoryId(int id)
        {
            return new ConcurrentBag<Product>(_storeDbContext.Product.Where(s => s.CategoryId == id).ToList());
        }
    }
}