using ProShop.Auth.Domain.Models;

namespace ProShop.Auth.App.Services
{
    public interface IJWTDateRangeProvider
    {
        DateRange Provide();
    }
}
