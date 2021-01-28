using System;

namespace ProShop.Auth.Domain.Exceptions
{
    public class UserUnauthorizedException :
        Exception
    {
        public UserUnauthorizedException()
            : base("User is unauthorized to perform current operation.")
        {
        }
    }
}
