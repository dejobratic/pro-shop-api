using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Contract.Requests;

namespace ProShop.Shopping.App.Tests.Unit.Fakes
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
