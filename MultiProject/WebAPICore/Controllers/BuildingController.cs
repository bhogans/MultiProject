using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanUp.Data.SqlServer;
using CleanUp.Entities;
using CleanUp.Data.SqlServer.Interfaces;
using Microsoft.Extensions.Logging;
using WebAPICore.Data;
using WebAPICore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebAPICore.Controllers
{
    [ApiController]
    [Route("api/building")] //use [controller] if dynamic
    public class BuildingController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BuildingController> _logger;

        public BuildingController(
            IUnitOfWork unitOfWork,
            ApplicationDbContext context,
            ILogger<BuildingController> logger
        )
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Building>> Get()
        {
            return await _unitOfWork.Building.GetAll();
        }

        //api/[controller]/{id}
        // GET: BuildingController/Get/5
        [HttpGet("{id}")]
        public async Task<Building> GetById(int id)
        {
            return await _unitOfWork.Building.GetById(id); 
        }

        //[HttpPost]
        //public async Task Create(Building building)
        //{
        //        _unitOfWork.Building.Add(building);
        //        await _unitOfWork.CompleteAsync();
        //}

        [HttpPost]
        public async Task<ActionResult<Building>> Create(Building building)
        {
            _unitOfWork.Building.Add(building);
            await _unitOfWork.CompleteAsync();
            _logger.LogInformation("Added new building {bldg}", building.Name);

            return CreatedAtAction(nameof(GetById), new { id = building.BuildingId }, building);
        }


        //[Route("api/building/Edit")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, Building building)
        {
            if (id != building.BuildingId)
            {
                return BadRequest();
            }
            try
            {
                _unitOfWork.Building.Update(building);
                await _unitOfWork.CompleteAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }

        // DELETE: api/Buildings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var building = await _unitOfWork.Building.GetById(id);
            if (building == null)
            {
                return NotFound();
            }

            _unitOfWork.Building.Remove(building);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        private bool BuildingExists(int id) =>
            _context.Buildings.Any(e => e.BuildingId == id);
    }
}
