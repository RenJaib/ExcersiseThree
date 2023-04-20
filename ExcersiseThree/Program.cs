using ExcersiseThree;
using SomeLagacyLib;

var dog = new Dog("Felix");
var dog2 = new Dog("Ivana");
var dog3 = new Dog("Jessy");

var legacyPikachu = new Pikachu("Pikachu");
var legacyShinx = new Shinx();

var pikachu = new LegacyAnimalAdaptor(legacyPikachu);

var animals = new List<Animal>
{
    dog,
    dog2,
    dog3,
    pikachu,
    new LegacyAnimalAdaptor(legacyShinx)
};

Printer(animals);



void Printer(IEnumerable<Animal> list)
{
    foreach (var animal in list)
    {
        //Console.WriteLine($"animal name is: {animal.Name}");
        Console.WriteLine(animal.Speak());
    }
}