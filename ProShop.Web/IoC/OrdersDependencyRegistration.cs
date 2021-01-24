using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Shopping.App.Services;
using ProShop.Shopping.App.UseCases;
using ProShop.Web.GraphQL.Queries.Types.Orders;

namespace ProShop.Web.IoC
{
    public static class OrdersDependencyRegistration
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
            services.AddScoped<ProductType>();;
            services.AddScoped<AddressType>();
            services.AddScoped<PaymentType>();
            services.AddScoped<CustomerType>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IOrderRepository, DummyOrderRepository>();

            services.AddScoped<IOrderCommandFactory, OrderCommandFactory>();
        }

        private static void RegisterPersistenceDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
        }
    }
}
