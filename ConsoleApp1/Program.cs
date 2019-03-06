using ClassesExample.Legos;
using ClassesExample.Legos.Heads;
using ClassesExample.Legos.Legs;
using ClassesExample.Legos.Torsos;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var taffy = new Candy();
            //taffy.Flavor = "Orange";
            //taffy.Name = "Orange Saltwater Taffy";
            //taffy.Rating = 5;
            //taffy.Type = CandyType.Stretchy;

            //var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);
            //taffy.SetRating(4);

            //Console.WriteLine(taffy);

            var myDogHead = new Dog();

            myDogHead.Talk();

            var baldyHead = new Bald();
            var astronaut = new Astronaut();

            var fitTorso = new FitTorso(2,Sex.Male, Legos.Colors.Freckles);
            fitTorso.Crunch(12);

            var adamsLegs = new OrangeLegs(Length.Short);

            var minifigure = new MiniFigure("Adam", astronaut, fitTorso, adamsLegs);
            minifigure.Greet();

            Console.ReadLine();
        }
    }
}
