using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging.Abstractions;
using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;
using rlara.prototypes.services.Mappers;

namespace rlara.prototypes.services
{
    
    public class CategoryService:ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CategoryDomainModel Get(int id)
        {
            Category categoryEntity =  _unitOfWork.CategoryRepository.GetById(id);
            Image imageEntity = _unitOfWork.ImageRepository.GetAll().SingleOrDefault(s => s.CategoryId == id);
            ConcurrentBag<Product> productEntities = new ConcurrentBag<Product>(_unitOfWork.ProductRepository.GetAll().Where(s => s.CategoryId == id));

            CategoryDomainModel categoryDomainModel = _mapper.CategoryEntityToDomainModel(categoryEntity, productEntities, imageEntity);

            return categoryDomainModel;
        }

        public CategoryDomainModel Create(CategoryDomainModel categoryDomainModel)
        {

            Category categoryEntity = _mapper.CategoryDomainModelToEntity(categoryDomainModel);
            _unitOfWork.CategoryRepository.Create(categoryEntity);
            _unitOfWork.Save();

            categoryDomainModel = _mapper.CategoryEntityToDomainModel(categoryEntity);

            return categoryDomainModel;
        }

        public CategoryDomainModel Update(CategoryDomainModel categoryDomainModel)
        {
            Category categoryEntity = _mapper.CategoryDomainModelToEntity(categoryDomainModel);
            _unitOfWork.CategoryRepository.Update(categoryEntity);
            _unitOfWork.Save();
            
            categoryDomainModel = _mapper.CategoryEntityToDomainModel(categoryEntity);

            return categoryDomainModel;
            
        }

        public bool Delete(CategoryDomainModel category)
        {
            try
            {
                Category categoryEntity = _mapper.CategoryDomainModelToEntity(category);
                _unitOfWork.CategoryRepository.Delete(categoryEntity);
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