using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanUp.Entities
{
    public partial class Building
    {
        public Building()
        {
            BuildingLayouts = new HashSet<BuildingLayout>();
            Jobs = new HashSet<Job>();
            CTasks = new HashSet<CTask>();
        }

        public int BuildingId { get; set; }
        public string Type { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address1 { get; set; }
        [MaxLength(255)]
        public string Address2 { get; set; }
        [Required]
        [MaxLength(75)]
        public string City { get; set; }
        [Required]
        [MaxLength(3)]
        public string State { get; set; }
        [Required]
        [MaxLength(5)]
        public string Zipcode { get; set; }
        public int ClientId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<BuildingLayout> BuildingLayouts { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<CTask> CTasks { get; set; }
    }
}
