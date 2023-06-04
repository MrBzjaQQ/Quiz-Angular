namespace Quiz.Domain.Entities.Base;

/// <summary>
/// Entity with identifier
/// </summary>
/// <typeparam name="TKey">Identifier type</typeparam>
public abstract record IdEntity<TKey>
where TKey : struct
{
    /// <summary>
    /// Entity identifier
    /// </summary>
    public TKey Id { get; private set; }
};