using Microsoft.AspNetCore.Mvc;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.WebApi.Controllers
{
    public class BusController : AppController
    {
        private readonly ILogger<BusController> _logger;
        private readonly IBusService _busService;

        public BusController(ILogger<BusController> logger, IBusService busService)
        {
            _logger = logger;
            _busService = busService;
        }

        [HttpGet("GetAllBuses")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _busService.GetAllWithColourNameAsync();

            return Ok(customers);
        }
        [HttpGet("GetAllBusesByColour/{colorName}")]
        public async Task<IActionResult> GetAllByColourAsync(string colorName)
        {
            var list = await _busService.GetAllByColourNameAsync(colorName); //listeyi aldık

            if (list == null || list.Count() == 0) return NotFound("Color or vehiche not found");

            return Ok(list);
        }
    }
}