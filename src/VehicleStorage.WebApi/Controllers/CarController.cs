using Microsoft.AspNetCore.Mvc;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.WebApi.Controllers
{
    public class CarController : AppController
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;

        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet("GetAllCars")]
        public async Task<IActionResult> Get()
        {
            var customers = await _carService.GetAllAsync();

            return Ok(customers);
        }
        [HttpGet("GetAllCarsByColour/{colorName}")]
        public async Task<IActionResult> GetAllByColourAsync(string colorName)
        {
            var list = await _carService.GetAllByColourNameAsync(colorName); //listeyi aldık

            if (list == null || list.Count() == 0) return NotFound("Color or vehiche not found");

            return Ok(list);
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