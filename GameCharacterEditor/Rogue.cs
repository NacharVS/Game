using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Rogue : Unit
    {
        public Rogue()
        {
            dexterity = 270;
            strenght = 65;
            intelegence = 100;
            constitution = 50;
            mp_Unit = intelegence * 5;
            hp_Unit += strenght * 5;
            hp_Unit += constitution * 10;
            lvl = experience / 1000;
            Attack_Unit();
            Agility_Buffs_Dexterity();
            Agility_Buffs_Intelegence();
            Agility_Buffs_Constitution();
            MaxStrenght = 95;
            MaxdDexterity = 350;
            MaxIntelegence = 150;
            MaxConstitution = 80;
        }
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
            woolding_Speed += dexterity * 2;
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
