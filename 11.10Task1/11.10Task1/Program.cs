using _11._10Task1.Models;

namespace _11._10Task1;
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Disi");
        Dog dog = new Dog("Erkek","Labrador","Leo");

        Console.WriteLine($"Tarix: {dog.BirthDate}  Gender: {dog.Gender}  Cins: {dog.Breed}  Ad: {dog.Name}");

    }
}

