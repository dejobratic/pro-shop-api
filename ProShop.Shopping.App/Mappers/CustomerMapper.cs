using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Domain.Models;

namespace ProShop.Shopping.App.Mappers
{
    public static class CustomerMapper
    {
        public static Customer ToDomainModel(
            this CustomerDto customer)
        {
            return new Customer(
                customer.Id,
                customer.FirstName,
                customer.LastName,
                customer.Orders);
        }

        public static CustomerDto ToContractModel(
            this Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Orders = customer.Orders
            };
        }
    }
}
