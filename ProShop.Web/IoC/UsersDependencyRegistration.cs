using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Auth.App.Services;
using ProShop.Auth.App.UseCases;
using ProShop.Web.GraphQL.Mutations.Types.Users;
using ProShop.Web.GraphQL.Queries.Types.Users;

namespace ProShop.Web.IoC
{
    public static class UsersDependencyRegistration
    {
        public static void AddDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
            RegisterGraphQlDependencies(services, configuration);
            RegisterCoreDependencies(services, configuration);
            RegisterPersistenceDependencies(services, configuration);
        }

        private static void RegisterGraphQlDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<SignUpUserType>();
            services.AddScoped<SignInUserType>();

            services.AddScoped<UserType>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IUserRepository, DummyUserRepository>();

            services.AddScoped<IUserCommandFactory, UserCommandFactory>();
        }

        private static void RegisterPersistenceDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
        }
    }
}
