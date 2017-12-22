using rlara.prototypes.data.Repositories;

namespace rlara.prototypes.data.Infrastructure
{
    public interface IUnitOfWork
    {
        ImageRepository ImageRepository{ get; }
        ProductRepository ProductRepository { get; }
        CategoryRepository CategoryRepository { get; }
        void Save();
    }
}