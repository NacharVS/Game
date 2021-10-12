﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class BodyArmor : Item
    {
        protected double hp;
        public double Hp { get => hp; set => hp = value; }
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
