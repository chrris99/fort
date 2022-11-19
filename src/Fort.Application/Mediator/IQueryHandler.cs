using MediatR;

namespace Fort.Application.Mediator;

/// <summary>
/// Marker interface to represent a query handler.
/// </summary>
/// <typeparam name="TQuery">The query type.</typeparam>
/// <typeparam name="TResponse">The query response type.</typeparam>
public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
    
}