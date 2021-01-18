using System;
using System.Collections.Generic;

namespace ProShop.Web.Extensions
{
    public static class GraphQLExtensions
    {
        public static Guid GetGuid(this IDictionary<string, object> arguments, string argumentName = "id")
            => new Guid((string)arguments[argumentName]);
    }
}
