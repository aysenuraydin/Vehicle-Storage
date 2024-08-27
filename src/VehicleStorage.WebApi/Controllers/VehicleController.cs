using Microsoft.AspNetCore.Mvc;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.WebApi.Controllers
{
    public class VehicleController : AppController
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVehicleService _vehicleService;

        public VehicleController(ILogger<VehicleController> logger, IVehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        [HttpGet("GetAllVehicles")]
        public async Task<IActionResult> Get()
        {
            var customers = await _vehicleService.GetAllAsync();

            return Ok(customers);
        }
        /*
            [HttpGet("{id}")]
            public async Task<IActionResult> Get(int id)
            {
                var customer = await _carService.GetById(id);

                return Ok(customer);
            }
            [HttpPost]
            public async Task<IActionResult> Post(CreateOrUpdateCustomerDto customer)
            {
                await _carService.Create(customer);

                return Ok(customer.Id);
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> Put(int id, CreateOrUpdateCustomerDto customer)
            {
                if (id == customer.Id)
                {
                    await _carService.Update(customer);
                }
                return Ok(customer.Id);
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                await _carService.Delete(id);

                return Ok();
            }
        */
    }
}