using ProShop.Core.UseCases;
using ProShop.Shopping.App.Mappers;
using ProShop.Shopping.App.Services;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Contract.Requests;
using ProShop.Shopping.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.UseCases
{
    public class GetOrdersByCustomerIdCommand :
        ICommand<IEnumerable<OrderDto>>
    {
        private readonly GetOrdersByCustomerIdRequest _request;
        private readonly IOrderRepository _orderRepo;

        public GetOrdersByCustomerIdCommand(
            GetOrdersByCustomerIdRequest request,
            IOrderRepository orderRepo)
        {
            _request = request;
            _orderRepo = orderRepo;
        }

        public async Task<IEnumerable<OrderDto>> Execute()
        {
            IEnumerable<Order> orders = await _orderRepo
                .GetByCustomerId(_request.CustomerId);

            return orders.Select(o => o.ToContractModel());
        }
    }
}
