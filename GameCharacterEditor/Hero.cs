using System;
using System.Collections.Generic;
using System.Text;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

public class Hero
{
    [BsonId]
    public ObjectId _id;
    [BsonElement("Strength")]
    public int strength; public int dexterity; public int intellect; public int physique; public int attackSpeed; public int moveSpeed; public int healthPoint; public int manaPoint; public int pAttack; public int mAttack; public int armor;

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
            intellect = 10;
            physique = 25;
            
            healthPoint = 70;
            manaPoint = 10;

        }
    }
    public class Sorcecer : Hero
    {
        public Sorcecer()
        {
            intellect = 35;
            strength = 15;
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
        intellect = 15;

            healthPoint = 45;
            manaPoint = 22;
        }
    }
