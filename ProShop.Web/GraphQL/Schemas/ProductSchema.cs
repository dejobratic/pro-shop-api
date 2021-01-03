﻿using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using ProShop.Web.GraphQL.Queries;
using System;

namespace ProShop.Web.GraphQL.Schemas
{
    public class ProductSchema :
        Schema,
        ISchema
    {
        public ProductSchema(
            IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<ProductQuery>();
        }
    }
}
