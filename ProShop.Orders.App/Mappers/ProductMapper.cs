using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Mappers
{
    public static class ProductMapper
    {
        public static Product ToDomainModel(
            this ProductDto product)
        {
            return new Product(
                product.Id,
                product.Name);
        }

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
