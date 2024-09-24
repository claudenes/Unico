using System.Linq.Expressions;

namespace Unico.Domain.Interfaces
{
    public interface IResourceRepository<TEntity> where TEntity : class
    {
        TEntity Delete(Guid id);
        IList<TEntity> ReadAll();
        TEntity ReadById(Guid id);
        TEntity Create(TEntity o);
        TEntity Update(TEntity o);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        string GetConnectionString();
        TEntity Delete(TEntity o);
    }
}
