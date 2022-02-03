using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitMech.NET.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
