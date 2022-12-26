namespace Fort.Domain.Abstractions;

/// <summary>
/// Marker interface to represent soft-deletable entities.
/// </summary>
public interface ISoftDeletableEntity
{

    /// <summary>
    /// Gets the deleted flag value, indicating whether the entity has been deleted.
    /// </summary>
    bool Deleted { get; }
    
    /// <summary>
    /// Gets the deleted on date and time in UTC format.
    /// </summary>
    DateTime? DeletedOn { get; }
}