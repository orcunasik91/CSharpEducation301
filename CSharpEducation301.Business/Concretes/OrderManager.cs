using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.Business.Concretes;

public class OrderManager : IOrderService
{
    private readonly IOrderDal orderDal;
    public OrderManager(IOrderDal _orderDal)
    {
        orderDal = _orderDal;
    }
    public void Delete(Order entity)
    {
        orderDal.Delete(entity);
    }

    public List<Order> GetAll()
    {
        return orderDal.GetAll();
    }

    public Order GetById(int id)
    {
        return orderDal.GetById(id);
    }

    public void Insert(Order entity)
    {
        orderDal.Insert(entity);
    }

    public void Update(Order entity)
    {
        orderDal.Update(entity);
    }
}