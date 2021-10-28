using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    internal class Raritem
    {
        protected double Strengt;
        protected double Dexterity;
        protected double Constitution;
        protected double intelegence;
        protected double CriticalChance;
        protected double Critdamage;
        protected double Full_Phisical_Damage;
        protected double Full_Magic_Damage;
        protected double WeaponDamage = 100;
        protected double MinDamage;
        protected double MaxDamage;
    }
    class Sword : Raritem
    {
        Raritem rt;
        public Sword(double str, double dex, double intele, int state)
        {
            Critdamage = 1.5;
            CriticalChance = 2;
            Full_Phisical_Damage = WeaponDamage + ((WeaponDamage * (0.5 * str)) + (WeaponDamage * (0.5 * dex)));
            Full_Magic_Damage = WeaponDamage + (WeaponDamage * (0.3 * intele));
            if (state == 2)
                rt = new Two_Handed_Weapon();
            else if (state == 1)
                rt = new One_Handed_Weapon();
        }
    }
   
   class Two_Handed_Weapon : Raritem
    {
        public Two_Handed_Weapon()
        {
            MinDamage = 1.5;
            MaxDamage = 4.5;
        }
    }
    class One_Handed_Weapon : Raritem
    {
        public One_Handed_Weapon()
        {
            MinDamage = 1;
            MaxDamage = 2.5;
        }
    }
    class Axe : Raritem
    {
        One_Handed_Weapon ohw;
        public Axe()
        {
            CriticalChance = 1;
            Critdamage = 4;
            ohw = new One_Handed_Weapon();
        }
    }
    class Bow : Two_Handed_Weapon
    {
        public Bow()
        {
            Critdamage = 3;
            CriticalChance = 2;
            MinDamage = 0.5;
            MaxDamage = 3;
        }
    }
    class Magic_Stick : Raritem
    {
        public Magic_Stick()
        {
            CriticalChance = 1.3;
            Critdamage = 3;
        }
    }
    class Dagger : Raritem
    {
        public Dagger()
        {
            Critdamage = 1.3;
            CriticalChance = 4;
        }
    }
}
