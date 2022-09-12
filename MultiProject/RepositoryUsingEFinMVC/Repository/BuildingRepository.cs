using RepositoryUsingEFinMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryUsingEFinMVC.Repository
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly CleanEntities1 _context;

        public BuildingRepository()
        {
            _context = new CleanEntities1();
        }
        public BuildingRepository(CleanEntities1 context)
        {
            _context = context;
        }
        public void Delete(int BuildingID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Building> GetAll()
        {
            return _context.Buildings.ToList();
        }

        public Building GetById(int BuildingID)
        {
            return _context.Buildings.Find(BuildingID);
        }

        public void Insert(Building building)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Building building)
        {
            throw new NotImplementedException();
        }
    }
}