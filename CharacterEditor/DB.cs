using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class DB_Warrior
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected double Strenght;
        protected double Agility;
        protected double Intelligence;
        protected string LvL;
        protected string HP;
        protected string Mana;
        protected string Class;
        public static string Warrior = "C:/Users/пк/Source/Repos/Game/CharacterEditor/Pages/Res/BackGround/BWarrior.jpg";
        private static string W_img = Warrior;
        private int v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        public string Img => W_img;
        public DB_Warrior(int v1, int v2, int v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public double _strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double _agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double _intelligence { get => v3; set => Intelligence = value; }
        [BsonElement]
        public string _LvL { get => v4; set => LvL = value; }
        public string _HP { get => v5; set => HP = value; }
        public string _Mana { get => v6; set => Mana = value; }
        public string _Class { get => v7; set => Class = value; }
        public string _Image { get => Img; set => W_img = value; }



        public void Add(DB_Warrior db1)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("GGG");
            var b = abase.GetCollection<DB_Warrior>("Gizetdinov_DB");
            b.InsertOne(db1);
        }
    }

    class DB_Archer 
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected double Strenght;
        protected double Agility;
        protected double Intelligence;
        protected string LvL;
        protected string HP;
        protected string Mana;
        protected string Class;
        public static string Archer = "C:/Users/пк/Source/Repos/Game/CharacterEditor/Pages/Res/BackGround/BArcher.jpg";
        private static string A_img = Archer;
        private int v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        public string Img => A_img;
        public DB_Archer(int v1, int v2, int v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public double _strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double _agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double _intelligence { get => v3; set => Intelligence = value; }
        [BsonElement]
        public string _LvL { get => v4; set => LvL = value; }
        public string _HP { get => v5; set => HP = value; }
        public string _Mana { get => v6; set => Mana = value; }
        public string _Class { get => v7; set => Class = value; }
        public string _Image { get => Img; set => A_img = value; }



        public void Add(DB_Archer db1)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("GGG");
            var b = abase.GetCollection<DB_Archer>("Gizetdinov_DB");
            b.InsertOne(db1);
        }
    }

    class DB_Mage
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected double Strenght;
        protected double Agility;
        protected double Intelligence;
        protected string LvL;
        protected string HP;
        protected string Mana;
        protected string Class;
        public static string Mage = "C:/Users/пк/Source/Repos/Game/CharacterEditor/Pages/Res/BackGround/BMage.jpg";
        private static string M_img = Mage;
        private int v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        public string Img => M_img;
        public DB_Mage(int v1, int v2, int v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public double _strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double _agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double _intelligence { get => v3; set => Intelligence = value; }
        [BsonElement]
        public string _LvL { get => v4; set => LvL = value; }
        public string _HP { get => v5; set => HP = value; }
        public string _Mana { get => v6; set => Mana = value; }
        public string _Class { get => v7; set => Class = value; }
        public string _Image { get => Img; set => M_img = value; }



        public void Add(DB_Mage db1)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("GGG");
            var b = abase.GetCollection<DB_Mage>("Gizetdinov_DB");
            b.InsertOne(db1);
        }
    }

    class DB_Outlaw
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected double Strenght;
        protected double Agility;
        protected double Intelligence;
        protected string LvL;
        protected string HP;
        protected string Mana;
        protected string Class;
        public static string Outlaw = "C:/Users/пк/Source/Repos/Game/CharacterEditor/Pages/Res/BackGround/BOutlaw.jpg";
        private static string O_img = Outlaw;
        private int v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        public string Img => O_img;
        public DB_Outlaw(int v1, int v2, int v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public double _strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double _agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double _intelligence { get => v3; set => Intelligence = value; }
        [BsonElement]
        public string _LvL { get => v4; set => LvL = value; }
        public string _HP { get => v5; set => HP = value; }
        public string _Mana { get => v6; set => Mana = value; }
        public string _Class { get => v7; set => Class = value; }
        public string _Image { get => Img; set => O_img = value; }



        public void Add(DB_Outlaw db1)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("GGG");
            var b = abase.GetCollection<DB_Outlaw>("Gizetdinov_DB");
            b.InsertOne(db1);
        }
    }
}