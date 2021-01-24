using GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Queries
{
    public partial class RootQuery :
        ObjectGraphType
    {
        private readonly IServiceProvider _provider;

        public RootQuery(
            IServiceProvider provider)
        {
            _provider = provider;

            Name = "RootQuery";

            InitializeProductQuery();
            InitializeAuthQuery();
            InitializeOrderQuery();
        }
    }
}
