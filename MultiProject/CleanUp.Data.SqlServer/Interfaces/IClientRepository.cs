using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanUp.Entities;

namespace CleanUp.Data.SqlServer.Interfaces
{
    public interface IClientRepository
    {
        void DeleteClient(int clientId);
        IEnumerable GetClients();
        Client GetClientByID(int clientId);
        Task<Client> GetClientByIDAsync(int id);
        void InsertClient(Client client);        
        void UpdateClient(Client client);
        void Save();        
        Task SaveAsync();

    }
}
