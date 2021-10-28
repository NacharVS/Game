using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class Mage : HeroClass
    {
        public override void GetXP(int xp)
        {
            var lvlOld = _level.Level;
            if (_level.GetXP(xp))
            {
                for (int i = lvlOld; i < _level.Level; i++)
                {
                    HP += 5;
                    Mana += 15;
                }
            }
        }

        public Mage(string name) : base(name)
        {
            StrengthMax = 13;
            DexterityMax = 25;
            IntellectMax = 30;
            ConstitutionMax = 22;
        }

        public Mage(string name, int strength, int dexterity, int intellect, int constitution) : base(name, strength, dexterity, intellect, constitution)
        {
            StrengthMax = 13;
            DexterityMax = 25;
            IntellectMax = 30;
            ConstitutionMax = 25;
        }
    }
}
