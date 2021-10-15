using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Warrior : Unit
    {
        public Warrior()
        {
            strenght = 250;
            dexterity = 70;
            constitution = 100;
            intelegence = 50;
            Hp_Unit += strenght * 5;
            Hp_Unit += constitution * 10;
            Mp_Unit = intelegence * 5;

        }
        //public void Health_Unit()
        //{
           
        //}
        public void Attack_Unit()
        {
            if ((strenght * 5) > 20)
            {
                Phusical_Attack = strenght * 5;
            }
            else
            {
                Phusical_Attack = Extra;
            }
        }
        public void Agility_Buffs_Dexterity()
        {
            AttackSpeed += dexterity * 5;
            Running_Speed += dexterity * 2;
            Phusical_Attack += dexterity * 3;
        }
        public void Agility_Buffs_Intelegence()
        {
            Magic_Attack = intelegence * 10;
           
            Magic_Defence = intelegence * 5;
        }
        public void Agility_Buffs_Constitution()
        {
            Phisical_Defence += constitution * 5;
       
        }
    }
    
}