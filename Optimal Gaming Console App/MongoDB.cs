using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections;

namespace Optimal_Gaming_Console_App
{
    public class MongoDB
    {
        public IMongoDatabase Database;

        public IMongoCollection<Toy> collection;
        public List<Toy> List;


        public MongoDB()
        {

        }

        public void GenerateConnection()
        {
            var client = new MongoClient("mongodb+srv://stef4905:xep24mkn@cluster0-bjeod.mongodb.net/test?retryWrites=true");
            Database = client.GetDatabase("testDatabase");
            collection = Database.GetCollection<Toy>("Toys");
        }

        public void InsertIntoDatabase()
        {
            Toy toy = new Toy("ToDelete");



            
            collection.InsertOneAsync(toy);
            var id = toy._id;
        }

        public void PrintCollection()
        {
            List = collection.Find(new BsonDocument()).ToList();
            foreach (var dox in List)
            {
                Console.WriteLine(dox.name + " - ID: " + dox._id);
            }
            

        }

        public void Remove(ObjectId id)
        {
            var filter = Builders<Toy>.Filter.Eq(s => s._id, id); // BEST EVER TO USE!
            var result = collection.DeleteMany(filter);
            Console.WriteLine(result.DeletedCount);
        }
    }
}
