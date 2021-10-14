using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Archer : BaseCharacter
    {
        public Archer()
        {
            StrengthParameter = 25;
            DexterityParameter = 35;
            InteligenceParameter = 25;
            ConstitutionParameter = 20;

            HealtPoints = 100 + StrengthParameter * 5;
    }
}
}
