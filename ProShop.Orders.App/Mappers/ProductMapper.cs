using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToContractModel(
            this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
