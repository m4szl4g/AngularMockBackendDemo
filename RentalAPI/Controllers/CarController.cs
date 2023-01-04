using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<CarResponse> Get()
        {
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