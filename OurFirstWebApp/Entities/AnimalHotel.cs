using OurFirstWebApp.Models;

namespace OurFirstWebApp.Entities;

public class AnimalHotel : IAnimalHotel
{
    private static readonly List<Animal> s_animalHotel = [
        new Animal("Barsik", 2),
        new Animal("Ginger", 3),
        new Animal("Moony", 4)];

    public IEnumerable<Animal> GetAllAnimals()
    {
        return s_animalHotel;
    }

    public Animal GetAnimal(int index)
    {
        return s_animalHotel[index];
    }

    public void AddAnimal(string name, byte age)
    {
        s_animalHotel.Add(new Animal(name, age));
    }

    public void UpdateAnimal(int index, string name, byte age)
    {
        s_animalHotel[index] = new Animal(name, age);
    }

    public void RemoveAnimal(int index)
    {
        s_animalHotel.RemoveAt(index);
    }
}
