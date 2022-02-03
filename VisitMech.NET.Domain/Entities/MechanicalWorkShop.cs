using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitMech.NET.Domain.Entities
{
    public class MechanicalWorkShop : AuditableEntity
    {
        public int MechanicalWorkShopId { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<Mechanic> Mechanic { get; set; }
    }
}
