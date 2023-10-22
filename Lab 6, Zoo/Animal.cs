using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6__Zoo
{
    public abstract class Animal        //Gör klassen abstrakt så att resterande subklasser måste implimentera och ärva metoder och fält
    {
        public string Food; //Samtliga fält skall ävas ner till resterande subklasser
        public int Age;
        public string Name;
        public string Habitat;
        public bool Skate;

        public Animal(string food, int age, string name, string habitat, bool skate)
        {
            Food = food;
            Age = age;
            Name = name;
            Habitat = habitat;
            Skate = skate;            
        }

        public abstract void MakeSound();   //Abstrakta metoder som måste användas ner i ledet
        public static bool DoesItSkate(bool skate)
        {
            Console.WriteLine($"har synts på video åkandes på en skateoard: {skate}");
            return skate; }
            
        public void EatingHabits()  //Metoder som kan användas i resterande program ifall man vill 
        {
            Console.WriteLine($"{Name} gillar att äta {Food}");
        }
        public void Enviroment()
        {
            Console.WriteLine($"{Name} trivs bäst i {Habitat} lever upp till {Age} år beroende på ras");
        }
        public static void Print()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------------" +
                "\n--------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
       
    }
}
