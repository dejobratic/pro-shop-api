using ProShop.Core.Models;

namespace ProShop.Core.Tests.Unit.Fakes
{
    public static class MockCredentialsBuilder
    {
        public static Credentials Build(
            string email = "FirstName.LastName@example.com",
            string password = "password")
        {
            return new Credentials(
                email,
                password);
        }
    }
}
