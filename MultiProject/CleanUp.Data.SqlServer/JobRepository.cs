using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Data.SqlServer.Interfaces;
using CleanUp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanUp.Data.SqlServer
{
    class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Job>> GetJobsByBuildingIdAsync(int buildingId)
        {
            return await _context.Jobs.OrderByDescending(d => d.BuildingId == buildingId).ToListAsync();
        }
    }
}
