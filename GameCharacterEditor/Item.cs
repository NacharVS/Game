using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Item
    {
        protected double strength = 0;
        protected double doxterity = 0;
        protected double intelegence = 0;
        protected double constitution = 0;
        protected double hp = 0;
        protected double mp = 0;
        protected double attackSpeed = 0;
        protected double walkingSpeed = 0;
        protected double pAttack = 0;
        protected double pDefence = 0;
        protected double mAttack = 0;
        protected double mDefence = 0;

        public double Strength { get => strength; set => strength = value; }
        public double Doxterity { get => doxterity; set => doxterity = value; }
        public double Intelegence { get => intelegence; set => intelegence = value; }
        public double Constitution { get => constitution; set => constitution = value; }
        public double HP { get => hp; set => hp = value; }
        public double MP { get => mp; set => mp = value; }
        public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public double WalkingSpeed { get => walkingSpeed; set => walkingSpeed = value; }

        public double PAttack { get => pAttack; set => pAttack = value; }
        public double PDefence { get => pDefence; set => pDefence = value; }
        public double MAttack { get => mAttack; set => mAttack = value; }
        public double MDefence { get => mDefence; set => mDefence = value; }
    }

    class BodyArmor : Item
    {

    }

    class Helmet : Item
    { 
    
    }

    class Weapon : Item
    {

    }


    class RobeArmor : BodyArmor
    {
        public RobeArmor()
        {
            intelegence = 50;
            mp = 50;
            mAttack = 50;
            pDefence = 50;
            mDefence = 150;
        }
    }

    class LeatherArmor : BodyArmor
    {
        public LeatherArmor()
        {
            doxterity = 80;
            mp = 80;
            pAttack = 80;
            pDefence = 80;
            mDefence = 160;
        }
    }

    class IronArmor : BodyArmor
    { 
        public IronArmor()
        {
            strength = 130;
            constitution = 130;
            pDefence = 130;
            hp = 260;
        }
    }

    class RobeHelmet : Helmet
    { 
        public RobeHelmet()
        {
            intelegence = 50;
            mp = 50;
            mAttack = 50;
            pDefence = 50;
            mDefence = 150;
        }
    }

    class LeatherHelmet : Helmet
    {
        public LeatherHelmet()
        {
            doxterity = 80;
            mp = 80;
            pAttack = 80;
            pDefence = 80;
            mDefence = 160;
        }
    }

    class IronHelmet : Helmet
    { 
        public IronHelmet()
        {
            strength = 130;
            constitution = 130;
            pDefence = 130;
            hp = 260;
        }
    }

    class Truncheon : Weapon
    {
        public Truncheon()
        {
            strength = 50;
            pAttack = 60;
            mAttack = 10;
        }
    }

    class Dagger : Weapon
    {
        public Dagger()
        {
            strength = 90;
            pAttack = 100;
            mAttack = 70;
        }
    }

    class Sword : Weapon
    {
        public Sword()
        {
            strength = 130;
            pAttack = 140;
            mAttack = 50;
        }
    }
}
