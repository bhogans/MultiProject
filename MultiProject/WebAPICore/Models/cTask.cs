using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    public class cTask
    {
        public cTask()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }
        [BsonId]
        public Object Id { get; set; }
        public string Room { get; set; }
        public string Name { get; set; }
        public string EstimatedTime { get; set; }
        public string CompletedTime { get; set; }
        public string AddressId { get; set; }
        public string GuidePhotoUrl { get; set; }
        public string PersonId { get; set; }
        public string Type { get; set; }
        public string Completed { get; set; }
        public List<Event> cTaskEvents { get; set; } = new List<Event>();
    }
}

