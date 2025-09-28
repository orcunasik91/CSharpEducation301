using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.Business.Concretes;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal customerDal;

    public CustomerManager(ICustomerDal _customerDal)
    {
        customerDal = _customerDal;
    }

    public void Delete(Customer entity)
    {
        customerDal.Delete(entity);
    }

    public List<Customer> GetAll()
    {
        return customerDal.GetAll();
    }

    public Customer GetById(int id)
    {
        return customerDal.GetById(id);
    }

    public void Insert(Customer entity)
    {
        customerDal.Insert(entity);
    }

    public void Update(Customer entity)
    {
        customerDal.Update(entity);
    }
}