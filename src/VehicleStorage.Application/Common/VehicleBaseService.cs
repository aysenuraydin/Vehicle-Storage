
using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;

namespace VehicleStorage.Domain.Common
{
    public class VehicleBaseService<TEntity, TKey> : BaseService<TEntity, TKey>
    where TEntity : class, IEntity<TKey>
    {
        IRepository<TEntity, TKey> _repository;
        private readonly IColourRepository _colourRepository;

        public VehicleBaseService(IColourRepository colourContext, IRepository<TEntity, TKey> repository) : base(repository)
        {
            _repository = repository;
            _colourRepository = colourContext;
        }
        /*        
        public async Task<IEnumerable<VehicleDto>> GetAllByColourNameAsync(string colorName)
        {
            // repoları kullanıcak ,liste dönücek
            var colourId = await _colourRepository.GetIdAsync(colorName); //colour id i al

            //id e göre aracları listele
            var list = await _repository.GetAllByColourIdAsync(colourId); //colour id göre filtreleyerek al

            return list.Select(x => VehicleListToDTO(x)).ToList();
        }
        private static VehicleDto VehicleListToDTO(Vehicle p)
        {
            VehicleDto entity = new();
            if (p != null)
            {
                entity.Id = p.Id;
                entity.Name = p.Name;
                entity.CreatedDate = p.CreatedDate;
                entity.ColourName = p.ColourFk.ColorName;
            }
            return entity;
        }
        */
    }
}