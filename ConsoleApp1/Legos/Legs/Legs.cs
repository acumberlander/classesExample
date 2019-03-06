using System;

namespace ClassesExample.Legos.Legs
{
    abstract class LegsBase
    {
        //Properties
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        public LegsBase(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        //Methods
        public virtual void Jump()
        {
            Console.WriteLine("WEEEEEEE!!!!!");
        }

        public void Kick(MiniFigure personToKick)
        {
            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. HAHAHAHA. " +
                $"You're not even a scientist.");
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} took a few steps.");
        }
    }

    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
