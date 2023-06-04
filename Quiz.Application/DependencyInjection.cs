using Microsoft.Extensions.DependencyInjection;

namespace Quiz.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // add application
        return services;
    }
}