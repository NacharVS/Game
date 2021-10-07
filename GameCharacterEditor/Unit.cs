using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    public class Unit
    {
        protected int strenght, dexterity, intelligence, constitution, health, mana, pAttack, mAttack, pResist, mResist, attackSpeed, walkSpeed;

        public Unit()
        {
            strenght = 20;
            dexterity = 20;
            intelligence = 20;
            constitution = 20;
            health = 100;
            mana = 100;
            pAttack = 20;
            mAttack = 20;
            pResist = 20;
            mResist = 20;
            attackSpeed = 20;
            walkSpeed = 20;
        }
    }

    class Warrior : Unit
    {
        public Warrior()
        {
            strenght = 30;
            dexterity = 20;
            intelligence = 10;
            constitution = 25;
            health = 100;
            mana = 100;
            pAttack = 20;
            mAttack = 20;
            pResist = 20;
            mResist = 20;
            attackSpeed = 20;
            walkSpeed = 20;
        }
    }

    class Witch : Unit
    {
        public Witch()
        {
            strenght = 10;
            dexterity = 20;
            intelligence = 30;
            constitution = 20;
            health = 20;
            mana = 20;
            pAttack = 20;
            mAttack = 20;
            pResist = 20;
            mResist = 20;
            attackSpeed = 20;
            walkSpeed = 20;
        }
    }

    class Rogue : Unit
    {
        public Rogue()
        {
            strenght = 15;
            dexterity = 30;
            intelligence = 25;
            constitution = 15;
            health = 20;
            mana = 20;
            pAttack = 20;
            mAttack = 20;
            pResist = 20;
            mResist = 20;
            attackSpeed = 20;
            walkSpeed = 20;
        }
    }
}
