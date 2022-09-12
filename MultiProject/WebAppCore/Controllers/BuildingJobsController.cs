using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.ViewModels;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WebAppCore.Controllers
{
    public class BuildingJobsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BuildingJobsController> _logger;

        public BuildingJobsController(
            ApplicationDbContext context,
            ILogger<BuildingJobsController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> Index(int id)
        {
            var building = await _context.Buildings
                 .FirstOrDefaultAsync(m => m.BuildingId == id);

            var jobs = await _context.Jobs
                 .Where(x => x.BuildingId == id).ToListAsync();
            //ApplicationDbContext acontext = new ApplicationDbContext();
            //List<BuildingJobsVM> BJList = new List<BuildingJobsVM>();

            //var bjlist = (from Build in acontext.Buildings
            //             join Jbs in acontext.Jobs on Build.BuildingId equals Jbs.BuildingId
            //             selectnew { Build.BuildingId }).ToList();//, Build.Name, Jbs.JobId;
            BuildingJobsVM buildingJobs = new BuildingJobsVM()
            {
                Building = building,
                JobsList = jobs
            };

            return View(buildingJobs);
        }
    }
}
