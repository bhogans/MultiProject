using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    interface IBuildingLayoutRepository
    {
        IEnumerable GetBuildingLayouts();
        BuildingLayout GetBuildingLayoutByID(int buildingLayoutId);
        void InsertBuildingLayout(BuildingLayout buildingLayout);
        void DeleteBuildingLayout(int buildingLayoutId);
        void UpdateBuildingLayout(BuildingLayout buildingLayout);
        void Save();
    }
}
