using GraphQL;
using GraphQL.Types;
using GraphQL.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProShop.Web.GraphQL;
using ProShop.Web.GraphQL.Extensions;
using System.Threading.Tasks;

namespace ProShop.Web.Controllers
{
    [Route("graphql")]
    public class GraphQLController :
        ControllerBase
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        private readonly IValidationRule _validationRule;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GraphQLController(
            ISchema schema,
            IDocumentExecuter executer,
            IValidationRule validationRule,
            IHttpContextAccessor httpContextAccessor)
        {
            _schema = schema;
            _executer = executer;
            _validationRule = validationRule;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] GraphQLQuery query)
        {
            var result = await _executer.ExecuteAsync(
                _ =>
                {
                    _.Schema = _schema;
                    _.Query = query.Query;
                    _.Inputs = query.Variables.ToInputs();
                    _.ValidationRules = new[] { _validationRule };
                    _.UserContext = new GraphQLUserContext { User = _httpContextAccessor.HttpContext.User };
                });

            if (result.Errors?.Count > 0)
                return result.Errors.ToActionResult();

            return Ok(result.Data);
        }
    }
}
