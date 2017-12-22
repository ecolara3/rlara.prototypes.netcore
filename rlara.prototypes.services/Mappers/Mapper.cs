using System;
using System.Collections.Concurrent;
using rlara.prototypes.data.Entities;
using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Mappers
{
    public interface IMapper
    {
        Image ImageDomainModelToEntity(ImageDomainModel imageDomainModel, int productId = 0, int categoryId = 0);
        ImageDomainModel ImageEntityToDomainModel(Image imageEntity);
        Product ProductDomainModelToEntity(ProductDomainModel productDomainModel, int categoryId = 0);
        ProductDomainModel ProductEntityToDomainModel(Product productEntity, ConcurrentBag<Image> imageEntities = null);
        Category CategoryDomainModelToEntity(CategoryDomainModel categoryDomainModel);
        CategoryDomainModel CategoryEntityToDomainModel(Category categoryEntity, ConcurrentBag<Product> productEntities = null, Image image = null);
    }

    public class Mapper:IMapper
    {
        public Mapper()
        {
            
        }

        public Image ImageDomainModelToEntity(ImageDomainModel imageDomainModel, int productId = 0,  int categoryId = 0)
        {
            Image image = new Image
            {
                Id = imageDomainModel.Id,
                Uri = imageDomainModel.Uri,
                CreationDate = imageDomainModel.CreationDate
            };

            if (productId != 0)
            {
                image.ProductId = productId;
            }

            if (categoryId != 0)
            {
                image.CategoryId = categoryId;
            }

            return image;
        }

        public ImageDomainModel ImageEntityToDomainModel(Image imageEntity)
        {
            ImageDomainModel imageDM = new ImageDomainModel
            {
                Id = imageEntity.Id,
                CreationDate = imageEntity.CreationDate,
                Uri = imageEntity.Uri
                
            };

            return imageDM;
        }

        public Product ProductDomainModelToEntity(ProductDomainModel productDomainModel, int categoryId = 0)
        {
            Product product = new Product
            {
                Id = productDomainModel.Id,
                Name = productDomainModel.Name,
                CreationDate = productDomainModel.CreationDate
            };

            if (categoryId != 0)
            {
                product.CategoryId = categoryId;
            }

            return product;
        }

        public ProductDomainModel ProductEntityToDomainModel(Product productEntity, ConcurrentBag<Image> imageEntities = null)
        {
            ProductDomainModel productDM = new ProductDomainModel
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                CreationDate = productEntity.CreationDate
            };

            if (imageEntities != null)
            {
                foreach (var imageEntity in imageEntities)
                {
                    var imageDomainModel = ImageEntityToDomainModel(imageEntity);
                    productDM.Images.Add(imageDomainModel);
                }

                
            }

            return productDM;

        }

        public Category CategoryDomainModelToEntity(CategoryDomainModel categoryDomainModel)
        {
            Category categoryEntity = new Category
            {
                Id = categoryDomainModel.Id,
                Name = categoryDomainModel.Name,
                Descritpion = categoryDomainModel.Descritpion,
                CreationDate = categoryDomainModel.CreationDate
            };

            return categoryEntity;
        }

        public CategoryDomainModel CategoryEntityToDomainModel(Category categoryEntity, ConcurrentBag<Product> productEntities = null, Image image = null)
        {
            CategoryDomainModel categoryDomainModel = new CategoryDomainModel
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name,
                Descritpion = categoryEntity.Descritpion,
                CreationDate = categoryEntity.CreationDate,
                Image = ImageEntityToDomainModel(image)
                
            };
            
            foreach (var productEntity in productEntities)
            {
                var productDomainModel = ProductEntityToDomainModel(productEntity);
                
                categoryDomainModel.Products.Add(productDomainModel);
            }

            return categoryDomainModel;
        }
    }
}