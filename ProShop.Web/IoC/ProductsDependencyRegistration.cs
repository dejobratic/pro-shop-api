using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Products.App.Services;
using ProShop.Products.App.UseCases;
using ProShop.Web.GraphQL.Queries.Types.Products;

namespace ProShop.Web.IoC
{
    public static class ProductsDependencyRegistration
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
            services.AddScoped<ProductType>();
            services.AddScoped<ProductReviewType>();
            services.AddScoped<CustomerType>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IProductRepository, DummyProductRepository>();

            services.AddScoped<IProductCommandFactory, ProductCommandFactory>();
        }

        private static void RegisterPersistenceDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
        }
    }
}
