using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Sorcerer : Hero
    {
        public Sorcerer() : base(50, 50, 250, 50, "Sorcerer")
        {
            strength = 50;
            doxterity = 50;
            intelegence = 250;
            constitution = 50;
            name = "Sorcerer";
        }
    }
}
