using RepositoryUsingEFinMVC.DAL;
using System.Collections.Generic;

namespace RepositoryUsingEFinMVC.Repository
{
    interface IBuildingRepository
    {
        IEnumerable<Building> GetAll();
        Building GetById(int BuildingID);
        void Insert(Building building);
        void Update(Building building);
        void Delete(int BuildingID);
        void Save();
    }
}
