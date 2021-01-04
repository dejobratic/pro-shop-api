using System.Threading.Tasks;

namespace ProShop.Core.UseCases
{
    public interface ICommand
    {
        Task Execute();
    }

    public interface ICommand<T>
    {
        Task<T> Execute();
    }
}
