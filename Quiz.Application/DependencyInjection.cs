using Microsoft.Extensions.DependencyInjection;
using Quiz.Application.Packs;
using Quiz.Application.Packs.Ports;
using Quiz.Application.TimeProvider.Ports;

namespace Quiz.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // add application
        return services.AddServices();
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddTransient<IDateTimeProvider, TimeProvider.DateTimeProvider>()
            .AddTransient<IPacksService, PacksService>();

        return services;
    }
}