using MediatR;

namespace Fort.Application.Mediator;

/// <summary>
/// Marker interface to represent a query.
/// </summary>
/// <typeparam name="TResponse">The query response type.</typeparam>
public interface IQuery<out TResponse> : IRequest<TResponse>
{
    
}