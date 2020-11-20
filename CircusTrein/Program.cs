using System;
using System.Transactions;
using Logic;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Animal of type Herbivore and Carnivore

            // Animal size = 1
            Animal beaver = new Herbivore("Beaver", Size.Small);
            Animal koala = new Herbivore("Koala", Size.Small);
            Animal eagle = new Carnivore("Eagle", Size.Small);

            // Animal size = 3
            Animal zebra = new Herbivore("Zebra", Size.Medium);
            Animal monkey = new Herbivore("Monkey", Size.Medium);
            Animal antilope = new Herbivore("Antilope", Size.Medium);
            Animal lion = new Carnivore("Lion", Size.Medium);
            Animal tiger = new Carnivore("Tiger", Size.Medium);

            // Animal size = 5
            Animal elephant = new Herbivore("Elephant", Size.Large);
            Animal giraffe = new Herbivore("Giraffe", Size.Large);
            Animal grizzlybear = new Carnivore("Grizzlybear", Size.Large);

            // Create instance of Train
            Train train = new Train();

            // Add animals to list
            train.AddAnimalToList(beaver);
            train.AddAnimalToList(koala);
            train.AddAnimalToList(eagle);
            train.AddAnimalToList(zebra);
            train.AddAnimalToList(monkey);
            train.AddAnimalToList(antilope);
            train.AddAnimalToList(lion);
            train.AddAnimalToList(tiger);
            train.AddAnimalToList(elephant);
            train.AddAnimalToList(giraffe);
            train.AddAnimalToList(grizzlybear);

            // Add animals from list to wagon
            train.AddAnimals();

            // Display all animals in seperate wagons
            Console.WriteLine(train.GetAnimalsFromWagon());
        }
    }
}
