using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;

namespace rlara.prototypes.data.Repositories
{
    public interface IImageRepository:IBaseRepository<Image>
    {
        
    }

    public class ImageRepository:BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(StoreDBContext storeDbContext) : base(storeDbContext)
        {
        }
    }
}