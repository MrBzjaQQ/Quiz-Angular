using Microsoft.EntityFrameworkCore;
using Quiz.DataAccess.Data;

namespace Quiz.DataAccess.Services.DbMigrator;

public class QuizDbMigrator : IQuizDbMigrator
{
    private readonly QuizDbContext _context;

    public QuizDbMigrator(QuizDbContext context)
    {
        _context = context;
    }

    public async Task MigrateAsync()
    {
        await _context.Database.MigrateAsync();
    }

    public async Task EnsureDatabaseDeletedAsync()
    {
        await _context.Database.EnsureDeletedAsync();
    }
}