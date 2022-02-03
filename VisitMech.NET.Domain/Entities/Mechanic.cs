namespace VisitMech.NET.Domain.Entities
{
    public class Mechanic : AuditableEntity
    {
        public int MechanicId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int MechanicalWorkShopId { get; set; }
        public MechanicalWorkShop MechanicalWorkShop { get; set; }
    }
}