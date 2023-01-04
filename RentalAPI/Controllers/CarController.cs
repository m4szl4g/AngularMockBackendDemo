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
                     Manufacturer = "BMW",
                     Model = "530d",
                     Year = 2020
                },
                new ()
                {
                     Manufacturer = "Peugeot",
                     Model = "206",
                     Year = 2018
                },
                new ()
                {
                     Manufacturer = "Volkswagen",
                     Model = "Polo",
                     Year = 2022
                },
                new ()
                {
                     Manufacturer = "Honda",
                     Model = "Jazz",
                     Year = 2020
                }
            };

            return cars;
        }
    }
}