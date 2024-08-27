using VehicleStorage.Domain.Common;

namespace VehicleStorage.Domain.Entities;
public interface IVehicle : IEntity<int>
{
    string Name { get; set; }
    DateTime CreatedDate { get; set; }
    int ColourId { get; set; }
    Colour ColourFk { get; set; }
}






