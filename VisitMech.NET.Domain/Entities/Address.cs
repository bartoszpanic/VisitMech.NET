namespace VisitMech.NET.Domain.Entities
{
    public class Address : AuditableEntity
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}