using System;
using System.Collections.Generic;

#nullable disable

namespace DapperDemo.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string Type { get; set; }
        public int? Longitude { get; set; }
        public int? Latitude { get; set; }
    }
}
