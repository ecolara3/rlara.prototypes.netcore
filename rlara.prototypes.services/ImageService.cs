using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;

namespace rlara.prototypes.services
{
    public class ImageService:IImageService
    {
        public ConcurrentBag<ImageDomainModel> GetImagesByCategoryId(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public ConcurrentBag<ImageDomainModel> GetImagesByProductId(int productId)
        {
            throw new System.NotImplementedException();
        }

        public ImageDomainModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public ImageDomainModel Create(ImageDomainModel image)
        {
            throw new System.NotImplementedException();
        }

        public ImageDomainModel Update(ImageDomainModel image)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(ImageDomainModel image)
        {
            throw new System.NotImplementedException();
        }
    }
}