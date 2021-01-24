using Microsoft.IdentityModel.Tokens;
using ProShop.Auth.App.Models;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Domain.Models;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ProShop.Auth.App.Services
{
    public class JWTGenerator :
        ITokenGenerator
    {
        private readonly IJWTSettings _settings;
        private readonly IJWTDateRangeProvider _dateRangeProvider;

        public JWTGenerator(
            IJWTSettings settings,
            IJWTDateRangeProvider dateRangeProvider)
        {
            _settings = settings;
            _dateRangeProvider = dateRangeProvider;
        }

        public TokenDto Generate(User user)
        {
            var secret = _settings.GetSecretAsBytes();
            var tokenDateRange = _dateRangeProvider.Provide();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = CreateClaimsIdentity(user),
                NotBefore = tokenDateRange.From,
                IssuedAt = tokenDateRange.From,
                Expires = tokenDateRange.To,
                SigningCredentials = CreateSigningCredentials(secret),
            };

            return new TokenDto
            {
                Type = "Bearer",
                Value = CreateToken(tokenDescriptor),
                ExpiresAt = tokenDateRange.To
            };
        }

        private static string CreateToken(
            SecurityTokenDescriptor tokenDescriptor)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        protected static ClaimsIdentity CreateClaimsIdentity(User user)
            => new ClaimsIdentity(CreateClaims(user));

        private static IEnumerable<Claim> CreateClaims(User user)
        {
            yield return new Claim("UserId", user.Id.ToString());
            yield return new Claim("Roles", user.Roles[0].Name);
        }

        protected static SigningCredentials CreateSigningCredentials(
            byte[] key)
        {
            return new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
