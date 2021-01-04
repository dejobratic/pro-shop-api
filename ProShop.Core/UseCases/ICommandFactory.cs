using ProShop.Contract;

namespace ProShop.Core.UseCases
{
    public interface ICommandFactory
    {
        ICommand Create(IRequest request);
        ICommand<T> Create<T>(IRequest request);
    }
}
