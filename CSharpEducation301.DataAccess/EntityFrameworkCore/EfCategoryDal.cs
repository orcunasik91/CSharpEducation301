using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Context;
using CSharpEducation301.DataAccess.Repositories;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.DataAccess.EntityFrameworkCore;

public class EfCategoryDal : Repository<Category>, ICategoryDal
{
    public EfCategoryDal(AppEducationDbContext context) : base(context)
    {
    }
}