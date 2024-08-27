namespace VehicleStorage.Domain.Common
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    public interface IEntity : IEntity<int>
    {
        public int Id { get; set; }
    }
}