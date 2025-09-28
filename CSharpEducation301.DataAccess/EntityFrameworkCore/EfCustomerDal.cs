using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Context;
using CSharpEducation301.DataAccess.Repositories;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.DataAccess.EntityFrameworkCore;

public class EfCustomerDal : Repository<Customer>, ICustomerDal
{
    public EfCustomerDal(AppEducationDbContext context) : base(context)
    {
    }
}