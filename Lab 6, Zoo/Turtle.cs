using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6__Zoo
{
    internal class Turtle : Tortoise
    {
        private string Weapon { get; set; }
        public Turtle(string name, int age, string food, string habitat, bool skate, string weapon) : base(name, age, food, habitat, skate)
        {
            Weapon = weapon;
            Name = name;
           
        }
        public override void MakeSound()
        {
            Console.WriteLine($"medlemmen i teenage mutant ninja turtles {Name} talar som en människa om inte den " +
                $"använder sin älsklingsfras COWABUNGA");
        }
        public void WeaponOfChoice()
        {
            Console.WriteLine($"den kända {Name} använder {Weapon}");
        }


    }
}
