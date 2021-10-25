using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class Mage : HeroClass
    {
        public override void LevelUp()
        {
            if (lvl < lvlMax)
            {
                ++lvl;
                ++ExtraPoints;

                _hp += 2;
                _mana += 4;
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
