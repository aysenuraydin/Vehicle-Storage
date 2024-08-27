using System.Linq.Expressions;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Domain.Common;
public interface IRepository<TEntity, TKey> : IDisposable
{
    List<TEntity> GetAll();
    Task<IEnumerable<TEntity>> GetAllAsync();
    List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
    Task<IEnumerable<TEntity?>> GetAllAsync(Expression<Func<TEntity, bool>> expression);
    TEntity? Get(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression);
    TEntity? Find(int id);
    Task<TEntity?> FindAsync(int id);
    int Add(TEntity entity);
    Task<int> AddAsync(TEntity entity);
    int Update(TEntity entity);
    Task<int> UpdateAsync(TEntity entity);
    int Delete(TEntity entity);
    Task<bool> DeleteById(int id);
    Task<int> DeleteAsync(TEntity entity);
    int SaveChanges();
    Task<int> SaveChangesAsync();

}