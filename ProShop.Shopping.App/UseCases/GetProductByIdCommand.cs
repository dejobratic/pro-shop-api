using ProShop.Core.UseCases;
using ProShop.Shopping.App.Mappers;
using ProShop.Shopping.App.Services;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Contract.Requests;
using ProShop.Shopping.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.UseCases
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
