using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6__Zoo
{
    internal class Tortoise : Animal
    {

       
        public Tortoise(string name, int age, string food, string habitat, bool skate) :base(food, age, name, habitat, skate)
        {
            Age = age;
            Name = name;

        }
        public override void MakeSound()
        {
            Console.WriteLine($"Sköldpaddan har ett litet pipigt ljud");
        }
        public void Reptiles(string habitat)
        {
            if (habitat.ToLower() == "Land")
            {
                Console.WriteLine($"{Name} trivs bäst på land och kan leva upp till {Age} år");
            }
            else
            {
                Console.WriteLine($"{Name} trivs bäst i haven och kan leva upp till {Age} år");
            }
        }
    }
}

