using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models
{
    public class RepairOrder
    {
        public int ROId { get; set; }
        public int RONumber { get; set; }
        public int? JobId { get; set; }
        public int? CTaskId { get; set; }
        public string Name { get; set; }
        public string ObjectToRepair { get; set; }
        public string Notes { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
