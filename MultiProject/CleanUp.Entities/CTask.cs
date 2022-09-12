using System;
using System.Collections.Generic;

#nullable disable

namespace CleanUp.Entities
{
    public partial class CTask
    {
        public int CTaskId { get; set; }
        public string Room { get; set; }
        public string TaskName { get; set; }
        public double EstimatedTime { get; set; }
        public double? CompletionTime { get; set; }
        public int PropId { get; set; }
        public string GuidePhotoUrl { get; set; }
        public int? TemplateId { get; set; }
        public string TaskType { get; set; }
        public int BuildingId { get; set; }
        public bool IsComplete { get; set; }
        public virtual Building Building { get; set; }
    }
}
