using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBuildingRepository Building { get; }
        IClientRepository Clients { get; }
        ICandidateRepository Candidates { get; }
        IEmployeeRepository Employees { get; }
        IEventRepository Events { get; }
        IJobRepository Jobs { get; }
        IJobTaskRepository JobTasks { get; }
        Task CompleteAsync();
    }
}
