using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    [Serializable]
    public class Location
    {
        public string Type { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
