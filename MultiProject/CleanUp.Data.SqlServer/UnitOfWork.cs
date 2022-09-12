using CleanUp.Data.SqlServer.Interfaces;
using CleanUp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Data.SqlServer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;

        public IBuildingRepository Building { get; private set; }
        public IClientRepository Clients { get; private set; }
        public ICandidateRepository Candidates { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IEventRepository Events { get; private set; }
        public IJobRepository Jobs { get; private set; }
        public IJobTaskRepository JobTasks { get; private set; }

        public UnitOfWork(ApplicationDbContext context)//, ILoggerFactory loggerFactory)
        {
            _context = context;
            //_logger = loggerFactory.CreateLogger("logs");
            
            Building = new BuildingRepository(context);//, _logger);
            Clients = new ClientRepository(context);
            //Candidates = new CandidateRepository(context, Employees);
            Candidates = new CandidateRepository(context);
            //CTasks = new CTaskRepository(context);
            Employees = new EmployeeRepository(context);
            //Events = new EventRepository(context);
            Jobs = new JobRepository(context);
            //JobTasks = new JobTaskRepository(context);

        }

    public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
