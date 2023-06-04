using Microsoft.EntityFrameworkCore;

namespace Quiz.DataAccess.Data;

public class QuizDbContext: DbContext, IQuizDbContext
{
    public QuizDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public async Task RunInTransactionAsync(Func<Task> func, CancellationToken cancellationToken = default)
    {
        await using var transaction = await Database.BeginTransactionAsync(cancellationToken);
        try
        {
            await func();
            await transaction.CommitAsync(cancellationToken);
        }
        catch
        {
            await transaction.RollbackAsync(cancellationToken);
            throw;
        }
    }
}