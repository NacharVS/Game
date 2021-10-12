using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class BodyArmor
    {
        protected double hp;
    }

    class Robe : BodyArmor
    {
        public Robe()
        {
            hp = 100;
        }
    }

    class Leather : BodyArmor
    {
        public Leather()
        {
            hp = 200;
        }
    }

    class Hecoy : BodyArmor
    {
        public Hecoy()
        {
            hp = 500;
        }

    }
}
