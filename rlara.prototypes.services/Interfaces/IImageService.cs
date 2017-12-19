using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IImageService
    {
        ConcurrentBag<Image> GetImagesByCategoryId(int categoryId);
        ConcurrentBag<Image> GetImagesByProductId(int productId);
        Image Get(int id);
        Image Create(Image image);
        Image Update(Image image);
        bool Delete(Image image);
    }
}