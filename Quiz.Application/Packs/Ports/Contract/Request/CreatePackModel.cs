namespace Quiz.Application.Packs.Ports.Contract.Request;

public record CreatePackModel
{
    public string Name { get; init; } = string.Empty;
}