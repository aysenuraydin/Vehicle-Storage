
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;

namespace VehicleStorage.Infrastructure.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly StorageDbContext _context;

    public UnitOfWork(StorageDbContext context)
    {
        _context = context;
    }

    private IColourRepository _colourRepository;
    public IColourRepository ColourRepository => _colourRepository ??= new ColourRepository(_context);

    private IVehicleRepository _vehicleRepository;
    public IVehicleRepository VehicleRepository => _vehicleRepository ??= new VehicleRepository(_context);

    private ICarRepository _carRepository;
    public ICarRepository CarRepository => _carRepository ??= new CarRepository(_context);

    private IBusRepository _busRepository;
    public IBusRepository BusRepository => _busRepository ??= new BusRepository(_context);

    private IBoatRepository _boatRepository;
    public IBoatRepository BoatRepository => _boatRepository ??= new BoatRepository(_context);


    public int Commit()
    {
        return _context.SaveChanges();
    }

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}