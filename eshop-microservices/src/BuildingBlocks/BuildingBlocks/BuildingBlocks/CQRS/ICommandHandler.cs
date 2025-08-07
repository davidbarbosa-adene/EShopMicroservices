using MediatR;

namespace BuildingBlocks.CQRS
{
    // Handler for commands that don't return a response.
    public interface ICommandHandler<in TCommand>
        : ICommandHandler<TCommand, Unit>
        where TCommand : ICommand<Unit>
    {
    }

    // Handler for commands that return a response.
    public interface ICommandHandler<in TCommand, TResponse> 
        : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
    }
}
