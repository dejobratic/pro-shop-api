using ProShop.Core.UseCases;
using ProShop.Products.App.Mappers;
using ProShop.Products.App.Services;
using ProShop.Products.Contract.Dtos;
using ProShop.Products.Contract.Requests;
using ProShop.Products.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Products.App.UseCases
{
    public class GetProductByIdCommand :
        ICommand<ProductDto>
    {
        private readonly GetProductByIdRequest _request;
        private readonly IProductRepository _productRepo;

        public GetProductByIdCommand(
            GetProductByIdRequest request,
            IProductRepository productRepo)
        {
            _request = request;
            _productRepo = productRepo;
        }

        public async Task<ProductDto> Execute()
        {
            Product product = await _productRepo.Get(_request.ProductId);
            return product.ToContractModel();
        }
    }
}
