﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.App.Services;
using ProShop.App.UseCases;
using ProShop.Contract;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using System;
using System.Collections.Generic;

namespace ProShop.Core.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class ProductCommandFactoryTests
    {
        private ProductCommandFactory _sut;

        [TestInitialize]
        public void Initialize()
        {
            CreateSut();
        }

        [TestMethod]
        public void Create_without_return_type_should_throw_exception()
        {
            Action action = ()
                => _sut.Create(new object() as IRequest);

            action.Should().Throw<NotImplementedException>();
        }

        [TestMethod]
        public void Create_with_return_type_should_create_GetProductByIdCommand()
        {
            var request = new GetProductByIdRequest();

            ICommand<ProductDto> actual = _sut.Create<ProductDto>(request);
            actual.Should().BeOfType(typeof(GetProductByIdCommand));
        }        
        
        [TestMethod]
        public void Create_with_return_type_should_create_GetAllProductsCommand()
        {
            var request = new GetAllProductsRequest();

            ICommand<IEnumerable<ProductDto>> actual = _sut.Create<IEnumerable<ProductDto>>(request);
            actual.Should().BeOfType(typeof(GetAllProductsCommand));
        }


        [TestMethod]
        public void Create_with_return_type_should_throw_exception_when_called_with_unsupported_request()
        {
            Action action = ()
                => _sut.Create<object>(new object() as IRequest);

            action.Should().Throw<Exception>()
                .WithMessage("Unable to create product command.");
        }

        private void CreateSut()
        {
            _sut = new ProductCommandFactory(
                new FakeProductRepository());
        }
    }
}