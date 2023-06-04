namespace Quiz.DataAccess.Repositories.Base;

public interface IBaseRepository<TKey>
where TKey : struct, IEquatable<TKey>
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}