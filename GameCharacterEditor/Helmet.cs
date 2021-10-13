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
            pDefence = 50;
        }
    }

    class LeatherHelmet : Helmet
    {
        public LeatherHelmet()
        {
            pDefence = 100;
        }
    }

    class HoceyHelmet : Helmet
    {
        public HoceyHelmet()
        {
            pDefence = 200;
        }
    }
}
