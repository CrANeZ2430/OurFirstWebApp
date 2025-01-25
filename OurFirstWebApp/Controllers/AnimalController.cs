using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using OurFirstWebApp.Entities;

namespace OurFirstWebApp.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    private readonly IAnimalHotel _animalHotel;

    public AnimalController(IAnimalHotel animalHotel)
    {
        _animalHotel = animalHotel;
    }

    [HttpGet]
    public string[] GetAllAnimals()
    {
        var animals = _animalHotel.GetAllAnimals().Select(x => $"{x.Name}, {x.Age}");

        return animals.ToArray();
    }

    [HttpGet("{index}")]
    public string GetAnimal(
        [Required] int index)
    {
        var animal = _animalHotel.GetAnimal(index);
        return $"{animal.Name}, {animal.Age}";
    }

    [HttpPost]
    public IActionResult AddAnimal(
        [Required] string name,
        [Required] byte age)
    {
        _animalHotel.AddAnimal(name, age);

        return Ok("Animal added");
    }

    [HttpPut("{index}")]
    public IActionResult UpdateAnimal(
        [Required] int index,
        [Required] string name,
        [Required] byte age)
    {
        _animalHotel.UpdateAnimal(index, name, age);

        return Ok("Animal updated");
    }


    [HttpDelete("{index}")]
    public IActionResult DeleteAnimal(
        [Required] string index)
    {
        _animalHotel.RemoveAnimal(Convert.ToInt32(index));
        return Ok("Animal removed");
    }
}
