using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Repositories;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.DataAccess.EntityFrameworkCore;
public class EfOrderDal : Repository<Order>, IOrderDal
{
}