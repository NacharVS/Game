using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Warrior : Hero
    {
        public Warrior() : base(250, 70, 50, 100, "Warrior", 1)
        {
            strength = 250;
            doxterity = 70;
            intelegence = 50;
            constitution = 100;
            name = "Warrior";
        }

        public Warrior(double strength, double doxterity, double intelegence, double constitution, string name, double lvl) : base(strength, doxterity, intelegence, constitution, name, lvl)
        {

        }
    }
}
