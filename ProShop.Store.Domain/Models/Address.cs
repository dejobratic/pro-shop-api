namespace ProShop.Store.Domain.Models
{
    public class Address
    {
        public string StreetLine1 { get; }
        public string StreetLine2 { get; }
        public string City { get; }
        public string StateOrProvince { get; }
        public string PostalCode { get; }
        public string Country { get; }

        public Address(
            string streetLine1,
            string streetLine2,
            string city,
            string stateOrProvince,
            string postalCode,
            string country)
        {
            StreetLine1 = streetLine1;
            StreetLine2 = streetLine2;
            City = city;
            StateOrProvince = stateOrProvince;
            PostalCode = postalCode;
            Country = country;
        }
    }
}
