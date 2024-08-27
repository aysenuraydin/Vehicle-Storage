using VehicleStorage.Domain.Common;

namespace VehicleStorage.Domain.Entities;
public class Vehicle : BaseEntity<int>, IVehicle
{
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public int ColourId { get; set; }
    public Colour ColourFk { get; set; }

}






