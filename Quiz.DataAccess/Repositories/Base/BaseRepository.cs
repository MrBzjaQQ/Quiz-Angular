using Microsoft.EntityFrameworkCore;
using Quiz.DataAccess.Data;
using Quiz.Domain.Entities.Base;

namespace Quiz.DataAccess.Repositories.Base;

public abstract class BaseRepository<TKey>: IBaseRepository<TKey>
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

    public virtual async Task<TEntity?> GetById<TEntity>(TKey id, CancellationToken cancellationToken = default)
        where TEntity : IdEntity<TKey>
    {
        return await _quizDbContext
            .Set<TEntity>()
            .SingleOrDefaultAsync(entity => entity.Id.Equals(id), cancellationToken);
    }
}