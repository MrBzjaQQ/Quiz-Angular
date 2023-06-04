using Microsoft.EntityFrameworkCore;

namespace Quiz.DataAccess.Data;

public interface IQuizDbContext
{
    Task RunInTransactionAsync(Func<Task> func, CancellationToken cancellationToken = default);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    DbSet<TEntity> Set<TEntity>() where TEntity: class;
}