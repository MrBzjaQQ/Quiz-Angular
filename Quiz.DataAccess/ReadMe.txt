Add migration:
cd .\Quiz.DataAccess
dotnet ef migrations add MigrationName -s ..\Quiz.Web --context QuizDbContext

Remove migration:
cd .\Quiz.DataAccess
dotnet ef migrations remove -s ..\Quiz.Web --context QuizDbContext
