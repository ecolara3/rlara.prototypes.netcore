using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;

namespace rlara.prototypes.data.Repositories
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        
    }

    public class ProductRepository:BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreDBContext storeDbContext) : base(storeDbContext)
        {
        }
    }
}