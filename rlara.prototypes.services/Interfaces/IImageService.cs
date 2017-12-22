using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IImageService
    {
        ConcurrentBag<ImageDomainModel> GetImagesByCategoryId(int categoryId);
        ConcurrentBag<ImageDomainModel> GetImagesByProductId(int productId);
        ImageDomainModel Get(int id);
        ImageDomainModel Create(ImageDomainModel image);
        ImageDomainModel Update(ImageDomainModel image);
        bool Delete(ImageDomainModel image);
    }
}