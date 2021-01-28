using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Store.App.Services;
using ProShop.Store.App.UseCases;
using ProShop.Web.GraphQL.Types.Store;

namespace ProShop.Web.IoC
{
    public static class StoreDependencyConfig
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
            services.AddScoped<OrderType>();
            services.AddScoped<OrderItemType>();
            services.AddScoped<AddressType>();
            services.AddScoped<PaymentType>();
            services.AddScoped<CustomerType>();

            services.AddScoped<ProductType>();
            services.AddScoped<ProductReviewType>();
            services.AddScoped<CustomerType>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IOrderRepository, DummyOrderRepository>(); 
            services.AddSingleton<IProductRepository, DummyProductRepository>();

            services.AddScoped<IOrderCommandFactory, OrderCommandFactory>();
            services.AddScoped<IProductCommandFactory, ProductCommandFactory>();
        }

        private static void RegisterPersistenceDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
        }
    }
}
