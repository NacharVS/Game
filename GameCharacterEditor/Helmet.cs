using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    abstract class Helmet : Item
    {

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
