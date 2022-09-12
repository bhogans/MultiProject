using System;
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
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Client> clientEntity;
        public ClientRepository()
        {
            _context = new ApplicationDbContext();
        }
        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
            clientEntity = context.Set<Client>();
        }
        public void DeleteClient(int clientId)
        {
            Client client = _context.Clients.Find(clientId);
            _context.Clients.Remove(client);
        }

        public Client GetClientByID(int clientId)
        {
            Client client = _context.Clients.Find(clientId);
            return client;
        }

        public async Task<Client> GetClientByIDAsync(int clientId)
        {
            return await _context.Clients.FindAsync(clientId);
                //.DefaultIfEmpty(new Owner())
                //.SingleAsync();
        }

        public IEnumerable GetClients()
        {
            //_context.Clients.
            return clientEntity.AsEnumerable();
        }

        public void InsertClient(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateClient(Client client)
        {
             _context.Entry(client).State = EntityState.Modified;          
        }
    }
}
