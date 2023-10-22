using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6__Zoo
{
    internal class Cat : Animal
    {
        public bool Nocturnal;
        

        public Cat(string name, int age, string food, string habitat, bool skate, bool nocturnal) :base(food, age, name, habitat, skate)
        {
          
        }
        
        public override void MakeSound()
        {
            Console.WriteLine($"Katten låter 'Mjau' och ibland kan den spinna och då låter den 'prrrrrrrrrrrrrr'");
        }
       

        public void Nightvison(bool Nocturnal)
        {
            Console.WriteLine($"Katten är natt aktiv: {Nocturnal}");
        }
    }
}
