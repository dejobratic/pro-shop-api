using GraphQL.Types;
using System;

namespace ProShop.Web.GraphQL.Mutations
{
    public partial class RootMutation :
        ObjectGraphType
    {
        private readonly IServiceProvider _provider;

        public RootMutation(
            IServiceProvider provider)
        {
            _provider = provider;

            Name = "RootMutation";

            InitializeUserMutation();
        }
    }
}
