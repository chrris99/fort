﻿namespace Fort.Core.Abstractions;

/// <summary>
/// Marker interface to represent auditable entities.
/// </summary>
public interface IAuditableEntity
{
    /// <summary>
    /// Gets the created on date and time in UTC format.
    /// </summary>
    DateTime CreatedOnUtc { get; }
    
    /// <summary>
    /// Gets the modified on date and time in UTC format.
    /// </summary>
    DateTime? ModifiedOnUtc { get; }
}