using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    abstract class BodyArmor : Item
    {
        // public override double Hp { get => base.Hp; set => base.Hp = value; }
    }

    class Robe : BodyArmor
    {
        public Robe()
        {
            hp = 50;
        }
    }

    class Leather : BodyArmor
    {
        public Leather()
        {
            hp = 100;
        }
    }

    class Hecoy : BodyArmor
    {
        public Hecoy()
        {
            hp = 200;
        }

    }
}
