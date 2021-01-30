using Microsoft.AspNetCore.Mvc;
using ProShop.Contract;
using System;

namespace ProShop.Web.Filters
{
    public static class ExceptionExtensions
    {
        public static IActionResult ToUnauthorized(this Exception ex)
            => new UnauthorizedObjectResult(CreateErrorResponse(ex));

        public static IActionResult ToNotFound(this Exception ex)
            => new NotFoundObjectResult(CreateErrorResponse(ex));

        public static IActionResult ToConflict(this Exception ex)
            => new ConflictObjectResult(CreateErrorResponse(ex));

        public static IActionResult ToServerError(this Exception ex)
            => new ObjectResult(CreateErrorResponse(ex)) { StatusCode = 500 };

        public static ErrorResponse CreateErrorResponse(Exception ex)
            => new ErrorResponse { Message = ex.Message };
    }
}
