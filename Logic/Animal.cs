using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public abstract class Animal
    {
        // Properties
        private readonly string _name;
        // Maybe add enum
        private readonly int _size;

        protected Animal(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public int GetSize()
        {
            return _size;
        }

        public string GetName()
        {
            return _name;
        }
    }
}