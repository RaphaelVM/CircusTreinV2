using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Train
    {
        private List<Wagon> allWagons;
        private List<Animal> Animals;

        public Train()
        {
            allWagons = new List<Wagon>();
            Animals = new List<Animal>();
        }

        // Add animal to list
        public void AddAnimalToList(Animal animal)
        {
            Animals.Add(animal);
        }

        // Add animals from list to wagon
        public void AddAnimals()
        {
            foreach (Animal animal in Animals)
            {
                AddAnimal(animal);
            }
        }

        // Add animal to wagon
        public void AddAnimal(Animal animal)
        {
            Wagon wagon = null;

            foreach (Wagon _wagon in allWagons)
            {
                // Check if we can add the current animal in an existing wagon
                if (_wagon.AnimalAddCheck(animal))
                {
                    wagon = _wagon;

                    // Break the loop if the animal can be added
                    break;
                }
            }

            // Create a new wagon if the animal could not be added
            if (wagon == null)
            {
                wagon = new Wagon();
                allWagons.Add(wagon);
            }

            wagon.AddAnimalToWagon(animal);
        }

        // Return all animals per container in a formatted manner
        public string GetAnimalsFromWagon()
        {
            StringBuilder builder = new StringBuilder();

            // Start int i on 1, because wagon 0 is weird
            for (int i = 1; i < allWagons.ToList().Count; i++)
            {
                Wagon wagon = allWagons.ToList()[i];

                builder.AppendLine($"Wagon {i} contains: \r\n {wagon.GetAnimalInfo()} The remaining size is: {wagon.GetSize()} \r\n");
            }

            return builder.ToString();
        }
    }
}
