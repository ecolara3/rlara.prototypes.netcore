using System.Collections.Concurrent;
using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;

namespace rlara.prototypes.data.Interfaces
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        ConcurrentBag<Product> GetProductsByCategoryId(int id);
    }
}