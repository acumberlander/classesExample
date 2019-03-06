using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    class Astronaut : Head
    {
        //Properties
        public List<string> Accessories { get; set; }

        //Method
        public override string Talk()
        {
            return $"Houston, we have a problem... I have {HairLength} " +
                $"long hair and I'm {Color} and my ears are {EarSize}.";
        }
    }
}
