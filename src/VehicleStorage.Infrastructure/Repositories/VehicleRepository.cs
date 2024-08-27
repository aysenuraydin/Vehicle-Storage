using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
{
    private readonly StorageDbContext _context;
    private readonly DbSet<Vehicle> _table;

    public VehicleRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<Vehicle>();
    }

    public async Task<IEnumerable<Vehicle>> GetAllByColourIdAsync(int colorId)
    {
        var vehicleList = await _table
                            .Where(x => x.ColourId == colorId)
                            .Include(i => i.ColourFk)
                            .ToListAsync();
        return vehicleList;
    }
}