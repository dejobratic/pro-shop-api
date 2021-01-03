﻿using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using ProShop.Web.Contract;
using System.Threading.Tasks;

namespace ProShop.Web.Controllers
{
    [Route("graphql")]
    public class GraphQLController :
        Controller
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;

        public GraphQLController(
            ISchema schema,
            IDocumentExecuter executer)
        {
            _schema = schema;
            _executer = executer;
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] GraphQLQuery query)
        {
            var aa = query.Variables.ToInputs();

            var result = await _executer.ExecuteAsync(_ =>
            {
                _.Schema = _schema;
                _.Query = query.Query;
                _.Inputs = query.Variables.ToInputs();

            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result.Data);
        }
    }
}