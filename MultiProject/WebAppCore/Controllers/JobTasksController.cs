using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanUp.Data.SqlServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CleanUp.Entities;
using Microsoft.Extensions.Logging;

namespace WebAppCore.Controllers
{
    public class JobTasksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<JobTasksController> _logger;

        public JobTasksController(ApplicationDbContext context, ILogger<JobTasksController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: JobTasks
        public async Task<IActionResult> Index()
        {
            var cleanUp3Context = _context.JobTasks.Include(j => j.Job);
            return View(await cleanUp3Context.ToListAsync());
        }

        // GET: JobTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTask = await _context.JobTasks
                .Include(j => j.Job)
                .FirstOrDefaultAsync(m => m.JobTaskId == id);
            if (jobTask == null)
            {
                return NotFound();
            }

            return View(jobTask);
        }

        // GET: JobTasks/Create
        public IActionResult Create()
        {
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId");
            return View();
        }

        // POST: JobTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobTaskId,EmployeeId,TaskId,JobId,DateTimeAssigned,CompletionTime,Completed,Notes,Start,Finish")] JobTask jobTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId", jobTask.JobId);
            return View(jobTask);
        }

        // GET: JobTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTask = await _context.JobTasks.FindAsync(id);
            if (jobTask == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId", jobTask.JobId);
            return View(jobTask);
        }

        // POST: JobTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobTaskId,EmployeeId,TaskId,JobId,DateTimeAssigned,CompletionTime,Completed,Notes,Start,Finish")] JobTask jobTask)
        {
            if (id != jobTask.JobTaskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobTaskExists(jobTask.JobTaskId))
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
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId", jobTask.JobId);
            return View(jobTask);
        }

        // GET: JobTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTask = await _context.JobTasks
                .Include(j => j.Job)
                .FirstOrDefaultAsync(m => m.JobTaskId == id);
            if (jobTask == null)
            {
                return NotFound();
            }

            return View(jobTask);
        }

        // POST: JobTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobTask = await _context.JobTasks.FindAsync(id);
            _context.JobTasks.Remove(jobTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobTaskExists(int id)
        {
            return _context.JobTasks.Any(e => e.JobTaskId == id);
        }
    }
}
