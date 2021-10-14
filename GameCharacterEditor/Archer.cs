using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Archer : Unit
    {
        public void Properties_Archer()
        {
            strenght = 50;
            dexterity = 150;
            intelegence = 80;
        }
        public void Health_Unit()
        {
            Hp_Unit += strenght * 5;
        }
        public void Attack_Unit()
        {
            if ((strenght * 5) > 250)
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
            Mp_Unit = intelegence * 5;
            Magic_Defence = intelegence * 5;
        }
        public void Agility_Buffs_Constitution()
        {
            Phisical_Defence += constitution * 5;
            Hp_Unit += constitution * 10;
        }                                                                                                        
    }
}
