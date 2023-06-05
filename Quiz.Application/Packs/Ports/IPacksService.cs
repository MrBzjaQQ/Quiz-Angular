using Quiz.Application.Packs.Ports.Contract.Request;
using Quiz.Application.Packs.Ports.Contract.Response;

namespace Quiz.Application.Packs.Ports;

/// <summary>
/// Service that contain methods for packs
/// </summary>
public interface IPacksService
{
    /// <summary>
    /// Allows to create pack
    /// </summary>
    /// <param name="createModel">Data necessary for pack creation.</param>
    /// <param name="cancellationToken">Http request cancellation token.</param>
    Task<CreatePackDto> CreatePack(CreatePackModel createModel, CancellationToken  cancellationToken);
}