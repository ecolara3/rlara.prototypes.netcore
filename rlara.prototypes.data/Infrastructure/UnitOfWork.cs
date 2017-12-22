using System;
using rlara.prototypes.data.Repositories;

namespace rlara.prototypes.data.Infrastructure
{
    public class UnitOfWork:IDisposable,IUnitOfWork
    {
        private readonly StoreDBContext _storeDbContext;
        private ImageRepository _imageRepository;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        public UnitOfWork(StoreDBContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public ImageRepository ImageRepository => _imageRepository = _imageRepository ?? new ImageRepository(_storeDbContext);

        public ProductRepository ProductRepository => _productRepository = _productRepository ?? new ProductRepository(_storeDbContext);

        public CategoryRepository CategoryRepository => _categoryRepository = _categoryRepository ?? new CategoryRepository(_storeDbContext);

        public void Save()
        {
            _storeDbContext.SaveChanges();
        }
        
        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _storeDbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}