using FarolContext.Domain.Commands.Contracts;

namespace FarolContext.Domain.Handler.Contratcs
{
    public interface IHandler<T> where T : ICommand 
    {
        ICommandResult Handle(T command);
    }
}