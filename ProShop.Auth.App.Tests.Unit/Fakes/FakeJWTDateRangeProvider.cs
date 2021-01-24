using ProShop.Auth.App.Services;
using ProShop.Auth.Domain.Models;

namespace ProShop.Auth.App.Tests.Unit.Fakes
{
    public class FakeJWTDateRangeProvider :
        IJWTDateRangeProvider
    {
        public DateRange Returns { get; set; }

        public DateRange Provide() => Returns;
    }
}
