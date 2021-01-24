using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Contract.Requests;

namespace ProShop.Orders.App.Tests.Unit.Fakes
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
