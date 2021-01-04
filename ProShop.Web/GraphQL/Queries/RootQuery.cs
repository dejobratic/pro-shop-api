using GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery :
        ObjectGraphType
    {
        protected readonly IServiceProvider _provider;

        public RootQuery(
            IServiceProvider provider)
        {
            _provider = provider;

            Name = "RootQuery";

            InitializeProductQuery();
            InitializeUserQuery();
            InitializeOrderQuery();
        }
    }
}
