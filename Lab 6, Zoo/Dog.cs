using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6__Zoo
{
    internal class Dog : Animal
    {
        public bool Fetch;

        public Dog(string name, int age, string food, string habitat, bool skate, bool fetch) : base(food, age, name, habitat, skate)
        { 

        } 
        

        public override void MakeSound()
        {
            Console.WriteLine($"hunden låter 'Woff' och ibland kan den yla och då låter den 'AAAOOOOOOOOWWWWWWWWWW'");
        }

        
        public bool DoesItFetch(bool fetch)
        {
            Console.WriteLine($"Hundar är kända för att leka leken apport: {fetch}");
            return Fetch;
        }
       

    }
}
