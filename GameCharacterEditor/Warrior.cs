using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    class Warrior : Hero
    {
        private double maxstr = 320;
        private double maxdox = 110;
        private double maxint = 70;
        private double maxconst = 150;

        public double MaxStr { get => maxstr; set => maxstr = value; }
        public double MaxDox { get => maxdox; set => maxdox = value; }
        public double MaxInt { get => maxint; set => maxint = value; }
        public double MaxConst { get => maxconst; set => maxconst = value; }
        public Warrior() : base(250, 70, 50, 100, "Warrior", 1, 0)
        {
            strength = 250;
            doxterity = 70;
            intelegence = 50;
            constitution = 100;
            name = "Warrior";
            lvl = 1;
            extra = 0;
        }

        public Warrior(double strength, double doxterity, double intelegence, double constitution, string name, double lvl, double extra) : base(strength, doxterity, intelegence, constitution, name, lvl, extra)
        {

        }

        public void Add(Warrior war)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Warrior>("person");
            collection.InsertOne(war);
        }
    }
}
