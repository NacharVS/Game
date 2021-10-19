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
            hp_Unit += strenght * 5;
            hp_Unit += constitution * 10;
            mp_Unit = intelegence * 5;
            Agility_Buffs_Intelegence();
            Agility_Buffs_Constitution();
            Agility_Buffs_Dexterity();

        }
        //public void Health_Unit()
        //{
           
        //}
        public void Attack_Unit()
        {
            if ((strenght * 5) > 20)
            {
                phusical_Attack = strenght * 5;
            }
            else
            {
                phusical_Attack = Extra;
            }
        }
        public void Agility_Buffs_Dexterity()
        {
            attackSpeed += dexterity * 5;
            running_Speed += dexterity * 2;
            phusical_Attack += dexterity * 3;
        }
        public void Agility_Buffs_Intelegence()
        {
            magic_Attack = intelegence * 10;
           
            magic_Defence = intelegence * 5;
        }
        public void Agility_Buffs_Constitution()
        {
            phisical_Defence += constitution * 5;
       
        }
    }
    
}