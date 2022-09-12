using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventType { get; set; }
        public string EventStatus { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LocalEventDate { get; set; }
    }
}
