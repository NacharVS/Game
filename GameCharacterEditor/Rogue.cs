using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Rogue : Hero
    {
        public Rogue () : base (50, 250, 100, 50, "Rogue", 1)
        {
            strength = 50;
            doxterity = 250;
            intelegence = 100;
            constitution = 50;
            lvl = 1;
            name = "Rogue";
        }

        public Rogue(double strength, double doxterity, double intelegence, double constitution, string name, double lvl) : base(strength, doxterity, intelegence, constitution, name, lvl)
        {

        }
    }
}
