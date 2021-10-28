using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class Warrior : HeroClass
    {
        public override void GetXP(int xp)
        {
            var lvlOld = _level.Level;
            if (_level.GetXP(xp))
            {
                for (int i = lvlOld; i < _level.Level; i++)
                {
                    HP += 15;
                    Mana += 5;
                }
            }
        }

        public Warrior(string name) : base(name)
        {
            StrengthMax = 30;
            DexterityMax = 22;
            IntellectMax = 13;
            ConstitutionMax = 25;
        }

        public Warrior(string name, int strength, int dexterity, int intellect, int constitution) : base(name, strength, dexterity, intellect, constitution)
        {
            StrengthMax = 30;
            DexterityMax = 22;
            IntellectMax = 13;
            ConstitutionMax = 25;
        }
    }
}
