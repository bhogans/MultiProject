using System;
using System.Collections.Generic;

#nullable disable

namespace CleanUp.Entities
{
    public partial class JobTask
    {
        public int JobTaskId { get; set; }
        public int? EmployeeId { get; set; }
        public int CTaskId { get; set; }
        public int JobId { get; set; }
        public DateTime? DateTimeAssigned { get; set; }
        public double? CompletionTime { get; set; }
        public bool? Completed { get; set; }
        public string Notes { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }

        public virtual Job Job { get; set; }
    }
}
