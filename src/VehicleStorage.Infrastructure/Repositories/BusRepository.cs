using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class BusRepository : BaseRepository<Bus>, IBusRepository
{
    private readonly StorageDbContext _context;
    private readonly DbSet<Bus> _table;

    public BusRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<Bus>();
    }

    public async Task<IEnumerable<Bus>> GetAllByColourIdAsync(int colorId)
    {
        var vehicleList = await _table
                            .Where(x => x.ColourId == colorId)
                            .Include(i => i.ColourFk)
                            .ToListAsync();
        return vehicleList;
    }

}