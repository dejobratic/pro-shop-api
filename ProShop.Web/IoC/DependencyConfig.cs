﻿using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Web.GraphQL.Mutations;
using ProShop.Web.GraphQL.Queries;
using ProShop.Web.GraphQL.Schemas;

namespace ProShop.Web.IoC
{
    public static class DependencyConfig
    {
        public static void AddDependencies(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            RegisterGraphQlDependencies(services, configuration);
            RegisterCoreDependencies(services, configuration);
            RegisterPersistenceDependencies(services, configuration);

            AuthDependencyConfig.AddDependencies(services, configuration);
            StoreDependencyConfig.AddDependencies(services, configuration);
        }

        private static void RegisterGraphQlDependencies(
            IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddScoped<RootQuery>();
            services.AddScoped<RootMutation>();
            services.AddScoped<ISchema, RootSchema>();
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
        }

        private static void RegisterPersistenceDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
        }
    }
}
