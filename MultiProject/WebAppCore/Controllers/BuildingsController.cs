using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;
using CleanUp.Data.SqlServer.Interfaces;
using WebAppCore.ViewModels;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Logging;

namespace WebAppCore.Controllers
{
    public class BuildingsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BuildingsController> _logger;
        public BuildingsController(
            IUnitOfWork unitOfWork, 
            ApplicationDbContext context,
            ILogger<BuildingsController> logger)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _logger = logger;
        }

        // GET: Buildings
        public async Task<IActionResult> Index()
        {
            _logger.LogDebug("list of debug buildings.");
            var clientList = _context.Clients.ToList();
            SelectList clientDropDown = new SelectList(clientList, "CliendId", "LastName");
            ViewBag.clientListName = clientDropDown;

            var buildings = await _unitOfWork.Building.GetAll();// Async();
            return View(buildings);
        }

        // GET: Buildings
        [Produces("application/json")]
        public JsonResult GetBuildings()
        {
            _logger.LogInformation("NLog Debug from Main()");
            
            //var buildings = _unitOfWork.Buildings.GetAllAsync();
            //var totalRecords = buildings;
            //var jsonData = new { rows = buildings };
            //var content = Newtonsoft.Json.JsonConvert.SerializeObject(GetJsonBuildings());
            return Json(GetJsonBuildings());
        }

        [NonAction]
        public List<Building> GetJsonBuildings(){

            List<Building> model = new List<Building>();

            model.Add(new Building { Type = "Residential", Name = "John", Address1 = "1320 Sheridan Pl NE", City="Washington" });
            model.Add(new Building { Type = "Residential", Name = "Mellanie", Address1 = "1560 Somerset Pl NE", City = "Washington" });
            model.Add(new Building { Type = "Residential", Name = "Lisa", Address1 = "1660 Rittenhouse Pl NE", City = "Washington" });
            model.Add(new Building { Type = "Residential", Name = "Relly", Address1 = "1780 Arizona Pl NE", City = "Washington" });

            return model;
        }
        
        // GET: Buildings/Details/5
            public async Task<IActionResult> Details(int id)
        {
            var building = await _context.Buildings
                 .FirstOrDefaultAsync(m => m.BuildingId == id);

            var jobs = await _context.Jobs
                 .Where(x => x.BuildingId == id).ToListAsync();
            BuildingJobsVM buildingJobs = new BuildingJobsVM()
            {
                Building = building,
                JobsList = jobs
            };

            //var building = await _unitOfWork.Buildings.GetByIdAsync(id);
            //    //.Include(b => b.Client)
            //    //.FirstOrDefaultAsync(m => m.BuildingId == id);
            //if (building == null)
            //{
            //    return NotFound();
            //}

            //return View(building);
            return View(buildingJobs);
        }

        // GET: Buildings/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Clients, "ClientId", "ClientId");
            //var clientList = _context.Clients.ToList();
            //SelectList clientDropDown = new SelectList(clientList, "CliendId", "LastName");
            //ViewBag.clientListName = clientDropDown;

            //_unitOfWork.Buildings.Add()
            return View();
        }

        // POST: Buildings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BuildingId,Type,Name,Address1,Address2,City,State,Zipcode,ClientId,Latitude,Longitude")] Building building)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Building.Add(building);
                await _unitOfWork.CompleteAsync(); //.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_unitOfWork.Clients.GetClients(), "ClientId", "ClientId", building.ClientId);
            return View(building);
        }

        // GET: Buildings/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            _logger.LogInformation("testing debug");
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var building = await _unitOfWork.Building.GetById(id); //Async(id);
            if (building == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_unitOfWork.Clients.GetClients(), "ClientId", "ClientId", building.ClientId);
            return View(building);
            
        }

        // POST: Buildings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BuildingId,Type,Name,Address1,Address2,City,State,Zipcode,ClientId,Latitude,Longitude")] Building building)
        {
            if (id != building.BuildingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Building.Update(building);
                    await _unitOfWork.CompleteAsync();
                    //_context.Update(building);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!BuildingExists(building.BuildingId))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_unitOfWork.Clients.GetClients(), "ClientId", "ClientId", building.ClientId);
            return View(building);
        }

        //// POST: Buildings/Delete/5

        //private bool BuildingExists(int id)
        //{
        //    return _context.Buildings.Any(e => e.BuildingId == id);
        //}
    }
}
