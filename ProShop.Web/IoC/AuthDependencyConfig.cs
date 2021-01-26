using GraphQL.Validation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ProShop.Auth.App.Models;
using ProShop.Auth.App.Services;
using ProShop.Auth.App.UseCases;
using ProShop.Auth.Domain.Models;
using ProShop.Web.GraphQL;
using ProShop.Web.GraphQL.Mutations.Types.Auth;
using ProShop.Web.GraphQL.Types.Auth;

namespace ProShop.Web.IoC
{
    public static class AuthDependencyConfig
    {
        public static void AddDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
            RegisterJwtDependencies(services, configuration);
            RegisterGraphQlDependencies(services, configuration);
            RegisterCoreDependencies(services, configuration);
            RegisterPersistenceDependencies(services, configuration);
        }

        private static void RegisterJwtDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
            var jwtSettings = new JWTSettings
            {
                Secret = configuration["JWT_SECRET_KEY"]
            };

            services.AddSingleton<IJWTSettings>(jwtSettings);

            services
                .AddAuthentication(opt =>
                {
                    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(opt =>
                {
                    opt.SaveToken = true;
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateLifetime = true,
                        ValidateAudience = false,
                        RequireExpirationTime = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(jwtSettings.GetSecretAsBytes()),

                    };
                });

            services
                .AddAuthorization(opt =>
                {
                    opt.AddPolicy(Role.Customer.Name, p => p.RequireClaim(Role.Customer.Name));
                    opt.AddPolicy(Role.Admin.Name, p => p.RequireClaim(Role.Admin.Name));
                });
            
            services.AddHttpContextAccessor();
            services.AddScoped<IValidationRule, GraphQLAuthValidationRule>();
        }

        private static void RegisterGraphQlDependencies(
            IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<SignUpUserType>();
            services.AddScoped<SignInUserType>();

            services.AddScoped<UserType>();
            services.AddScoped<TokenType>();
        }

        private static void RegisterCoreDependencies(
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJWTDateRangeProvider, JWTDateRangeProvider>();
            services.AddScoped<ITokenGenerator, JWTGenerator>();

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
