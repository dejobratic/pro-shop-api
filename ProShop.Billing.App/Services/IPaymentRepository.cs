using ProShop.Billing.Domain.Models;
using ProShop.Core.Services;

namespace ProShop.Billing.App.Services
{
    public interface IPaymentRepository :
        IRepository<Payment>
    {
    }
}
