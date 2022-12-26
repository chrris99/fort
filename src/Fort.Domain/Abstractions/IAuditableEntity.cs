namespace Fort.Domain.Abstractions;

/// <summary>
/// Marker interface to represent auditable entities.
/// </summary>
public interface IAuditableEntity
{
    /// <summary>
    /// Gets the created on date and time in UTC format.
    /// </summary>
    DateTime CreatedOn { get; }
    
    /// <summary>
    /// Gets the unique identifier of the user, who created the entity.
    /// </summary>
    Guid? CreatedBy { get; }
    
    /// <summary>
    /// Gets the modified on date and time in UTC format.
    /// </summary>
    DateTime? ModifiedOn { get; }
}