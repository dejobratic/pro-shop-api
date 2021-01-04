﻿using ProShop.Contract.Dtos;
using ProShop.Core.Tests.Unit.Fakes;
using System;

namespace ProShop.App.Tests.Unit.Fakes
{
    public static class MockUserDtoBuilder
    {
        public static UserDto Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName")
        {
            return new UserDto
            {
                Id = id ?? GuidProvider.UserId,
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}