﻿using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Users.Contract.Dtos;
using System;

namespace ProShop.Users.App.Tests.Unit.Fakes
{
    public static class MockUserDtoBuilder
    {
        public static UserDto Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            string email = "FirstName.LastName@example.com")
        {
            return new UserDto
            {
                Id = id ?? GuidProvider.UserId,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };
        }
    }
}