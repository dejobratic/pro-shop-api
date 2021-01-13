using ProShop.Core.UseCases;
using ProShop.Products.App.Mappers;
using ProShop.Products.App.Services;
using ProShop.Products.Contract.Dtos;
using ProShop.Products.Contract.Requests;
using ProShop.Products.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProShop.Products.App.UseCases
{
    public class GetAllProductsCommand :
        ICommand<IEnumerable<ProductDto>>
    {
        private readonly GetAllProductsRequest _request; // Will be used for specifications (page number, number of products per page...)
        private readonly IProductRepository _productRepo;

        public GetAllProductsCommand(
            GetAllProductsRequest request,
            IProductRepository productRepo)
        {
            _request = request;
            _productRepo = productRepo;
        }

        public async Task<IEnumerable<ProductDto>> Execute()
        {
            IEnumerable<Product> products =
                await _productRepo.GetAll();

            return products.Select(p => p.ToContractModel());
        }
    }
}
