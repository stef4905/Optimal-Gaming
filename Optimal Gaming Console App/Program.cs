using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;

namespace Optimal_Gaming_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDB db = new MongoDB();
            db.GenerateConnection();
            Console.ReadLine();
            db.InsertIntoDatabase();
            db.PrintCollection();
            ObjectId id = new ObjectId(Console.ReadLine());
            db.Remove(id);
            db.PrintCollection();
            Console.ReadLine();
        }
    }
}
