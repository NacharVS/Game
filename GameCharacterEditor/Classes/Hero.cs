using MongoDB.Bson;
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
        ObjectId _id;

        [BsonElement("Strenght")]
        protected int strenght = 20;
        public int Strenght { get => strenght; }

        [BsonElement("Dexterity")]
        protected int dexterity = 20;
        public int Dexterity { get => dexterity; }

        [BsonElement("Intelligence")]
        protected int intelligence = 20;
        public int Intelligence { get => intelligence; }

        [BsonElement("Constitution")]
        protected int constitution = 20;
        public int Constitution { get => constitution; }

        [BsonElement("Health Point")]
        protected int healthPoint = 100;
        public int HealthPoint { get => healthPoint; }

        [BsonElement("Mana Point")]
        protected int manaPoint = 100;
        public int ManaPoint { get => manaPoint; }

        [BsonElement("Physical Attack")]
        protected int pAttack = 20;
        public int PAttack { get => pAttack; }

        [BsonElement("Magic Attack")]
        protected int mAttack = 20;
        public int MAttack { get => mAttack; }

        [BsonElement("Physical Resist")]
        protected int pResist = 20;
        public int PResist { get => pResist; }

        [BsonElement("Magic Resist")]
        protected int mResist = 20;
        public int MResist { get => mResist; }

        [BsonElement("Attack Speed")]
        protected int attackSpeed = 100;
        public int AttackSpeed { get => attackSpeed; }

        [BsonElement("Movement Speed")]
        protected int walkSpeed = 100;
        public int WalkSpeed { get => walkSpeed; }

        [BsonElement("Extra Points")]
        protected int extra = 100;
        public int Extra { get => extra; }
    }

    public class Warrior : Hero
    {
        public int Strenght => strenght + 10;

        public int Constitution => constitution + 10;

        public int Intelligence => intelligence - 5;

        public int Dexterity => dexterity - 5;

        public int HealthPoint => healthPoint + 100;

        public int ManaPoint => manaPoint - 25;
    }

    public class Sorcerer : Hero
    {
        public int Intelligence => intelligence + 10;

        public int Constitution => constitution + 5;

        public int Dexterity => dexterity - 10;

        public int Strenght => strenght + 5;

        public int HealthPoint => healthPoint - 25;

        public int ManaPoint => manaPoint + 100;
    }

    public class Rogue : Hero
    {
        public int Dexterity => dexterity + 10;

        public int Strenght => strenght - 5;

        public int Intelligence => intelligence + 5;

        public int Constitution => constitution + 5;

        public int HealthPoint => healthPoint + 50;

        public int ManaPoint => manaPoint + 25;

    }
}

