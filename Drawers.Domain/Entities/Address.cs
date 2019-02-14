namespace Drawers.Domain.Entities
{
    public class Address
    {
        public string AddressLine { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}