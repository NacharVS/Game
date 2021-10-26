using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    class Rogue : Hero
    {
        private double maxstr = 70;
        private double maxdox = 320;
        private double maxint = 150;
        private double maxconst = 70;

        public double MaxStr { get => maxstr; set => maxstr = value; }
        public double MaxDox { get => maxdox; set => maxdox = value; }
        public double MaxInt { get => maxint; set => maxint = value; }
        public double MaxConst { get => maxconst; set => maxconst = value; }
        public Rogue () : base (50, 250, 100, 50, "Rogue", 1, 0)
        {
            strength = 50;
            doxterity = 250;
            intelegence = 100;
            constitution = 50;
            name = "Rogue";
            lvl = 1;
            extra = 0;
        }

        public Rogue(double strength, double doxterity, double intelegence, double constitution, string name, double lvl, double extra) : base(strength, doxterity, intelegence, constitution, name, lvl, extra)
        {

        }

        public void Add(Rogue rog)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Rogue>("person");
            collection.InsertOne(rog);
        }
    }
}
