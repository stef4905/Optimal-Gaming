using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Console_App
{
    public class Toy
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }

        public Toy(string name)
        {
            this.name = name;
        }

    }
}
