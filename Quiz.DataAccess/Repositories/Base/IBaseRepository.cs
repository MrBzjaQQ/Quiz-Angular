using Quiz.Domain.Entities.Base;

namespace Quiz.DataAccess.Repositories.Base;

public interface IBaseRepository<TEntity, in TKey>
    where TEntity : IdEntity<TKey>
    where TKey : struct, IEquatable<TKey>
{
    Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);
    Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(TKey id, CancellationToken cancellationToken = default);
    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}