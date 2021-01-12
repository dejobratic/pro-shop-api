using System;

namespace ProShop.Core.Tests.Unit.Helpers
{
    public static class GuidProvider
    {
        public static readonly Guid ProductId
            = new Guid("3EFC11BE-6652-4E62-A353-0E781504CCA4");

        public static readonly Guid ProductReviewId
            = new Guid("89509919-F9C0-4FD8-9A1E-B76F475D8581");

        public static readonly Guid UserId
            = new Guid("782B62FA-D26E-469D-8E1C-BED76689C72B");

        public static readonly Guid OrderId
            = new Guid("E639CC7D-7590-4BCF-8623-D9F86F0E23AF");

        public static readonly Guid OrderItemId
            = new Guid("D59DC048-BED2-4FCB-8C96-B7211FFF6499");
    }
}
