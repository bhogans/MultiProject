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
using Microsoft.AspNetCore.Http;
using CleanUp.Data.SqlServer.Interfaces;
//using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using System.Web.WebPages.Html;
using Microsoft.Extensions.Logging;

namespace WebAppCore.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CandidatesController> _logger;

        public CandidatesController(
            IUnitOfWork unitOfWork, 
            ApplicationDbContext context,
            ILogger<CandidatesController> logger
            )
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _logger = logger;
        }

        private List<System.Web.Mvc.SelectListItem> getRoles()
        {
            List<System.Web.Mvc.SelectListItem> roleItems = new List<System.Web.Mvc.SelectListItem>();
            roleItems.Add(new System.Web.Mvc.SelectListItem()
            {
                Value = "1",
                Text = "CSI"
            });
            roleItems.Add(new System.Web.Mvc.SelectListItem()
            {
                Value = "2",
                Text = "PHV"
            });

            return roleItems;
        }
        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Candidates.ToListAsync());
        }

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // GET: Candidates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Age,PhoneNumber,Email")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                var item = _context.Candidates.Where(c => c.Email == candidate.Email).FirstOrDefault();
                if (item == null)
                {
                    _context.Add(candidate);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return StatusCode(409, $"User '{candidate.Email}' already exists.");
                }
            }
            return View(candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
                
            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return View(candidate);
        }

        [HttpPost]
        public async Task<IActionResult> ConvertCandidateToEmployee(int CandidateId)//, [Bind("FirstName,LastName,Age,PhoneNumber,Email")] Candidate candidate)
        {
            var candidate = await _context.Candidates.FindAsync(CandidateId);
            if (candidate == null)
            {
                return NotFound();
            }
            else
            {
                var employee = new Employee
                {
                    FirstName = candidate.FirstName,
                    LastName = candidate.LastName,
                    StartDate = DateTime.Today,
                    PhoneNumber = candidate.PhoneNumber,
                    Email = candidate.Email,
                    Age = candidate.Age
                };

                 _unitOfWork.Employees.Add(employee); // _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Employees");
            }

        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CandidateId,FirstName,LastName,Age,PhoneNumber,Email")] Candidate candidate)
        {
            if (id != candidate.CandidateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.CandidateId))
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
            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExists(int id)
        {
            return _context.Candidates.Any(e => e.CandidateId == id);
        }
    }
}
