using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Helmet : Item
    {
        protected double hp;
        public double Hp { get => hp; set => hp = value; }
    }

    class RobeHelmet : Helmet
    {
        public RobeHelmet()
        {
            hp = 50;
        }
    }

    class LeatherHelmet : Helmet
    {
        public LeatherHelmet()
        {
            hp = 100;
        }
    }

    class HoceyHelmet : Helmet
    {
        public HoceyHelmet()
        {
            hp = 200;
        }
    }
}
