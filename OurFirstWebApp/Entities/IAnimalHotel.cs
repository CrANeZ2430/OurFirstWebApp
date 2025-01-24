namespace OurFirstWebApp.Entities;

public interface IAnimalHotel
{
    IEnumerable<Animal> GetAllAnimals();
    Animal GetAnimal(int index);
    void AddAnimal(string name, byte age);
    void UpdateAnimal(int index, string name, byte age);
    void RemoveAnimal(int index);
}