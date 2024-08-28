using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleStorage.Application.Dtos
{
    public class CarDto : VehicleDto
    {
        public bool HeadlightState { get; set; }
    }
}