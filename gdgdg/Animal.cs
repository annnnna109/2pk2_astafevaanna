using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace gdgdg
{
    public enum Areal { Plain, Tropics, Taiga, Desert}
    internal class Animal
    {
        public string type;
        private DateOnly dateOfBirth;
        public string DateOnly dateOfBirth;
        public Areal areal;

        public  Animal(string type, DateOnly dateOfBirth, Areal areal)
        {
            this.type = type;
            this.dateOfBirth = dateOfBirth;
            this.areal = areal;
        }
        public Animal() { }

        public void PrintInfo() 
        {
            Console.WriteLine($"Животное:{type}, дата рождение: {dateOfBirth}, ареал: {areal}");
        }
        private innt GetAge
    }
}

