namespace Quiz.Application.Account.Ports;

/// <summary>
/// Contains information about current user
/// </summary>
public interface ICurrentUser
{
    /// <summary>
    /// User login
    /// </summary>
    string Login { get; }
}