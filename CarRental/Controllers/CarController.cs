using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]/api/")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CarResponse> Get()
        {
            _logger.LogInformation("Getting cars...");
            var cars = GetCars();
            return cars;
        }

        private IEnumerable<CarResponse> GetCars()
        {
            List<CarResponse> cars = new()
            {
                new ()
                {
                     Name = "BMW",
                     Type = "530d",
                     Year = 2020
                },
                new ()
                {
                     Name = "Peugeot",
                     Type = "206",
                     Year = 2018
                },
                new ()
                {
                     Name = "Volkswagen",
                     Type = "Polo",
                     Year = 2022
                },
                new ()
                {
                     Name = "Honda",
                     Type = "Jazz",
                     Year = 2020
                }
            };

            return cars;
        }
    }
}