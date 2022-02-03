using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitMech.NET.Domain.Entities
{
    public class Vehicle : AuditableEntity
    {
        public int VehicleId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int EngineCapcity { get; set; }
        public string VIN { get; set; }
    }
}
