using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositoryUsingEFinMVC.DAL;

namespace RepositoryUsingEFinMVC.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly CleanEntities1 _context;

        public ClientRepository()
        {
            _context = new CleanEntities1();
        }
        public ClientRepository(CleanEntities1 context)
        {
            _context = context;
        }
        public void Delete(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client GetById(int EmployeeID)
        {
            return _context.Clients.Find(EmployeeID);
        }

        public void Insert(Client employee)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Client employee)
        {
            throw new NotImplementedException();
        }
    }
}