using Quiz.DataAccess.Settings;

namespace Quiz_Angular.Settings;

/// <summary>
/// Application settings
/// </summary>
public sealed record WebAppSettings
{
    /// <summary>
    /// Settings for database
    /// </summary>
    public DatabaseSettings? Database { get; init; }
}