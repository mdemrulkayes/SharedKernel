using System.Linq.Expressions;

namespace SharedKernel;
public interface IReadRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> FirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> expression,
        string includeProperties = ""
    );

    Task<List<TEntity>> FindAllAsync(
        Expression<Func<TEntity, bool>>? expression = null,
        CancellationToken cancellationToken = default
    );

    Task<PaginatedList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression, int pageNumber = 1, int pageSize = 10,
        CancellationToken cancellationToken = default);
    Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>> expression
    );
}
