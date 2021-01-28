using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;

namespace ProShop.Store.App.Mappers
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
