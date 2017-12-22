using System;
using System.Linq;
using rlara.prototypes.data.Interfaces;

namespace rlara.prototypes.data.Infrastructure
{

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly StoreDBContext _storeDbContext;


        protected BaseRepository(StoreDBContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _storeDbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _storeDbContext.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            _storeDbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _storeDbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _storeDbContext.Remove(entity);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _storeDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}