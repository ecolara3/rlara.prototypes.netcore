using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;
using rlara.prototypes.data.Interfaces;

namespace rlara.prototypes.data.Repositories
{

    public class CategoryRepository:BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(StoreDBContext storeDbContext) : base(storeDbContext)
        {
        }
    }
}