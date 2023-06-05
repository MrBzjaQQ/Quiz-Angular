using Quiz.Application.Packs.Ports.Contract.Request;
using Quiz.Application.Packs.Ports.Contract.Response;
using Quiz.Domain.Entities;

namespace Quiz.Application.Packs;

public static class PacksMappings
{
    public static Pack FromCreateModel(this CreatePackModel model, string author, DateTime creationDateTime)
    {
        return new Pack(model.Name, creationDateTime, author,Array.Empty<Card>());
    }

    public static CreatePackDto ToCreatePackDto(this Pack pack)
    {
        return new CreatePackDto
        {
            Author = pack.Author,
            CreationDateTime = pack.CreationDateTime,
            Id = pack.Id,
            Name = pack.Name
        };
    }
}