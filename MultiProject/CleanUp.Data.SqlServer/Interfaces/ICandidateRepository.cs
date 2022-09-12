using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        void ConvertCandidateToEmployee(Candidate newEmployee);

    }
}
