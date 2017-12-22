using rlara.prototypes.services.DomainModels;

namespace rlara.prototypes.services.Interfaces
{
    public interface ICategoryService
    {
        CategoryDomainModel Get(int id);
        CategoryDomainModel Create(CategoryDomainModel categoryDomainModel);
        CategoryDomainModel Update(CategoryDomainModel categoryDomainModel);
        bool Delete(CategoryDomainModel categoryDomainModel);
    }
}