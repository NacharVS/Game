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
            lvl = experience / 1000;
            Agility_Buffs_Intelegence();
            Agility_Buffs_Constitution();
            Agility_Buffs_Dexterity();
            Attack_Unit();
            MaxStrenght = 300;
            MaxdDexterity = 95;
            MaxIntelegence = 80;
            MaxConstitution = 150;
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