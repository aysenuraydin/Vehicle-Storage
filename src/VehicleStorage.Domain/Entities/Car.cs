using VehicleStorage.Domain.Enums;

namespace VehicleStorage.Domain.Entities
{
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        public HeadlightStatus Headlights { get; set; }
    }
}