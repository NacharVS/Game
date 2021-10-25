using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Class
{
    public class Warrior : HeroClass
    {
        public override void LevelUp()
        {
            if (lvl < lvlMax)
            {
                ++lvl;
                ++ExtraPoints;

                _hp += 5;
                _mana += 1;
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
