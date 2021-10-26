using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geroi
{
    class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }
        protected double strenght = 20;
        protected double agility = 35;
        protected double intelligence = 30;
        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }
        [BsonElement]
        public double Agility { get => agility; set => agility = value; }
        [BsonElement]
        public double Intelligence { get => intelligence; set => intelligence = value; }
        public static void Add(Object unit)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Object>("Shakirov_DB");
            b.InsertOne(unit);
        }
    }
}
