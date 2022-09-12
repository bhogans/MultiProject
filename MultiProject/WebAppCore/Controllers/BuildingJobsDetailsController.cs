using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCore.DAL;
using WebAppCore.ViewModels;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;
using CleanUp.Data.SqlServer.Interfaces;

namespace WebAppCore.Controllers
{
    public class BuildingJobsDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BuildingJobsDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        //public async Task<IActionResult> Index(int? buildingId)
        public IActionResult Index(int id)
        {
            List<CleanUp.Entities.Job> BuildingJobs = new();

            var bldg = _context.Buildings
                .Include(j => j.Jobs)
                .FirstOrDefault(s => s.BuildingId == id);
            var jobslist = bldg.Jobs;

            foreach (var item in jobslist)

            {
                CleanUp.Entities.Job bldgJob = new ()
                {
                    //bldgJob = new BuildingJobsVM(); = item.Name;
                    JobId = item.JobId,
                    Status = item.Status,
                    BuildingId = item.BuildingId,
                    Start = item.Start,
                    Building = item.Building,
                    Finish = item.Finish,
                    JobType = item.JobType
                }; // ViewModel

                BuildingJobs.Add(bldgJob);

            }

            BuildingJobsVM objBJVM = new()
            {
                //Building = bldg,

                //Jobs = BuildingJobs

            };

            //var jobslist = _context.Jobs
            //    //.Include(b => b.Building)
            //    .Where(m => m.BuildingId == id)
            //    //.OrderByDescending(s => s.Start)
            //    .ToList();

            //BuildingJobsVM objBJVM = new BuildingJobsVM
            //{
            //    BuildingId = id,
            //    Name = bldg.Name,
            //    Address1 = bldg.Address1,
            //    BType = bldg.Type

            //};

            //foreach (var item in jobslist)

            //{

            //    Job bldgJob = new Job(); // ViewModel

            //    //bldgJob = new BuildingJobsVM(); = item.Name;

            //    bldgJob.JobId = item.JobId;

            //    bldgJob.Status = item.Status;
            //    bldgJob.BuildingId = item.BuildingId;
            //    bldgJob.Start = item.Start;
            //    bldgJob.Building = item.Building;
            //    bldgJob.Finish = item.Finish;
            //    bldgJob.JobType = item.JobType;

            //    objBJVM.Jobs.Add(bldgJob);

            //}
            if (jobslist == null)
            {
                return NotFound();
            }

            return View(objBJVM);
        }
    }
}
