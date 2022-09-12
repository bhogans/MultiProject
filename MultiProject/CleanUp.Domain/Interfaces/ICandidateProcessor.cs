using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;
using CleanUp.Domain.Models;

namespace CleanUp.Domain.Interfaces
{
    public interface ICandidateProcessor
    {
        public IEnumerable<Employee> ConvertCandidateToEmployee(Candidate candidate);
        public IEnumerable<CandidateResponse> RejectCandidate(Candidate candidate, string message);
    }
}
