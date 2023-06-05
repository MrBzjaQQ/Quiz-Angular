namespace Quiz.Application.Packs.Ports.Contract.Response;

public record CreatePackDto
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Author { get; init; } = string.Empty;
    public DateTime CreationDateTime { get; init; }
    public DateTime? UpdateDateTime { get; init; }
}