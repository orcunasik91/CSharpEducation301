using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal categoryDal;
    public CategoryManager(ICategoryDal _categoryDal)
    {
        categoryDal = _categoryDal;
    }
    public void Delete(Category entity)
    {
        categoryDal.Delete(entity);
    }

    public List<Category> GetAll()
    {
        return categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return categoryDal.GetById(id);
    }

    public void Insert(Category entity)
    {
        categoryDal.Insert(entity);
    }

    public void Update(Category entity)
    {
        categoryDal.Update(entity);
    }
}