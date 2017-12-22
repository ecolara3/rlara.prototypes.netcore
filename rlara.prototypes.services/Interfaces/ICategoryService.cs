using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface ICategoryService
    {
        CategoryDomainModel Get(int id);
        CategoryDomainModel Create(CategoryDomainModel image);
        CategoryDomainModel Update(CategoryDomainModel image);
        bool Delete(CategoryDomainModel image);
    }
}