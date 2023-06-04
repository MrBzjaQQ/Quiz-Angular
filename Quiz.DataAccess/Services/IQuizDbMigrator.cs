namespace Quiz.DataAccess.Services;

/// <summary>
/// Database migrator. It runs migrations when application is started.
/// </summary>
public interface IQuizDbMigrator
{
    /// <summary>
    /// Method runs migrations
    /// </summary>
    Task MigrateAsync();

    /// <summary>
    /// Method checks if database is deleted
    /// </summary>
    Task EnsureDatabaseDeletedAsync();
}