using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IJobRepository : IGenericRepository<Job>
    {
        Task<IEnumerable<Job>> GetJobsByBuildingIdAsync(int buildingId);

        //IEnumerable GetJobs();
        //Job GetJobByID(int jobId);
        //void InsertJob(Job job);
        //void DeleteJob(int jobId);
        //void UpdateJob(Job job);
        //void Save();
    }
}
