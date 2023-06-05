using Microsoft.EntityFrameworkCore;
using Quiz.DataAccess.Data;
using Quiz.Domain.Entities.Base;

namespace Quiz.DataAccess.Repositories.Base;

public abstract class BaseRepository<TEntity, TKey>: IBaseRepository<TEntity, TKey>
    where TEntity : IdEntity<TKey>
    where TKey : struct, IEquatable<TKey>
{
    private readonly IQuizDbContext _quizDbContext;

    protected BaseRepository(IQuizDbContext quizDbContext)
    {
        _quizDbContext = quizDbContext;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _quizDbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
    {
        return await _quizDbContext
            .Set<TEntity>()
            .SingleOrDefaultAsync(entity => entity.Id.Equals(id), cancellationToken);
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _quizDbContext.Set<TEntity>().Add(entity);
        await _quizDbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public virtual async Task DeleteAsync(TKey id, CancellationToken cancellationToken = default)
    {
        var set = _quizDbContext.Set<TEntity>();
        var entity = await _quizDbContext.Set<TEntity>().SingleAsync(entity => entity.Id.Equals(id), cancellationToken);
        set.Remove(entity);
        await _quizDbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _quizDbContext.Set<TEntity>().Update(entity);
        return _quizDbContext.SaveChangesAsync(cancellationToken);
    }
}