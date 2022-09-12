using System;
using System.Collections.Generic;

#nullable disable

namespace DapperDemo.Models
{
    public partial class Building
    {
        public Building()
        {
            BuildingLayouts = new HashSet<BuildingLayout>();
            Jobs = new HashSet<Job>();
            Tasks = new HashSet<Task>();
        }

        public int BuildingId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int ClientId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<BuildingLayout> BuildingLayouts { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
