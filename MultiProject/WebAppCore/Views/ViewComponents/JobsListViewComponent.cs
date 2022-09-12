using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;

namespace WebAppCore.Views.ViewComponents
{
    [ViewComponent(Name = "JobsList")]
    public class JobsListViewComponent : ViewComponent
    {
        //private readonly CleanUp3Context _context;
        private readonly ApplicationDbContext _context;

        public JobsListViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async System.Threading.Tasks.Task<IViewComponentResult> InvokeAsync(int Buildingid)
        {
            var items = await GetItemsAsync(Buildingid);
            return View(items);

            //var jobs = await _context.Jobs
            //    .Include(j => j.Building)
            //    .FirstOrDefaultAsync(m => m.BuildingId == Buildingid);
            //if (jobs == null)
            //{
            //    return View();
            //}

            //return View("Index", jobs);
        }

        private Task<List<CleanUp.Entities.Job>> GetItemsAsync(int buildingid)
        {
            return _context.Jobs.Where(x => x.BuildingId == buildingid).ToListAsync();
        }

        //private System.Threading.Tasks.Task GetJobsAsync(int buildingid)
        //{
        //    throw new NotImplementedException();
        //}

    //    private System.Threading.Tasks.Task<List<Job>> GetItemsAsync(int Buildingid)
    //    {
    //        return _context.Where(x => x.IsDone == isDone &&
    //                             x.Priority <= maxPriority).ToListAsync();
    //}

}
}
