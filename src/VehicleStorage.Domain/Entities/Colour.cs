using VehicleStorage.Domain.Common;

namespace VehicleStorage.Domain.Entities
{
    public class Colour : BaseEntity
    {
        public string ColorName { get; set; }

        public List<Vehicle> Products { get; set; } = new();
    }
}