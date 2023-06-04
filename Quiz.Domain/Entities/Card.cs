using Quiz.Domain.Entities.Base;

namespace Quiz.Domain.Entities;

/// <summary>
/// Card (question)
/// </summary>
public record Card: IdEntity<long>
{
    /// <summary>
    /// Question of the card
    /// </summary>
    public string Question { get; private set; } = string.Empty;

    /// <summary>
    /// Answer
    /// </summary>
    public string Answer { get; private set; } = string.Empty;

    /// <summary>
    /// Pack in which the card in. Relation identifier.
    /// </summary>
    public long? PackId { get; private set; }

    /// <summary>
    /// Pack in which the card in
    /// </summary>
    public Pack? Pack { get; private set; }
}