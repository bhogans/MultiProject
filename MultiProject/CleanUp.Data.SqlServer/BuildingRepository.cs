using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Data.SqlServer.Interfaces;
using CleanUp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Web;

namespace CleanUp.Data.SqlServer
{
    public class BuildingRepository : GenericRepository<Building>, IBuildingRepository 
    {
        public BuildingRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Building>> GetBuildingsByClientIdAsync(int clientId)
        {
            return await _context.Buildings.OrderByDescending(d => d.ClientId == clientId).ToListAsync();
        }


        //public void DeleteBuilding(int buildingId)
        //{
        //    Building building = _context.Buildings.Find(buildingId);
        //    _context.Buildings.Remove(building);
        //}

        //public Building GetBuildingByID(int buildingId)
        //{
        //    Building building = _context.Buildings.Find(buildingId);
        //    return building;
        //}

        //public IEnumerable GetBuildings()
        //{
        //    return buildingEntity.AsEnumerable();
        //}

        //public void InsertBuilding(Building building)
        //{
        //    _context.Buildings.Add(building);
        //}

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}

        //public void UpdateBuilding(Building building)
        //{
        //    _context.Entry(building).State = EntityState.Modified;
        //}
    }
}
