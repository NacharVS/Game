using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class Rogue : HeroClass
    {
        public override void LevelUp()
        {
            if (lvl < lvlMax)
            {
                ++lvl;
                ++ExtraPoints;

                _hp += 3;
                _mana += 2;
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
