using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Classes
{
    public class Hood 
    {
        private string name = "Hood of Elder Druid";
        public string Name { get => name; }

        private int intelligenceBuff = 20;
        public int IntelligenceBuff { get => intelligenceBuff; }

        private int mResistBuff = 10;
        public int MResistBuff { get => mResistBuff; }

        private int mAttackBuff = 25;
        private int MAttackBuff { get => mAttackBuff; }
    }

    public class HeavyHelmet
    {
        private string name = "Helmet of Hercules";
        public string Name { get => name; }

        private int strenghtBuff = 20;
        public int StrenghtBuff { get => strenghtBuff; }

        private int pResistBuff = 10;
        public int PResistBuff { get => pResistBuff; }
    }
}
