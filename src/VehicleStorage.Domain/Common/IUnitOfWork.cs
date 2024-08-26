

using VehicleStorage.Repository.Domain;

namespace VehicleStorage.Domain.Common;

public interface IUnitOfWork : IDisposable
{
    IColourRepository ColourRepository { get; }
    IVehicleRepository VehicleRepository { get; }
    ICarRepository CarRepository { get; }
    IBusRepository BusRepository { get; }
    IBoatRepository BoatRepository { get; }

    int Commit();

    Task<int> CommitAsync();
}