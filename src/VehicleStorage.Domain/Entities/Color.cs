using VehicleStorage.Domain.Common;

namespace VehicleStorage.Domain.Entities
{
    public class Colour : BaseEntity
    {
        public string ColorName { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}