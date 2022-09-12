using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Dtos
{
    public class AddressReadDto
    {
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
        public LocationReadDto Location { get; set; }

        public string ClientId { get; set; }

    }
}
