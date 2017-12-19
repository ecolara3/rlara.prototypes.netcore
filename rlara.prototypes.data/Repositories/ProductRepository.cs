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
    }
}