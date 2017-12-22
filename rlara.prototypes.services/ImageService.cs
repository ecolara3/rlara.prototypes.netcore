using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;
using rlara.prototypes.services.Mappers;

namespace rlara.prototypes.services
{
    public class ImageService:IImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public ImageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        
        public ImageDomainModel GetImageByCategoryId(int categoryId)
        {
            Image image = _unitOfWork.ImageRepository.GetImageByCategoryId(categoryId);
            ImageDomainModel imageDomainModel = _mapper.ImageEntityToDomainModel(image);

            return imageDomainModel;
        }

        public ImageDomainModel GetImageByProductId(int productId)
        {
            Image image = _unitOfWork.ImageRepository.GetImageByProductId(productId);
            ImageDomainModel imageDomainModel = _mapper.ImageEntityToDomainModel(image);

            return imageDomainModel;
        }

        public ConcurrentBag<ImageDomainModel> GetImagesByProductId(int productId)
        {
            ConcurrentBag<Image> images = new ConcurrentBag<Image>(_unitOfWork.ImageRepository.GetImagesByProductId(productId).ToList());

            ConcurrentBag<ImageDomainModel> imageDomainModel = new ConcurrentBag<ImageDomainModel>();
            
            Parallel.ForEach(images, image =>
            {
                imageDomainModel.Add(_mapper.ImageEntityToDomainModel(image));
            });
            

            return imageDomainModel;
        }

        public ImageDomainModel Get(int imageId)
        {
            Image image = _unitOfWork.ImageRepository.GetById(imageId);
            ImageDomainModel imageDomainModel = _mapper.ImageEntityToDomainModel(image);

            return imageDomainModel;
        }

        public ImageDomainModel Create(ImageDomainModel imageDomainModel)
        {
            Image image = _mapper.ImageDomainModelToEntity(imageDomainModel);
            _unitOfWork.ImageRepository.Create(image);
            _unitOfWork.Save();

            imageDomainModel = _mapper.ImageEntityToDomainModel(image);

            return imageDomainModel;
        }

        public ImageDomainModel Update(ImageDomainModel imageDomainModel)
        {
            Image image = _mapper.ImageDomainModelToEntity(imageDomainModel);
            _unitOfWork.ImageRepository.Update(image);
            _unitOfWork.Save();
            
            imageDomainModel = _mapper.ImageEntityToDomainModel(image);

            return imageDomainModel;
        }

        public bool Delete(ImageDomainModel imageDomainModel)
        {
            try
            {
                Image imageEntity = _mapper.ImageDomainModelToEntity(imageDomainModel);
                _unitOfWork.ImageRepository.Delete(imageEntity);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}