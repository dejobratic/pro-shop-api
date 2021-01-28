using GraphQL.Language.AST;
using GraphQL.Validation;
using ProShop.Auth.Domain.Exceptions;
using ProShop.Web.GraphQL.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace ProShop.Web.GraphQL
{
    public class GraphQLAuthValidationRule :
        IValidationRule
    {
        public async Task<INodeVisitor> ValidateAsync(
            ValidationContext context)
        {
            var userContext = context.UserContext as GraphQLUserContext;
            
            var user = userContext?.User;
            var userClaims = user?.Claims?.Select(_ => _.Value)?.ToList();
            var userAuthenticated = user?.Identity?.IsAuthenticated ?? false;

            await Task.CompletedTask;
            return new EnterLeaveListener(_ =>
            {
                _.Match<Field>(field =>
                {
                    var fieldType = context.TypeInfo.GetFieldDef();

                    var permissionsRequired = fieldType.RequiresClaims();
                    var userAuthorized = userAuthenticated && fieldType.ContainsMatchingClaims(userClaims);

                    if (permissionsRequired && !userAuthorized)
                        throw new UserUnauthorizedException();
                });
            });
        }
    }
}
