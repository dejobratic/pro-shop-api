using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;
using System.Linq;

namespace ProShop.Orders.App.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerDto ToContractModel(
            this Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Orders = customer.Orders?.Select(o => o.ToContractModel())
            };
        }
    }
}
