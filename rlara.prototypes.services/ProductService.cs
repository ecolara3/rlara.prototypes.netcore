using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using rlara.prototypes.data.Entities;
using rlara.prototypes.data.Infrastructure;
using rlara.prototypes.services.DomainModels;
using rlara.prototypes.services.Interfaces;
using rlara.prototypes.services.Mappers;

namespace rlara.prototypes.services
{
    public class ProductService:IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ConcurrentBag<ProductDomainModel> GetProductsByCategory(int categoryId)
        {
            ConcurrentBag<Product> products = _unitOfWork.ProductRepository.GetProductsByCategoryId(categoryId);
            ConcurrentBag<ProductDomainModel> productDomainModels = new ConcurrentBag<ProductDomainModel>();

            foreach (var product in products)
            {
                ProductDomainModel productDomainModel = _mapper.ProductEntityToDomainModel(product);
                productDomainModels.Add(productDomainModel);
            }

            return productDomainModels;
        }

        public ProductDomainModel Get(int id)
        {
            Product product = _unitOfWork.ProductRepository.GetById(id);
            ProductDomainModel productDomainModel = _mapper.ProductEntityToDomainModel(product);
            
            return productDomainModel;
        }

        public ProductDomainModel Create(ProductDomainModel productDomainModel)
        {
            Product product = _mapper.ProductDomainModelToEntity(productDomainModel);
            _unitOfWork.ProductRepository.Create(product);
            _unitOfWork.Save();

            productDomainModel = _mapper.ProductEntityToDomainModel(product);

            return productDomainModel;
        }

        public ProductDomainModel Update(ProductDomainModel productDomainModel)
        {
            Product product = _mapper.ProductDomainModelToEntity(productDomainModel);
            _unitOfWork.ProductRepository.Update(product);
            _unitOfWork.Save();
            
            productDomainModel = _mapper.ProductEntityToDomainModel(product);

            return productDomainModel;
        }

        public bool Delete(ProductDomainModel productDomainModel)
        {
            try
            {
                Product productEntity = _mapper.ProductDomainModelToEntity(productDomainModel);
                _unitOfWork.ProductRepository.Delete(productEntity);
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