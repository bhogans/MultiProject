using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
    public class Job
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string BuildingId  { get; set; }
        public DateTime ScheduledDate { get; set; }
        public List<Employee> EmployeeList { get; set; } = new List<Employee>();
        public DateTime StartDateTime { get; set; }
    }
}
