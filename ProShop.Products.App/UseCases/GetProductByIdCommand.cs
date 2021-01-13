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
        private readonly IProductRepository _repo;

        public GetProductByIdCommand(
            GetProductByIdRequest request,
            IProductRepository repo)
        {
            _request = request;
            _repo = repo;
        }

        public async Task<ProductDto> Execute()
        {
            Product product = await _repo.Get(_request.ProductId);
            return product.ToContractModel();
        }
    }
}
