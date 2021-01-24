using ProShop.Auth.Domain.Models;
using System;

namespace ProShop.Auth.App.Services
{
    public class JWTDateRangeProvider :
        IJWTDateRangeProvider
    {
        public DateRange Provide()
        {
            var now = DateTime.UtcNow;
            return new DateRange(now, now.AddDays(1));
        }
    }
}
