using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppCore.DAL;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;
using Microsoft.Extensions.Logging;

namespace WebAppCore.Controllers
{
    public class JobsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<JobsController> _logger;

        public JobsController(
            ApplicationDbContext context,
            ILogger<JobsController> logger
            )
        {
            _context = context;
            _logger = logger;
        }

        public ActionResult LoadAddJobPopup(int id)
        {
            try
            {
                ViewBag.BuildingId = id;
                return PartialView("_AddJob");
            }
            catch (Exception ex)
            {
                return PartialView("_AddJob");
            }
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            var appContext = _context.Jobs.Include(j => j.Building);
            return View(await appContext.ToListAsync());
        }

        // GET: Jobs by BuildingId
        //public JsonResult GetJobListByBuildingId(int id)
        //{
        //    try
        //    {
        //        var job = _context.Jobs
        //        .Where(m => m.BuildingId == id).ToList();

        //        return Json(job, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(null, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //public async Task<IActionResult> GetJobListByBuildingId(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var job = await _context.Jobs
        //        //.Include(j => j.Building)
        //        //.FirstOrDefaultAsync(m => m.JobId == id);
        //        .Where(m => m.BuildingId == id).ToListAsync();
        //    if (job == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(job);
        //}
        public IActionResult GetJobListByBuildingId(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = _context.Jobs
                .Where(m => m.BuildingId == id).ToList();
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .Include(j => j.Building)
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("JobId,JobType,BuildingId,Start,Finish,Status")] Job job)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Buildings", new {id = job.BuildingId });

            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Jobs/Create
        public IActionResult Create()
        {
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingId");
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobId,JobType,BuildingId,Start,Finish,Status")] Job job)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingId", job.BuildingId);
            return View(job);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingId", job.BuildingId);
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobId,JobType,BuildingId,Start,Finish,Status")] Job job)
        {
            if (id != job.JobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.JobId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "BuildingId", "BuildingId", job.BuildingId);
            return View(job);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .Include(j => j.Building)
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobExists(int id)
        {
            return _context.Jobs.Any(e => e.JobId == id);
        }
    }
}
