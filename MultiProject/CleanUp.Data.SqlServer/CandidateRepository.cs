using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;
using CleanUp.Data.SqlServer;
using CleanUp.Data.SqlServer.Interfaces;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace CleanUp.Data.SqlServer
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        private readonly IEmployeeRepository _employeeRepository;// { get; private set; }

        public CandidateRepository(ApplicationDbContext context) : base(context) //, IEmployeeRepository employeeRespository
        {
           // _employeeRepository = employeeRespository;
        }

        public void ConvertCandidateToEmployee(Candidate newEmployee)
        {
            //var emp = new Employee{
            //    FirstName = newEmployee.FirstName,
            //    LastName = newEmployee.LastName,
            //    PhoneNumber = newEmployee.PhoneNumber,
            //    Email = newEmployee.Email
            //};

            //_employeeRepository.Add(emp);

           
        }
        //public void Add(T entity)
        //{
        //    _context.Set<T>().Add(entity);
        //}

        //private readonly ApplicationDbContext _context;
        //private DbSet<Candidate> candidateEntity;
        //public CandidateRepository()
        //{
        //    _context = new ApplicationDbContext();
        //}

        //public CandidateRepository(ApplicationDbContext context)
        //{
        //    _context = context;
        //    candidateEntity = context.Set<Candidate>();
        //}

        //public IEnumerable GetCandidate()
        //{
        //    throw new NotImplementedException();
        //}

        //public Candidate GetCandidateByID(int candidateId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void InsertCandidate(Candidate candidate)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteCandidate(int candidateId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateCandidate(Candidate candidate)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}
    }

}



