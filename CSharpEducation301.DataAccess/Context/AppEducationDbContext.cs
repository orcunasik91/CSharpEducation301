using CSharpEducation301.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CSharpEducation301.DataAccess.Context;
public  class AppEducationDbContext : DbContext
{
    public AppEducationDbContext(DbContextOptions<AppEducationDbContext> options) : base(options)
    { 
    }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}