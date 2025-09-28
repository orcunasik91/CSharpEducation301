using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Context;
using CSharpEducation301.DataAccess.Repositories;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.DataAccess.EntityFrameworkCore;

public class EfProductDal : Repository<Product>, IProductDal
{
    public EfProductDal(AppEducationDbContext context) : base(context)
    {
    }
}