using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Sorcerer : BaseCharacter
    {
        public Sorcerer()
        {
            StrengthParameter = 15;
            DexterityParameter = 25;
            InteligenceParameter = 30;
            ConstitutionParameter = 20;

            HealtPoints = 100 + StrengthParameter * 5 + ConstitutionParameter * 10;
            PhysicalAttack = 20 + StrengthParameter * 10;
            PhysicalDefence = 20 + DexterityParameter * 5 + ConstitutionParameter * 10;
            MagicalAttack = 20 + InteligenceParameter * 10;
            MagicalDefence = 20 + DexterityParameter * 5 + InteligenceParameter;
            WalkingSpeed = 20 + DexterityParameter * 5;
            AttackSpeed = 20 + DexterityParameter * 5;
            ManaPoints = 100 + InteligenceParameter * 10;
        }
    }
}
