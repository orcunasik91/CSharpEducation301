using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Context;
using CSharpEducation301.DataAccess.Repositories;
using CSharpEducation301.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CSharpEducation301.DataAccess.EntityFrameworkCore;

public class EfProductDal : Repository<Product>, IProductDal
{
    private readonly AppEducationDbContext _context;
    public EfProductDal(AppEducationDbContext context) : base(context)
    {
        _context = context;
    }

    public List<Product> GetProductsWithCategory()
    {
        return _context.Products.Include(p => p.Category)
            .Select(p => new Product
            {
                ProductId = p.ProductId,
                CategoryId = p.CategoryId,
                CategoryName = p.Category.CategoryName,
                Stock = p.Stock,
                Price = p.Price,
                Description = p.Description
            }).ToList();
    }
}