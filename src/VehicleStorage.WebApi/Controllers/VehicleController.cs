using System;
using Microsoft.AspNetCore.Mvc;
using VehicleStorage.Repository.Domain;
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
        public async Task<IActionResult> GetAll()
        {
            var customers = await _vehicleService.GetAllAsync();

            return Ok(customers);
        }
        [HttpGet("GetAllVehicleByColour/{colorName}")]
        public async Task<IActionResult> GetAllByColourAsync(string colorName)
        {
            var list = await _vehicleService.GetAllByColourNameAsync(colorName); //listeyi aldık

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