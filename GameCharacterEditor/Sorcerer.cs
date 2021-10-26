using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    class Sorcerer : Hero
    {
        private double maxstr = 70;
        private double maxdox = 70;
        private double maxint = 320;
        private double maxconst = 70;

        public double MaxStr { get => maxstr; set => maxstr = value; }
        public double MaxDox { get => maxdox; set => maxdox = value; }
        public double MaxInt { get => maxint; set => maxint = value; }
        public double MaxConst { get => maxconst; set => maxconst = value; }
        public Sorcerer() : base(50, 50, 250, 50, "Sorcerer", 1, 0)
        {
            strength = 50;
            doxterity = 50;
            intelegence = 250;
            constitution = 50;
            name = "Sorcerer";
            lvl = 1;
            extra = 0;
        }
        public Sorcerer(double strength, double doxterity, double intelegence, double constitution, string name, double lvl, double extra) : base(strength, doxterity, intelegence, constitution, name, lvl, extra)
        {

        }

        public void Add(Sorcerer sor)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Sorcerer>("person");
            collection.InsertOne(sor);
        }
    }
}
