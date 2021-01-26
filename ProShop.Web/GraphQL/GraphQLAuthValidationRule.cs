using GraphQL.Language.AST;
using GraphQL.Validation;
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
            var isAuthenticated = user?.Identity?.IsAuthenticated ?? false;

            await Task.CompletedTask;
            return new EnterLeaveListener(op =>
            {
                op.Match<Field>(field =>
                {
                    var fieldType = context.TypeInfo.GetFieldDef();
                    var claims = user?.Claims?.Select(_ => _.Value)?.ToList();

                    if (fieldType.ContainsAnyClaims() && (!isAuthenticated || !fieldType.ContainsMatchingClaims(claims)))
                    {
                        var error = CreateAuthError(context.OriginalQuery, field);

                        context.ReportError(error);
                    }
                });
            });
        }

        private static ValidationError CreateAuthError(
            string originalQuery,
            Field field)
        {
            return new ValidationError(
                originalQuery,
                "auth-required",
                $"User is unauthorized for this operation.",
                field);
        }
    }
}
