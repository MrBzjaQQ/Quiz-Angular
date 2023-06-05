using Quiz.Application.Account.Ports;

namespace Quiz_Angular.Core.Authorization;

/// <summary>
/// Current user
/// </summary>
public class CurrentUser: ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string Login => "User Login";
}