using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    //static class with static methods Add and Delete which will be invoked created
    class BodyArmor : Item
    {
        public BodyArmor(Unit unit)
        {

        }

        public BodyArmor()
        {

        }
    }

    class Robe : BodyArmor
    {
        public Robe(Unit unit) : base(unit)
        {
            unit.Intelegence += 50;
            unit.Mp += 50;
            unit.MAttack += 50;
            unit.PDefence += 50;
            unit.MDefence += 150;
        }

        public void Render()
        {

        }
    }

    class Leather : BodyArmor
    {
        public Leather(Unit unit) : base(unit)
        {
            Render();
        }

        public void Render()
        {
            dexterity = 80;
            mp = 80;
            pDamage = 80;
            pDefence = 80;
            mDefence = 160;
        }
    }

    class Hecoy : BodyArmor
    {
        public Hecoy()
        {
            Render();
        }

        public void Render()
        {
            strength = 130;
            constitution = 130;
            pDefence = 130;
            hp = 260;
        }
    }
}