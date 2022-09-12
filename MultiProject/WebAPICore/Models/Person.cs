using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    [BsonDiscriminator(RootClass = true)]
    //[BsonKnownTypes(typeof(Employee))]
    public class Person
    {
        public Person()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
            //Contacts = new List<Contacts>();
        }

        [BsonId]
        public string Id { get; set; }
        [BsonRequired]
        public string name { get; set; }
        [BsonRequired]
        public DateTime dob { get; set; }
        public string notes { get; set; }
        public string referredBy { get; set; }
        public string status { get; set; }
        //public List<Address> Address { get; set; }
        //public List<Contacts> Contacts { get; set; }
    }
}
