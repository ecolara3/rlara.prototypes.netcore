using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;

namespace rlara.prototypes.data.Repositories
{
    public interface ICategoryRepository:IBaseRepository<Category>
    {
        
    }

    public class CategoryRepository:BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(StoreDBContext storeDbContext) : base(storeDbContext)
        {
        }
    }
}