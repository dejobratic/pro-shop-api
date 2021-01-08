using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProShop.App.Services;
using ProShop.App.UseCases;
using ProShop.Web.GraphQL.Queries;
using ProShop.Web.GraphQL.Schemas;
using ProShop.Web.GraphQL.Types;

namespace ProShop.Web.IoC
{
    public static class DependencyRegistration
    {
        public static void AddDependencies(
            this IServiceCollection services,
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
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();

            services.AddScoped<ProductType>();
            services.AddScoped<ProductReviewType>();
            services.AddScoped<UserType>();
            services.AddScoped<OrderType>();

            services.AddScoped<RootQuery>();

            services.AddScoped<ISchema, RootSchema>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductRepository, FakeProductRepository>();
            services.AddScoped<IUserRepository, FakeUserRepository>();
            services.AddScoped<IOrderRepository, FakeOrderRepository>();

            services.AddScoped<IProductCommandFactory, ProductCommandFactory>();
            services.AddScoped<IUserCommandFactory, UserCommandFactory>();
        }

        private static void RegisterPersistenceDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
        }
    }
}
