using Quiz.DataAccess.Data;
using Quiz.DataAccess.Repositories.Base;

namespace Quiz.DataAccess.Repositories.Pack;

public class PacksRepository: BaseRepository<Domain.Entities.Pack, long>, IPacksRepository
{
    public PacksRepository(IQuizDbContext quizDbContext) : base(quizDbContext)
    {
    }
}