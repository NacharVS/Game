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

        protected int strenght = 20;
        [BsonElement("Strenght")]
        public virtual int Strenght { get => strenght; }

        protected int dexterity = 20;
        [BsonElement("Dexterity")]
        public virtual int Dexterity { get => dexterity; }

        protected int level = 1;
        [BsonElement("Level")]
        public virtual int Level { get => level; }

        protected int intelligence = 20;
        [BsonElement("Intelligence")]
        public virtual int Intelligence { get => intelligence; }

        protected int constitution = 20;
        [BsonElement("Constitution")]
        public virtual int Constitution { get => constitution; }

        protected int healthPoint = 100;
        [BsonElement("Health Point")]
        public virtual int HealthPoint { get => healthPoint; }

        [BsonElement("Mana Point")]
        protected int manaPoint = 100;
        public virtual int ManaPoint { get => manaPoint; }

        protected int pAttack = 20;
        [BsonElement("Physical Attack")]
        public virtual int PAttack { get => pAttack; }

        protected int mAttack = 20;
        [BsonElement("Magic Attack")]
        public virtual int MAttack { get => mAttack; }

        protected int pResist = 20;
        [BsonElement("Physical Resist")]
        public virtual int PResist { get => pResist; }

        protected int mResist = 20;
        [BsonElement("Magic Resist")]
        public virtual int MResist { get => mResist; }

        protected int attackSpeed = 100;
        [BsonElement("Attack Speed")]
        public virtual int AttackSpeed { get => attackSpeed; }

        protected int walkSpeed = 100;
        [BsonElement("Movement Speed")]
        public virtual int WalkSpeed { get => walkSpeed; }
      
        protected int extra = 20;
        [BsonElement("Extra Points")]
        public virtual int Extra { get => extra; }
    }

    public class Warrior : Hero
    {
        public override int Strenght => strenght + 10;

        public override int Constitution => constitution + 10;

        public override int Intelligence => intelligence - 5;

        public override int Dexterity => dexterity - 5;

        public override int HealthPoint => healthPoint + 100;

        public override int ManaPoint => manaPoint - 25;


    }

    public class Sorcerer : Hero
    {
        public override int Intelligence => intelligence + 10;

        public override int Constitution => constitution + 5;

        public override int Dexterity => dexterity - 10;

        public override int Strenght => strenght + 5;

        public override int HealthPoint => healthPoint - 25;

        public override int ManaPoint => manaPoint + 100;
    }

    public class Rogue : Hero
    {
        public override int Dexterity => dexterity + 10;

        public override int Strenght => strenght - 5;

        public override int Intelligence => intelligence + 5;

        public override int Constitution => constitution + 5;

        public override int HealthPoint => healthPoint + 50;

        public override int ManaPoint => manaPoint + 25;
    }
}

