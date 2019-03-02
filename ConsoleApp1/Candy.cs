using System;

namespace ClassesExample
{
    class Candy
    {
        //Properties
        public string Flavor { get; set; }
        public int Rating { get; private set; }
        public string Name { get; set; }
        public CandyType Type { get; set; }

        //Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        //Constructor
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        //Methods
        // void is a return type. with a void, you can't return anything.
        public void SetRating(int userRating)
        {
            // needs to be bwtween 1-10
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}, you moron.");
            }
        }

        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of it's aight.";
        }
    }

    enum CandyType
    {
        Chocolate,
        HardCandy,
        Carmel,
        Sour,
        Stretchy,
        Nut
    }
}
