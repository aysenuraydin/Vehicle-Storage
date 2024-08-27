using Microsoft.AspNetCore.Mvc;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.WebApi.Controllers
{
    public class BoatController : AppController
    {
        private readonly ILogger<BoatController> _logger;
        private readonly IBoatService _boatService;

        public BoatController(ILogger<BoatController> logger, IBoatService boatService)
        {
            _logger = logger;
            _boatService = boatService;
        }

        [HttpGet("GetAllBoats")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _boatService.GetAllWithColourNameAsync();

            return Ok(customers);
        }
        [HttpGet("GetAllBoatsByColour/{colorName}")]
        public async Task<IActionResult> GetAllByColourAsync(string colorName)
        {
            var list = await _boatService.GetAllByColourNameAsync(colorName); //listeyi aldık

            if (list == null || list.Count() == 0) return NotFound("Color or vehiche not found");

            return Ok(list);
        }
    }
}