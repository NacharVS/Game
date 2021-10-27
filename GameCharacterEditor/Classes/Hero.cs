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

        protected int strenght;
        [BsonElement("Strenght")]
        public virtual int Strenght 
        {
            get => strenght;
            set
            {
                strenght = value;
            }
        }

        protected int dexterity;
        [BsonElement("Dexterity")]
        public virtual int Dexterity 
        {
            get => dexterity; 
            set
            {
                dexterity = value;
            }
        }

        protected int intelligence;
        [BsonElement("Intelligence")]
        public virtual int Intelligence 
        { 
            get => intelligence;
            set
            {
                intelligence = value;
            }
        }

        protected int constitution;
        [BsonElement("Constitution")]
        public virtual int Constitution 
        {
            get => constitution; 
            set
            {
                constitution = value;
            }
        }

        protected int healthPoint;
        [BsonElement("Health Point")]
        public int HealthPoint 
        { 
            get => healthPoint;
            set
            {
                healthPoint = value;
            }
        }

       
        protected int manaPoint;
        [BsonElement("Mana Point")]
        public int ManaPoint
        {
            get => manaPoint; 
            set
            {
                manaPoint = value;
            }
        }

        protected int pAttack;
        [BsonElement("Physical Attack")]
        public int PAttack 
        { 
            get => pAttack;
            set
            {
                pAttack = value;
            }
        }

        protected int mAttack;
        [BsonElement("Magic Attack")]
        public int MAttack 
        {
            get => mAttack;
            set
            {
                mAttack = value;
            }
        }

        protected double pResist;
        [BsonElement("Physical Resist")]
        public double PResist 
        { 
            get => pResist; 
            set
            {
                pResist = value;
            }
        }

        protected double mResist;
        [BsonElement("Magic Resist")]
        public double MResist 
        {
            get => mResist;
            set
            {
                mResist = value;
            }
        }

        protected int attackSpeed;
        [BsonElement("Attack Speed")]
        public virtual int AttackSpeed 
        { 
            get => attackSpeed; 
            set
            {
                attackSpeed = value;
            }
        }

        protected int walkSpeed;
        [BsonElement("Movement Speed")]
        public int WalkSpeed 
        { 
            get => walkSpeed; 
            set
            {
                walkSpeed = value;
            }
        }
      
        protected int extra;
        [BsonElement("Extra Points")]
        public virtual int Extra 
        { 
            get => extra; 
            set
            {
                extra = value;
            }
        }

        protected int level;
        [BsonElement("Level")]
        public virtual int Level
        {
            get => level;
            set
            {
                level = value;
            }
        }

        public Hero(int strenght, int constitution, int dexterity, int intelligence, int extra, int level)
        {
            this.strenght = strenght;
            this.constitution = constitution;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            healthPoint = constitution * 10;
            manaPoint = intelligence * 8;
            pAttack = strenght * 5;
            mAttack = intelligence * 5;
            pResist = constitution * 0.8;
            mResist = intelligence * 0.5;
            attackSpeed = dexterity * 5;
            walkSpeed = dexterity * 2 + 50;
            this.level = level;
            this.extra = extra;
        }

        public void AddToDataBase(Hero hero)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Diyar");
            var collection = database.GetCollection<Hero>("Hero!");
            collection.InsertOne(hero);
        }
    }

    public class Warrior : Hero
    {

        public Warrior() : base(35, 30, 10, 10, 0, 1)
        { }

        public Warrior(int strenght, int constitution, int dexterity, int intelligence, int extra, int level) : base (strenght, constitution, dexterity, intelligence, extra, level)
        { }

        public override int Strenght
        {
            get => strenght;
            set
            {
                if (value > 250)
                    strenght = 250;
                else
                    strenght = value;
            }
        }


        public override int Intelligence
        {
            get => intelligence;
            set
            {
                if (value > 100)
                    intelligence = 100;
                else
                    intelligence = value;
            }
        }

        public override int Dexterity
        {
            get => dexterity;
            set
            {
                if (value > 150)
                    dexterity = 150;
                else
                    dexterity = value;
            }
        }

        public override int Constitution
        {
            get => constitution;
            set
            {
                if (value > 250)
                    constitution = 250;
                else
                    constitution = value;
            }
        }
    }

    public class Sorcerer : Hero
    {
        public Sorcerer() : base (15, 25, 10, 35, 0, 1)
        { }

        public Sorcerer(int strenght, int constitution, int dexterity, int intelligence, int extra, int level) : base(strenght, constitution, dexterity, intelligence, extra, level)
        { }

        public override int Intelligence
        {
            get => intelligence;
            set
            {
                if (value > 250)
                    intelligence = 250;
                else
                    intelligence = value;
            }
        }
        public override int Constitution
        {
            get => constitution;
            set
            {
                if (value > 175)
                    constitution = 175;
                else
                    constitution = value;
            }
        }

        public override int Dexterity
        {
            get => dexterity;
            set
            {
                if (value > 100)
                    dexterity = 100;
                else
                    dexterity = value;
            }
        }

        public override int Strenght
        {
            get => strenght;
            set
            {
                if (value > 100)
                    strenght = 100;
                else
                    strenght = value;
            }
        }
    }

    public class Rogue : Hero
    {
        public Rogue() : base (20, 15, 35, 15, 0, 1)
        { }

        public Rogue(int strenght, int constitution, int dexterity, int intelligence, int extra, int level) : base(strenght, constitution, dexterity, intelligence, extra, level)
        { }

        public override int Dexterity
        {
            get => dexterity;
            set
            {
                if (value > 250)
                    dexterity = 250;
                else
                    dexterity = value;
            }
        }

        public override int Strenght
        {
            get => strenght;
            set
            {
                if (value > 150)
                    strenght = 150;
                else
                    strenght = value;
            }
        }

        public override int Intelligence
        {
            get => intelligence;
            set
            {
                if (value > 150)
                    intelligence = 150;
                else
                    intelligence = value;
            }
        }

        public override int Constitution
        {
            get => constitution;
            set
            {
                if (value > 150)
                    constitution = 150;
                else
                    constitution = value;
            }
        }
    }
}

