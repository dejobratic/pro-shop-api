using System;

namespace ProShop.Auth.Domain.Exceptions
{
    public class UserAlreadyVerifiedException :
        Exception
    {
        public UserAlreadyVerifiedException()
            : base("User has already been verified.")
        {

        }
    }
}
