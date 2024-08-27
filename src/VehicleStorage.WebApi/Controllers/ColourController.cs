using Microsoft.AspNetCore.Mvc;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.WebApi.Controllers
{
    public class ColourController : AppController
    {
        private readonly ILogger<ColourController> _logger;
        private readonly IColourService _colourService;

        public ColourController(ILogger<ColourController> logger, IColourService colourService)
        {
            _logger = logger;
            _colourService = colourService;
        }

        [HttpGet("GetAllColours")]
        public async Task<IActionResult> Get()
        {
            var customers = await _colourService.GetAllAsync();

            return Ok(customers);
        }
    }
}