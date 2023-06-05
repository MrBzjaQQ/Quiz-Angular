using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quiz.DataAccess.Data;
using Quiz.DataAccess.Repositories.Pack;
using Quiz.DataAccess.Services.DbMigrator;
using Quiz.DataAccess.Settings;

namespace Quiz.DataAccess;

public static class DependencyInjection
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, DatabaseSettings? settings)
    {
        if (settings?.ConnectionString is null)
            throw new ArgumentNullException(nameof(settings));

        services.AddDbContext<QuizDbContext>(options => options.UseNpgsql(settings.ConnectionString));
        services.AddScoped<IQuizDbContext>(provider => provider.GetRequiredService<QuizDbContext>());
        services.AddTransient<IQuizDbMigrator, QuizDbMigrator>();
        services.AddRepositories();

        return services;
    }

    public static async Task MigrateDatabaseAsync(this IHost application)
    {
        using var scope = application.Services.CreateScope();
        var quizDbMigrator = scope.ServiceProvider.GetRequiredService<IQuizDbMigrator>();
        try
        {
            await quizDbMigrator.MigrateAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPacksRepository, PacksRepository>();
        return services;
    }
}