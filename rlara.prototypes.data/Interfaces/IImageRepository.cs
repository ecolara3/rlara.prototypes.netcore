using System.Linq;
using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;

namespace rlara.prototypes.data.Interfaces
{
    public interface IImageRepository:IBaseRepository<Image>
    {
        Image GetImageByCategoryId(int categoryId);
        Image GetImageByProductId(int productId);
        IQueryable<Image> GetImagesByProductId(int productId);
    }
}