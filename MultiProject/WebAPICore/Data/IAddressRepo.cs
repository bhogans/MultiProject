using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;

namespace WebAPICore.Data
{
    public interface IAddressRepo
    {
        Task <IEnumerable<Address>> GetAll();
        Task<Address> GetById(string AddressId);
        public void Create(Address address);
        public void Update(string Id, Address address);
        public void Delete(string Id);
    }
}
