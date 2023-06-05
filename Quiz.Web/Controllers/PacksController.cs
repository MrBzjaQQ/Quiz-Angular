using Microsoft.AspNetCore.Mvc;
using Quiz.Application.Packs.Ports;
using Quiz.Application.Packs.Ports.Contract.Request;
using Quiz.Application.Packs.Ports.Contract.Response;

namespace Quiz_Angular.Controllers;

/// <summary>
/// Controller with actions for packs
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PacksController : ControllerBase
{
    private readonly IPacksService _packsService;

    public PacksController(IPacksService packsService)
    {
        _packsService = packsService;
    }

    [HttpPost]
    public Task<CreatePackDto> CreatePack(CreatePackModel model)
    {
        return _packsService.CreatePack(model, HttpContext.RequestAborted);
    }
}