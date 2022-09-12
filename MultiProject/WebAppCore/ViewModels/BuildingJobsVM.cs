using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace WebAppCore.ViewModels
{
    public class BuildingJobsVM
    {
        public Building Building { get; set; }
        //public int BuildingId { get; set; }
        //public string Name { get; set; }
        ////Job
        //public int JobId { get; set; }
        //public string JobType { get; set; }
        //public string Status { get; set; }

        public List <CleanUp.Entities.Job> JobsList { get; set; }
    }
}
