using System.Linq.Expressions;

namespace SharedKarnel;
public interface IRepository<TEntity> : IReadRepository<TEntity>
    where TEntity : BaseEntity
{
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(TEntity entity);

    Task Delete(TEntity entity);

    Task Delete(Expression<Func<TEntity, bool>> expression);

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
