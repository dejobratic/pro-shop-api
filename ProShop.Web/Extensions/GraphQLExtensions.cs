using System;
using System.Collections.Generic;

namespace ProShop.Web.Extensions
{
    public static class GraphQLExtensions
    {
        public static Guid GetId(this IDictionary<string, object> arguments)
            => new Guid((string)arguments["id"]);
    }
}
