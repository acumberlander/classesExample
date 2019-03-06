using ClassesExample.Legos.Heads;
using ClassesExample.Legos.Legs;
using ClassesExample.Legos.Torsos;

namespace ClassesExample.Legos
{
    class MiniFigure
    {
        private string name;

        public Head Head { get; set; }
        public Torso Body { get; set; }
        public object Name { get; set; }
        public LegsBase Legs { get; set; }

        public MiniFigure(string name, Head head, Torso body, LegsBase legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {
            Legs.Walk();
            Body.Wave();
            Head.Talk();
        }
    }
}
