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
        public virtual int Strenght 
        { 
            get => strenght;
            set
            {
                strenght = value;
            }
        }

        protected int dexterity = 20;
        [BsonElement("Dexterity")]
        public virtual int Dexterity 
        { 
            get => dexterity; 
            set
            {
                dexterity = value;
            }
        }

        protected int level = 1;
        [BsonElement("Level")]
        public virtual int Level 
        {
            get => level;
            set
            {
                level = value;
            }
        }

        protected int intelligence = 20;
        [BsonElement("Intelligence")]
        public virtual int Intelligence 
        { 
            get => intelligence;
            set
            {
                intelligence = value;
            }
        }

        protected int constitution = 20;
        [BsonElement("Constitution")]
        public virtual int Constitution 
        { 
            get => constitution;
            set
            {
                constitution = value;
            }
        }

        [BsonElement("Health Point")]
        public virtual int HealthPoint 
        { 
            get => constitution * 5; 
            set
            {
                constitution = value;
            }
        }

        [BsonElement("Mana Point")]
        public virtual int ManaPoint 
        {
            get => intelligence*5;
        }

        protected int pAttack;
        [BsonElement("Physical Attack")]
        public virtual int PAttack
        {
            get => pAttack;
            set
            {
                pAttack = value;
            }
        }

        [BsonElement("Magic Attack")]
        public virtual int MAttack { get => intelligence * 5; }

        [BsonElement("Physical Resist")]
        public virtual int PResist { get => constitution * 5; }

        [BsonElement("Magic Resist")]
        public virtual int MResist { get => intelligence * 5; }

        [BsonElement("Attack Speed")]
        public virtual int AttackSpeed { get => dexterity * 5; }

        [BsonElement("Movement Speed")]
        public virtual int WalkSpeed 
        { 
            get => dexterity * 5 + 100; 
            set
            {
                dexterity = value;
            }
        }
      
        protected int extra = 20;
        [BsonElement("Extra Points")]
        public virtual int Extra 
        { 
            get => extra; 
            set
            {
                extra = value;
            }          
        }
    }

    public class Warrior : Hero
    {
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
                if (value > 100)
                    dexterity = 100;
                else
                    dexterity = value;
            }
        }
    }

    public class Sorcerer : Hero
    {
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
                if (value > 150)
                    constitution = 150;
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
                if (value > 100)
                    intelligence = 100;
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

