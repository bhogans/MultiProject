using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;
using CleanUp.Data.SqlServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IBuildingRepository : IGenericRepository<Building>
    {
        Task<IEnumerable<Building>> GetBuildingsByClientIdAsync(int clientId);

    }
//{
//        IEnumerable GetBuildings();
//        Building GetBuildingByID(int buildingId);
//        void InsertBuilding(Building building);
//        void DeleteBuilding(int buildingId);
//        void UpdateBuilding(Building building);
//        void Save();
//    }
}
