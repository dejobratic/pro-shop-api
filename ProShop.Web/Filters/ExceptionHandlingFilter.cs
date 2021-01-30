using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProShop.Auth.Domain.Exceptions;
using ProShop.Core.Exceptions;
using System;

namespace ProShop.Web.Filters
{
    public class ExceptionHandlingFilter :
        IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = CreateResult(context.Exception);
        }

        private static IActionResult CreateResult(Exception ex)
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
    }
}
