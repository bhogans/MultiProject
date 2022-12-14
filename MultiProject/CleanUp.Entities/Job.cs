using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CleanUp.Entities
{
    public partial class Job
    {
        public Job()
        {
            JobTasks = new HashSet<JobTask>();
        }

        public int JobId { get; set; }
        public string JobType { get; set; }
        public int BuildingId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        [Required]
        public string Status { get; set; }
        public string Notes { get; set; }
        public virtual Building Building { get; set; }
        public virtual ICollection<JobTask> JobTasks { get; set; }
    }
}
