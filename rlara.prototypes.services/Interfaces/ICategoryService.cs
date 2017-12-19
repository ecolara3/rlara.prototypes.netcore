using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface ICategoryService
    {
        Category Get(int id);
        Category Create(Category image);
        Category Update(Category image);
        bool Delete(Category image);
    }
}