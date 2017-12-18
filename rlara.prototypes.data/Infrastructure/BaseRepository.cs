using System.Linq;

namespace rlara.prototypes.data.Infrastructure
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T GetById(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly StoreDBContext _storeDbContext;


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
    }
}