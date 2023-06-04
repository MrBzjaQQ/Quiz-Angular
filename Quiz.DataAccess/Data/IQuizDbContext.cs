namespace Quiz.DataAccess.Data;

public interface IQuizDbContext
{
    Task RunInTransactionAsync(Func<Task> func, CancellationToken cancellationToken = default);
}