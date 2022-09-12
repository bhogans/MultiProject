using System;
using System.Collections.Generic;

#nullable disable

namespace CleanUp.Entities
{
    public partial class Event
    {
        public int EventId { get; set; }
        public int? JobId { get; set; }
        public int? CTaskId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public DateTime EventDate { get; set; }
    }
}
