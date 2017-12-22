using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface IImageService
    {
        ConcurrentBag<ImageDomainModel> GetImagesByCategoryId(int imageId);
        ConcurrentBag<ImageDomainModel> GetImagesByProductId(int imageId);
        ImageDomainModel Get(int imageId);
        ImageDomainModel Create(ImageDomainModel imageDomainModel);
        ImageDomainModel Update(ImageDomainModel imageDomainModel);
        bool Delete(ImageDomainModel imageDomainModel);
    }
}