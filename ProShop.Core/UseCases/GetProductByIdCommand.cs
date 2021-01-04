using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.Mappers;
using ProShop.Core.Models;
using ProShop.Core.Services;
using System.Threading.Tasks;

namespace ProShop.Core.UseCases
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
