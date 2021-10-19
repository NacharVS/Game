using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Models
{
    public class Hero
    {
        [BsonId]
        Object _id;
        [BsonElement("Имя")]
        public int strenght;
        public int dexterity;
        public int intelligence;
        public int constitution;
        public int healthPoint;
        public int manaPoint;
        public int pAttack;
        public int mAttack;
        public int pResist;
        public int mResist;
        public int attackSpeed;
        public int walkSpeed;
        public int extra;

        public Hero()
        {
            strenght = 20;
            dexterity = 20;
            intelligence = 20;
            constitution = 20;
            healthPoint = 50;
            manaPoint = 50;
            pAttack = 20;
            mAttack = 20;
            pResist = 20;
            mResist = 20;
            attackSpeed = 20;
            walkSpeed = 20;
            extra = 20;
        }
    }

    public class Warrior : Hero
    {
        public Warrior()
        {
            strenght = 30;
            constitution = 25;
            intelligence = 10;
            healthPoint = 70;
            manaPoint = 10;
        }
    }

    public class Sorcerer : Hero
    {
        public Sorcerer()
        {
            intelligence = 35;
            strenght = 15;
            dexterity = 15;
            healthPoint = 30;
            manaPoint = 70;
        }
    }

    public class Rogue : Hero
    {
        public Rogue()
        {
            dexterity = 30;
            intelligence = 15;
            healthPoint = 45;
            manaPoint = 22;
        }
    }
}

