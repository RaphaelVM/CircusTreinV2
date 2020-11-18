using System;
using System.Transactions;
using Logic;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Beaver Name = {0} Size = {1}", beaver.GetName(), beaver.GetSize());

            // Create new Animal of type Herbivore and Carnivore

            // Animal size = 1
            Animal beaver = new Herbivore("Beaver", 1);
            Animal koala = new Herbivore("Koala", 1);
            Animal eagle = new Carnivore("Eagle", 1);

            // Animal size = 3
            Animal zebra = new Herbivore("Zebra", 3);
            Animal monkey = new Herbivore("Monkey", 3);
            Animal antilope = new Herbivore("Antilope", 3);
            Animal lion = new Carnivore("Lion", 3);
            Animal tiger = new Carnivore("Tiger", 3);

            // Animal size = 5
            Animal elephant = new Herbivore("Elephant", 5);
            Animal giraffe = new Herbivore("Giraffe", 5);
            Animal grizzlybear = new Carnivore("Grizzlybear", 5);

            // Create instance of Train
            Train train = new Train();

            // Add Animal to train
            train.AddAnimal(beaver);
            train.AddAnimal(koala);
            train.AddAnimal(eagle);
            train.AddAnimal(zebra);
            train.AddAnimal(monkey);
            train.AddAnimal(antilope);
            train.AddAnimal(lion);
            train.AddAnimal(tiger);
            train.AddAnimal(elephant);
            train.AddAnimal(giraffe);
            train.AddAnimal(grizzlybear);

            // Display all animals in seperate wagons
            Console.WriteLine(train.GetAnimalsFromWagon());
        }
    }
}
