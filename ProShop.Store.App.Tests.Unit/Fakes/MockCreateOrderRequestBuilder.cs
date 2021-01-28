using ProShop.Store.Contract.Dtos;
using ProShop.Store.Contract.Requests;

namespace ProShop.Store.App.Tests.Unit.Fakes
{
    public static class MockCreateOrderRequestBuilder
    {
        public static CreateOrderRequest Build(
            OrderDto order = null)
        {
            return new CreateOrderRequest
            {
                Order = order ?? MockOrderDtoBuilder.Build()
            };
        }
    }
}
