namespace OurFirstWebApp.Entities;

public class AnimalHotel : IAnimalHotel
{
    private readonly List<Animal> _animalHotel = [
        new Animal("Barsik", 2),
        new Animal("Ginger", 3),
        new Animal("Moony", 4)];

    public IEnumerable<Animal> GetAllAnimals()
    {
        return _animalHotel;
    }

    public Animal GetAnimal(int index)
    {
        return _animalHotel[index];
    }

    public void AddAnimal(string name, byte age)
    {
        _animalHotel.Add(new Animal(name, age));
    }

    public void UpdateAnimal(int index, string name, byte age)
    {
        _animalHotel[index] = new Animal(name, age);
    }

    public void RemoveAnimal(int index)
    {
        _animalHotel.RemoveAt(index);
    }
}
