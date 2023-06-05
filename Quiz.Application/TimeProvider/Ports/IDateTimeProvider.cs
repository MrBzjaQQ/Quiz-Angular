namespace Quiz.Application.TimeProvider.Ports;

/// <summary>
/// Provider of Date and Time
/// </summary>
public interface IDateTimeProvider
{
    /// <summary>
    /// Current time with timezone
    /// </summary>
    DateTime Now { get; }

    /// <summary>
    /// Current time in UTC
    /// </summary>
    DateTime UtcNow { get; }

    /// <summary>
    /// Current date with timezone
    /// </summary>
    DateOnly DateNow { get; }

    /// <summary>
    /// Current date in UTC
    /// </summary>
    DateOnly DateNowUtc { get; }
}