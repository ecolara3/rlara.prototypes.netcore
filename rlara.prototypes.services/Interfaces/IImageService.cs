using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IImageService
    {
        ImageDomainModel GetImageByCategoryId(int categoryId);
        ImageDomainModel GetImageByProductId(int productId);
        ConcurrentBag<ImageDomainModel> GetImagesByProductId(int productId);
        ImageDomainModel Get(int imageId);
        ImageDomainModel Create(ImageDomainModel imageDomainModel);
        ImageDomainModel Update(ImageDomainModel imageDomainModel);
        bool Delete(ImageDomainModel imageDomainModel);
    }
}