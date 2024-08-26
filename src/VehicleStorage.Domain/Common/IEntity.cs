using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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