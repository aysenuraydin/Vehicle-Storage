using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleStorage.Domain.Common
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<int>
    {


    }
}