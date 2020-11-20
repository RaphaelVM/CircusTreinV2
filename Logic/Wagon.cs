using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logic
{
    public class Wagon
    {
        private List<Animal> allAnimals;
        private int _size = 10;

        public Wagon()
        {
            allAnimals = new List<Animal>();
        }

        // Returns the wagons' current size
        public int GetSize()
        {
            return _size;
        }

        // Add animal to list and subtract it's size from the wagons' size
        public void AddAnimalToWagon(Animal animal)
        {
            allAnimals.Add(animal);
            _size -= Convert.ToInt32(animal.size);
        }

        // Check if there are other carnivores already, as there can only be one per wagon
        private bool CheckCarnivore()
        {
            // Do it the LINQ way (thanks Bert)
            return allAnimals.FindAll(e => e.GetType() == typeof(Carnivore)).Count > 0;
        }

        // Get the smallest herbivore
        private Herbivore GetSmallestHerbivore()
        {
            Herbivore herbivore = null;

            foreach (Animal animal in allAnimals)
            {
                // Check for herbivores
                if (animal is Herbivore)
                {
                    // If herbivore == null, give it a value
                    if (herbivore == null || animal.size < herbivore.size)
                    {
                        herbivore = (Herbivore)animal;
                    }
                }
            }
            
            return herbivore;
        }

        // Get biggest carnivore
        private Carnivore GetBiggestCarnivore()
        {
            Carnivore carnivore = new Carnivore("", Size.Empty);

            foreach (Animal animal in allAnimals)
            {
                // Check for carnivores
                if (animal is Carnivore)
                {
                    carnivore = (Carnivore)animal;
                    
                    // Break the loop if the biggest carnivore is found
                    break;
                }
            }

            return carnivore;
        }

        // Check if an animal is able to be added to an existing wagon. If that's not the case, add another wagon
        public bool AnimalAddCheck(Animal animal)
        {
            if (_size >= Convert.ToInt32(animal.size))
            {
                // Check if there are other carnivores already
                if (CheckCarnivore()) // There is already a carnivore in the wagon
                {
                    // Get biggest carnivore
                    Animal biggestCarnivore = GetBiggestCarnivore();

                    if (animal.size > biggestCarnivore.size)
                    {
                        return true;
                    }
                }
                else // No carnivore in the wagon
                {
                    // Get smallest herbivore
                    Animal smallestHerbivore = GetSmallestHerbivore();

                    if (smallestHerbivore != null && smallestHerbivore.size > animal.size)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Return all animal names, sizes and types
        public string GetAnimalInfo()
        {
            StringBuilder builder = new StringBuilder();

            foreach (Animal animal in allAnimals)
            {
                builder.Append($"- Name: {animal.name} \r\n - Size: {animal.size} \r\n - Type: {animal.GetType()} \r\n");
            }

            return builder.ToString();
        }

    }
}
