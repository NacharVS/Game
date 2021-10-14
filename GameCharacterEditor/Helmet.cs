using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    abstract class Helmet : Item
    {
        public abstract void Render();
    }

    class RobeHelmet : Helmet
    {
        public RobeHelmet()
        {
            Render();
        }

        public override void Render()
        {
            intelegence = 50;
            mP = 50;
            mDamage = 50;
            pDefence = 50;
            mDefence = 150;
        }
    }

    class LeatherHelmet : Helmet
    {
        public LeatherHelmet()
        {
            Render();
        }

        public override void Render()
        {
            dexterity = 80;
            mP = 80;
            pDamage = 80;
            pDefence = 80;
            mDefence = 160;

        }
    }

    class HoceyHelmet : Helmet
    {
        public HoceyHelmet()
        {
            Render();
        }

        public override void Render()
        {
            strength = 130;
            constitution = 130;
            pDefence = 130;
            hp = 260;
        }
    }
}
