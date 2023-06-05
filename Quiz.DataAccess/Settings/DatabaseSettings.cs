namespace Quiz.DataAccess.Settings;

/// <summary>
/// Settings for connecting to the database
/// </summary>
public sealed record DatabaseSettings
{
    /// <summary>
    /// Database connection string
    /// </summary>
    public string? ConnectionString { get; init; }
}