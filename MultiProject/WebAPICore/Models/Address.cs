using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace WebAPICore.Models
{
    [Serializable]
    public class Address
    {
        public Address()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
            //Location = new Location();
        }

        [BsonId]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        //[BsonElement("CC")]
        public string Country { get; set; }
        public string Notes { get; set; }
        public Location Location { get; set; }

        public string ClientId { get; set; }
    }

    enum AddressType
    {
        Residential,
        Commercial
    }
}
