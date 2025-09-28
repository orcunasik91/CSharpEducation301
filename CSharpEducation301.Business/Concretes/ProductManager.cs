using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.Business.Concretes;

public class ProductManager : IProductService
{
    private readonly IProductDal productDal;

    public ProductManager(IProductDal _productDal)
    {
        productDal = _productDal;
    }

    public void Delete(Product entity)
    {
        productDal.Delete(entity);
    }

    public List<Product> GetAll()
    {
        return productDal.GetAll();
    }

    public Product GetById(int id)
    {
        return productDal.GetById(id);
    }

    public List<Product> GetProductsWithCategory()
    {
        return productDal.GetProductsWithCategory();
    }

    public void Insert(Product entity)
    {
        productDal.Insert(entity);
    }

    public void Update(Product entity)
    {
        productDal.Update(entity);
    }
}