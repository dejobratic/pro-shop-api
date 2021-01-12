using ProShop.Contract.Dtos;
using ProShop.Products.Domain.Models;
using System.Linq;

namespace ProShop.Products.App.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToContractModel(
            this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                Category = product.Category,
                Description = product.Description,
                Price = product.Price,
                QuantityInStock = product.QuantityInStock,
                Reviews = product.Reviews.Select(r => r.ToContractModel())
            };
        }
    }
}
