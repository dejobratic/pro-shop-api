using ProShop.Contract.Dtos;
using ProShop.Products.Domain.Models;

namespace ProShop.Products.App.Mappers
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
                LastName = customer.LastName
            };
        }
    }
}
