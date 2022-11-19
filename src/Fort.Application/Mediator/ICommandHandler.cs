using MediatR;

namespace Fort.Application.Mediator;

/// <summary>
/// Marker interface to represent a command handler.
/// </summary>
/// <typeparam name="TCommand">The command type.</typeparam>
/// <typeparam name="TResponse">The command response type.</typeparam>
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{
    
}