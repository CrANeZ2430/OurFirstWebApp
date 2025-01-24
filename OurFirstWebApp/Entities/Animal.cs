namespace OurFirstWebApp.Entities;

public class Animal(string name, byte age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
}
