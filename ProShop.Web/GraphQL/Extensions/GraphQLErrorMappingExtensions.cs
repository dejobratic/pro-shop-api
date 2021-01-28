using GraphQL;
using Microsoft.AspNetCore.Mvc;
using ProShop.Auth.Domain.Exceptions;
using ProShop.Contract;
using ProShop.Core.Exceptions;
using System;
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

            return CreateResult(errors.Single().InnerException);
        }

        private static IActionResult CreateResult(
            Exception ex)
        {
            switch (ex)
            {
                case UserUnauthorizedException userUnauthorizedEx:
                    return userUnauthorizedEx.ToUnauthorized();

                case InvalidUserCredentialsException invalidUserCredsEx:
                    return invalidUserCredsEx.ToUnauthorized();

                case EntityNotFoundException entityNotFoundEx:
                    return entityNotFoundEx.ToNotFound();

                case EntityAlreadyExistsException entityExistsEx:
                    return entityExistsEx.ToConflict();

                default:
                    return ex.ToServerError();
            }
        }

        private static IActionResult ToUnauthorized(this Exception ex)
            => new UnauthorizedObjectResult(CreateErrorResponse(ex));

        private static IActionResult ToNotFound(this Exception ex)
            => new NotFoundObjectResult(CreateErrorResponse(ex));

        private static IActionResult ToConflict(this Exception ex)
            => new ConflictObjectResult(CreateErrorResponse(ex));

        private static IActionResult ToServerError(this Exception ex)
            => new ObjectResult(CreateErrorResponse(ex)) { StatusCode = 500 };

        private static ErrorResponse CreateErrorResponse(Exception ex)
            => new ErrorResponse { Message = ex.Message };
    }
}
