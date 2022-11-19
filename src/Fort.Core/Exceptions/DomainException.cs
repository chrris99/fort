namespace Fort.Core.Exceptions;

/// <summary>
/// Base exception class for exceptions that occurred in the domain.
/// </summary>
public class DomainException : Exception
{
    /// <summary>
    /// The domain error object containing the error code and the error message.
    /// </summary>
    public Error Error { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DomainException"/> class.
    /// </summary>
    /// <param name="error">The error.</param>
    public DomainException(Error error) : base(error.Message) => Error = error;
}