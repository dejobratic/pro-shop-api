using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Web.GraphQL.Queries;
using System;

namespace ProShop.Web.GraphQL.Schemas
{
    public class RootSchema :
        Schema,
        ISchema
    {
        public RootSchema(
            IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<RootQuery>();
        }
    }
}
