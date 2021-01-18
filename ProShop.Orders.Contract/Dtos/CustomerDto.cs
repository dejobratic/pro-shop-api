using System;
using System.Collections.Generic;

namespace ProShop.Orders.Contract.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
