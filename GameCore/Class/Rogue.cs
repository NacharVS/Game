using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class Rogue : HeroClass
    {
        public override void GetXP(int xp)
        {
            var lvlOld = _level.Level;
            if (_level.GetXP(xp))
            {
                for (int i = lvlOld; i < _level.Level; i++)
                {
                    HP += 12;
                    Mana += 8;
                }
            }
        }

        public Rogue(string name) : base(name)
        {
            StrengthMax = 27;
            DexterityMax = 30;
            IntellectMax = 20;
            ConstitutionMax = 13;
        }

        public Rogue(string name, int strength, int dexterity, int intellect, int constitution) : base(name, strength, dexterity, intellect, constitution)
        {
            StrengthMax = 25;
            DexterityMax = 30;
            IntellectMax = 18;
            ConstitutionMax = 13;
        }
    }
}
