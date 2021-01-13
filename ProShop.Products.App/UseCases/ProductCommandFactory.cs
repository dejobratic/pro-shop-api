using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using ProShop.Products.App.Services;
using ProShop.Products.Contract.Requests;
using System;

namespace ProShop.Products.App.UseCases
{
    public class ProductCommandFactory :
        IProductCommandFactory
    {
        private readonly IProductRepository _productRepo;

        public ProductCommandFactory(
            IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public ICommand Create(IRequest request)
        {
            throw new NotImplementedException();
        }

        public ICommand<T> Create<T>(IRequest request)
        {
            switch (request)
            {
                case GetProductByIdRequest getProductByIdRequest:
                    return new GetProductByIdCommand(
                        getProductByIdRequest,
                        _productRepo) as ICommand<T>;

                case GetAllProductsRequest getAllProductsRequest:
                    return new GetAllProductsCommand(
                        getAllProductsRequest,
                        _productRepo) as ICommand<T>;

                default:
                    throw new Exception("Unable to create product command.");
            }
        }
    }
}
