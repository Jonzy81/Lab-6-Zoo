using System.Runtime.InteropServices;

namespace Lab_6__Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonny Touma Net23 uppgift 06 OOP arv.

            Cat cats = new Cat("puss", 12, "Möss", "det vilda eller tam", true, true);// skriver in värden till konstruktor
            cats.Enviroment();//Metoder skapta i basklass för att undvika upprepning av kod 
            cats.EatingHabits();
            cats.MakeSound();//Kallar på metoder från klassen
            Animal.DoesItSkate(true); //kallar på metoder från basklassen
            cats.Nightvison(true);
            Animal.Print();


            Dog dogs = new Dog("Lassie", 15, "hundmat och hundben", "det tämjda", true, true);
            dogs.Enviroment();
            dogs.EatingHabits();
            dogs.MakeSound();
            Animal.DoesItSkate(true);
            dogs.DoesItFetch(true);
            Animal.Print();

            Tortoise turtle = new Tortoise("Geochelone elephantopus", 120, "Grönsaker", "land", false);
            turtle.Enviroment();
            turtle.EatingHabits();
            turtle.MakeSound();
            Animal.DoesItSkate(false);
            turtle.Reptiles("land");
            Animal.Print();

            Tortoise turtle2 = new Tortoise("Chelonioidea", 100, "sjögräs, alger och bläckfiskar", "de tropiska haven", false);
            turtle2.Enviroment();
            turtle2.EatingHabits();
            turtle2.MakeSound();
            Animal.DoesItSkate(false);
            turtle2.Reptiles("");
            Animal.Print();

            Turtle teen = new Turtle("Leonardo", 16, "pepperoni Pizza", "kloakerna", true, "Katanas");
            teen.Enviroment();
            teen.EatingHabits();
            teen.MakeSound();
            Animal.DoesItSkate(true);
            teen.WeaponOfChoice();
            Animal.Print();

            Turtle1 teen1 = new Turtle1("Michelangelo", 16, "caprichosa Pizza", "kloakerna", true, "nunchucks");
            teen1.Enviroment();
            teen1.EatingHabits();
            teen1.MakeSound();
            Animal.DoesItSkate(true);
            teen1.WeaponOfChoice();
            Animal.Print();
        }
    }
}