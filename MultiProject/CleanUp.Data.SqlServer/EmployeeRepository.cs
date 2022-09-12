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
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
