using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryUsingEFinMVC.DAL;

namespace RepositoryUsingEFinMVC.Repository
{
    interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client GetById(int ClientID);
        void Insert(Client client);
        void Update(Client client);
        void Delete(int ClientID);
        void Save();
    }
}





