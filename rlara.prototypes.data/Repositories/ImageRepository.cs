using System.Linq;
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

        public Image GetImageByCategoryId(int categoryId)
        {
            return _storeDbContext.Image.FirstOrDefault(s => s.CategoryId == categoryId);
        }

        public Image GetImageByProductId(int productId)
        {
            return _storeDbContext.Image.FirstOrDefault(s => s.ProductId == productId);
        }

        public IQueryable<Image> GetImagesByProductId(int productId)
        {
            return _storeDbContext.Image.Where(s => s.ProductId == productId);
        }
    }
}