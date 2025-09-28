namespace CSharpEducation301.Business.Abstracts;
public interface IBaseService<TEntity> where TEntity : class
{
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    List<TEntity> GetAll();
    TEntity GetById(int id);
}