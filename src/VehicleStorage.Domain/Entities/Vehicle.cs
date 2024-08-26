using VehicleStorage.Domain.Common;

namespace VehicleStorage.Domain.Entities;

public class Vehicle : BaseEntity
{
    public string? Name { get; set; }
    public Colour? Color { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

}








