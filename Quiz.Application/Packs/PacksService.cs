using Quiz.Application.Account.Ports;
using Quiz.Application.Packs.Ports;
using Quiz.Application.Packs.Ports.Contract.Request;
using Quiz.Application.Packs.Ports.Contract.Response;
using Quiz.Application.TimeProvider.Ports;
using Quiz.DataAccess.Repositories.Pack;

namespace Quiz.Application.Packs;

public class PacksService: IPacksService
{
    private readonly IPacksRepository _repository;
    private readonly ICurrentUser _currentUser;
    private readonly IDateTimeProvider _dateTimeProvider;

    public PacksService(IPacksRepository repository, ICurrentUser currentUser, IDateTimeProvider dateTimeProvider)
    {
        _repository = repository;
        _currentUser = currentUser;
        _dateTimeProvider = dateTimeProvider;
    }

    public async Task<CreatePackDto> CreatePack(CreatePackModel createModel, CancellationToken cancellationToken)
    {
        var createdPack = await _repository.CreateAsync(
                createModel.FromCreateModel(_currentUser.Login, _dateTimeProvider.UtcNow),
                cancellationToken);

        return createdPack.ToCreatePackDto();
    }
}