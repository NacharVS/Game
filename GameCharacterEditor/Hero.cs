using System;
using System.Collections.Generic;
using System.Text;

    public class Hero
    {
       public int strength; public int dexterity;public int intellect;public int physique;public int attackSpeed;public int moveSpeed;public int healthPoint;public int manaPoint;public int pAttack;public int mAttack;public int armor;

        public Hero()
        {
            strength = 20;
            dexterity = 20;
            intellect = 20;
            physique = 20;
            attackSpeed = 20;
            moveSpeed = 20;
            healthPoint = 100;
            manaPoint = 100;
            pAttack = 20;
            mAttack = 20;
            armor = 20;
        }
    }
    public class Warrior : Hero
    {
        public Warrior()
        {
            strength = 30;
            physique = 25;
            intellect = 10;

        }
    }
    public class Sorcecer : Hero
    {
        public Sorcecer()
        {
        intellect = 30;
        strength = 10;
        }
    }
    public class Rogue : Hero
    {
        public Rogue()
        {
        dexterity = 30;
        physique = 15;
        strength = 15;
        intellect = 25;
        }
    }
