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

            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);
            taffy.SetRating(4);

            Console.WriteLine(taffy);

            Console.WriteLine(taffy.Rating);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
