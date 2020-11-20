using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public enum Size
    {
        Empty = 0,
        Small = 1,
        Medium = 3,
        Large = 5
    }

    public abstract class Animal
    {
        public string name { get; set; }
        public Size size { get; set; }
        

        protected Animal(string animalName, Size animalSize)
        {
            name = animalName;
            size = animalSize;
        }
    }
}