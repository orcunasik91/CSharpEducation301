using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace CSharpEducation301.DataAccess.Repositories;

public class Repository<T> : IRepositoryDal<T> where T : class
{
    private readonly AppEducationDbContext _context;
    private readonly DbSet<T> _dbSet;
    public Repository()
    {
        _dbSet = _context.Set<T>();
    }
    public void Delete(T entity)
    {
        var deletedEntity = _context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Insert(T entity)
    {
        var addedEntity = _context.Entry(entity);
        addedEntity.State = EntityState.Added;
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        var updatedEntity = _context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        _context.SaveChanges();
    }
}