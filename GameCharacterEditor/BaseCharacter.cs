using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class BaseCharacter
    {
        public int StrengthParameter { get; set; }
        public int DexterityParameter { get; set; }
        public int InteligenceParameter { get; set; }
        public int ConstitutionParameter { get; set; }

        public int HealtPoints { get; set ; }
        public int ManaPoints { get; set; }
        public int PhysicalAttack { get; set; }
        public int PhysicalDefence { get; set; }
        public int MagicalAttack { get; set; }
        public int MagicalDefence { get; set; }
        public int WalkingSpeed { get; set; }
        public int AttackSpeed { get; set; }

    }
}
