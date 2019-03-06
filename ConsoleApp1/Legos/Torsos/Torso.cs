using ClassesExample.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Torsos
{
    abstract class Torso
    {
        //Properties
        public int NumberOfArms { get; protected set; }
        public string FitnessOfAbdomen { get; protected set; }
        public Sex Sex { get; protected set; }
        public Colors Color { get; protected set; }

        protected Torso(int numberOfArms, Sex sex, Colors color, string fitnessOfAbdomen)
        {
            NumberOfArms = numberOfArms;
            Sex = sex;
            Color = color;
            FitnessOfAbdomen = fitnessOfAbdomen;
        }

        //Methods
        public virtual void Wave()
        {
            Console.WriteLine("Waves hello O/");
        }
    }
    
    internal enum Sex
    {
        Male,
        Female,
        Other,
        Shrug
    }
}
