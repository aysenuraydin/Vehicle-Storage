
using AutoMapper;
using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;

namespace VehicleStorage.Domain.Common
{
    public class VehicleBaseService<TEntity, TKey> : BaseService<TEntity, TKey>, IServiceForVehicle<TEntity, TKey>
    where TEntity : class, IVehicle
    {
        IRepositoryForVehicle<TEntity, TKey> _vehicleRepository;
        private readonly IColourRepository _colourRepository;
        private readonly IMapper _mapper;

        public VehicleBaseService(IColourRepository colourContext, IRepository<TEntity, TKey> repository, IRepositoryForVehicle<TEntity, TKey> vehicleRepository, IMapper mapper) : base(repository)
        {
            _vehicleRepository = vehicleRepository;
            _colourRepository = colourContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDto>> GetAllWithColourNameAsync()
        {
            var list = await _vehicleRepository.GetAllIncludeAsync(i => i.ColourFk);
            return _mapper.Map<IEnumerable<VehicleDto>>(list);
        }

        public async Task<IEnumerable<VehicleDto>> GetAllByColourNameAsync(string colorName)
        {
            var colourId = await _colourRepository.GetIdAsync(colorName);
            var list = await _vehicleRepository.GetAllByColourIdAsync(colourId);
            return _mapper.Map<IEnumerable<VehicleDto>>(list);
        }
    }
}