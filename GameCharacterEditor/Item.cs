using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Item
    {
        protected double mp = 0;
        protected double hp = 0;
        protected double pDamage = 0;
        protected double mDamage = 0;
        protected double pDefence = 0;
        protected double mDefence = 0;
        protected double strength = 0;
        protected double dexterity = 0;
        protected double intelegence = 0;
        protected double constitution = 0;

        public double Hp { get => hp; private set => hp = value; }
        public double MP { get => mp; private set => mp = value; }
        public double Strength { get => strength; set => strength = value; }
        public double Dexterity { get => dexterity; set => dexterity = value; }
        public double PDamage { get => pDamage; private set => pDamage = value; }
        public double MDamage { get => mDamage; private set => mDamage = value; }
        public double PDefence { get => pDefence; private set => pDefence = value; }
        public double MDefence { get => mDefence; private set => mDefence = value; }
        public double Constitution { get => constitution; set => constitution = value; }
        public double Intelegence { get => intelegence; private set => intelegence = value; }
    }
}