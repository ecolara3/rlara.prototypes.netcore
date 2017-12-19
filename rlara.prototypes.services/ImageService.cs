using System.Collections.Concurrent;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;

namespace rlara.prototypes.services
{
    public class ImageService:IImageService
    {
        public ConcurrentBag<Image> GetImagesByCategoryId(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public ConcurrentBag<Image> GetImagesByProductId(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Image Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Image Create(Image image)
        {
            throw new System.NotImplementedException();
        }

        public Image Update(Image image)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Image image)
        {
            throw new System.NotImplementedException();
        }
    }
}