using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class ColourRepository : BaseRepository<Colour>, IColourRepository
{
    private readonly StorageDbContext _context;
    private readonly DbSet<Colour> _table;

    public ColourRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<Colour>();
    }

    public async Task<int> GetIdAsync(string colorName)
    {
        var colour = await _table.FirstOrDefaultAsync(x => x.ColorName.ToLower() == colorName.ToLower());
        if (colour == null) return 0;
        return colour.Id;
    }
}