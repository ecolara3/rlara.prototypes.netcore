using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;
using rlara.prototypes.data.Interfaces;

namespace rlara.prototypes.data.Repositories
{
    public class ImageRepository:BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(StoreDBContext storeDbContext) : base(storeDbContext)
        {
        }
    }
}