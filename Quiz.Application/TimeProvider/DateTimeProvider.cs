using Quiz.Application.TimeProvider.Ports;

namespace Quiz.Application.TimeProvider;

public class DateTimeProvider: IDateTimeProvider
{
    public DateTime Now => DateTime.Now;
    public DateTime UtcNow => DateTime.UtcNow;
    public DateOnly DateNow => DateOnly.FromDateTime(DateTime.Now);
    public DateOnly DateNowUtc => DateOnly.FromDateTime(DateTime.UtcNow);
}