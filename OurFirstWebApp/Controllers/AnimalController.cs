using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using OurFirstWebApp.Entities;

namespace OurFirstWebApp.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalHotel s_animalHotel;

        public AnimalController(IAnimalHotel animalHotel)
        {
            s_animalHotel = animalHotel;
        }

        [HttpGet]
        public string[] GetAllAnimals()
        {
            var animals = s_animalHotel.GetAllAnimals().Select(x => $"{x.Name}, {x.Age}");

            return animals.ToArray();
        }

        [HttpGet("{index}")]
        public string GetAnimal(
            [Required] int index)
        {
            var animal = s_animalHotel.GetAnimal(index);
            return $"{animal.Name}, {animal.Age}";
        }

        [HttpPost]
        public IActionResult AddAnimal(
            [Required] string name,
            [Required] byte age)
        {
            s_animalHotel.AddAnimal(name, age);

            return Ok("Animal added");
        }

        [HttpPut]
        public IActionResult UpdateAnimal(
            [Required] int index,
            [Required] string name,
            [Required] byte age)
        {
            var animal = s_animalHotel.GetAnimal(index);
            s_animalHotel.UpdateAnimal(index, name, age);

            return Ok("Animal updated");
        }


        [HttpDelete]
        public IActionResult DeleteAnimal(
            [Required] string index)
        {
            s_animalHotel.RemoveAnimal(Convert.ToInt32(index));
            return Ok("Animal removed");
        }
    }
}
