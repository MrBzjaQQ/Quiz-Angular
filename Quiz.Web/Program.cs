using Quiz.DataAccess;
using Quiz_Angular;

var app = WebApplication
    .CreateBuilder(args)
    .BuildWebApplication()
    .Build();

await app.MigrateDatabaseAsync();
await app.ConfigureWebApplication();
await app.RunAsync();

