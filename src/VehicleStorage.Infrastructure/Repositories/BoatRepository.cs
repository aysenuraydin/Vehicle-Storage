using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class BoatRepository : BaseRepository<Boat>, IBoatRepository
{
    private readonly StorageDbContext _context;
    private readonly DbSet<Boat> _table;

    public BoatRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<Boat>();
    }

    public async Task<IEnumerable<Boat>> GetAllByColourIdAsync(int colorId)
    {
        var vehicleList = await _table
                            .Where(x => x.ColourId == colorId)
                            .Include(i => i.ColourFk)
                            .ToListAsync();
        return vehicleList;
    }
}