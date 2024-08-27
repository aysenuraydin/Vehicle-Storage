namespace VehicleStorage.Infrastructure.Common
{
    public interface ISeeder
    {
        Task Seed(StorageDbContext context);
    }
}