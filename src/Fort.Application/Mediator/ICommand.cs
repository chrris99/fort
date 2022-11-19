using MediatR;

namespace Fort.Application.Mediator;

/// <summary>
/// Marker interface to represent a command.
/// </summary>
/// <typeparam name="TResponse">The command response type.</typeparam>
public interface ICommand<out TResponse> : IRequest<TResponse>
{
    
}