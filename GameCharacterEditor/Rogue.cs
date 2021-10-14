using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Rogue : Hero
    {
        public Rogue () : base (50, 250, 100, 50, "Rogue")
        {
            strength = 50;
            doxterity = 250;
            intelegence = 100;
            constitution = 50;
            name = "Rogue";
        }
    }
}
