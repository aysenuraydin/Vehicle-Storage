using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class ColourRepository : BaseRepository<Colour>, IColourRepository
{
    private readonly StorageDbContext _context;

    public ColourRepository(StorageDbContext context) : base(context)
    {
        _context = context;
    }
    //farları ac kapa
}