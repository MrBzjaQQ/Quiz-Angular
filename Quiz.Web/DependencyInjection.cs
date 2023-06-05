using System.Text.Json;
using System.Text.Json.Serialization;
using DateOnlyTimeOnly.AspNet.Converters;
using Quiz.Application;
using Quiz.Application.Account.Ports;
using Quiz.DataAccess;
using Quiz_Angular.Core.Authorization;
using Quiz_Angular.Settings;

namespace Quiz_Angular;

public static class DependencyInjection
{
    public static WebApplicationBuilder BuildWebApplication(this WebApplicationBuilder builder)
    {
        var appSettings = builder.Configuration.Get<WebAppSettings>();
        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Application services
        builder.Services
            .AddApplication()
            .AddDatabase(appSettings?.Database);

        // Authentication & Authorization
        builder.AddAuthorization();

        builder.Services.AddMvc().AddJsonOptions(jsonOptions =>
        {
            jsonOptions.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            jsonOptions.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        });

        builder.Services.AddDateOnlyTimeOnlyStringConverters();

        return builder;
    } 

    public static async Task<WebApplication> ConfigureWebApplication(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        await app.MigrateDatabaseAsync();
        app.MapFallbackToFile("index.html");

        return app;
    }

    private static WebApplicationBuilder AddAuthorization(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddHttpContextAccessor()
            .AddScoped<ICurrentUser, CurrentUser>();

        return builder;
    }
}