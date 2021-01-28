using ProShop.Core.UseCases;
using ProShop.Store.App.Mappers;
using ProShop.Store.App.Services;
using ProShop.Store.Contract.Dtos;
using ProShop.Store.Contract.Requests;
using ProShop.Store.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Store.App.UseCases
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
