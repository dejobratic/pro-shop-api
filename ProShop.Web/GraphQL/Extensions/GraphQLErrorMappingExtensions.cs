﻿using GraphQL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProShop.Web.GraphQL.Extensions
{
    public static class GraphQLErrorMappingExtensions
    {
        public static IActionResult ToActionResult(
            this ExecutionErrors errors)
        {
            if (errors.Count > 1)
                return new ObjectResult(errors) { StatusCode = 500 };

            throw errors.Single().InnerException;
        }
    }
}
