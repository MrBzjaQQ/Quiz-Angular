using Quiz.Domain.Entities.Base;

namespace Quiz.Domain.Entities;

/// <summary>
/// Pack of cards. Pack contains cards (questions).
/// </summary>
public record Pack: IdEntity<long>
{
    /// <summary>
    /// User-defined name of pack
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Date and time when user created the pack
    /// </summary>
    public DateTime CreationDateTime { get; private set; }

    /// <summary>
    /// Date and time when user updated the pack
    /// </summary>
    public DateTime? UpdateDateTime { get; private set; }

    /// <summary>
    /// Author of the pack
    /// </summary>
    public string Author { get; private set; } = string.Empty;

    /// <summary>
    /// Cards in pack
    /// </summary>
    public ICollection<Card> Cards { get; private set; } = Array.Empty<Card>();

    /// <summary>
    /// EF constructor
    /// </summary>
    protected Pack()
    {
        
    }

    /// <summary>
    /// Constructor for Pack entity
    /// </summary>
    public Pack(
        string name,
        DateTime now,
        string author,
        IList<Card> cards)
    {
        Name = name;
        CreationDateTime = now;
        Cards = cards;
        Author = author;
    }
}