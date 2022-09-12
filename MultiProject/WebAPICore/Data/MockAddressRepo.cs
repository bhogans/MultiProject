using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;   
using System.Text.Json;
using System.Text.Json.Serialization;
//using MongoDB.Bson.IO;

namespace WebAPICore.Data
{
    public class MockAddressRepo : IAddressRepo
    {
        private readonly IConfiguration config;
        ILogger<MockAddressRepo> logger;
        //ISinglePackageProcessor packageProcessor;
        public MockAddressRepo(IConfiguration config, ILogger<MockAddressRepo> logger)
        {
            this.config = config;
            //this.packageProcessor = packageProcessor;
            this.logger = logger;
        }

        #region Moc Addres Data
        IList<Address> addresses = new List<Address>
        {  
            new Address 
            {
                Id = "607ce9e94c0e5250694c4352",
                Name = "Adrians Casas",
                Type = "Residential",
                Street = "139909 Gran Floral Court",
                City = "Jacksonville",
                State = "FL",
                Zipcode = "20811",
                Country = "USA",
                Notes = "This facility requires 3 people to complete the job in 2 hours. Window of opportunity is narrow to complete this job.",
                Location = new Location {
                    Type = "Point",
                    Longitude = "33.0000006",
                    Latitude = "67.0389894"
                },
                ClientId = "605b4a248c39095af4223271"
            },
            new Address 
            {
                Id = "60776847ff85943b518c341d",
                Name = "Robert - Fla Townhouse",
                Type = "Residential",
                Street = "4444 Gran Floral Ct",
                City = "Ft. Lauderdale",
                State = "FL",
                Zipcode = "32144",
                Country = "RS",
                Notes = "This facility requires 1 people to complete the job in 2 hours. Window of opportunity is narrow to complete job.",
                Location = new Location {
                    Type = "Point",
                    Longitude = "33.0000006",
                    Latitude = "67.0389894"
                },
                ClientId = "605b4a248c39095af4223271"
            },
            new Address 
            {
                Id = "605b9484ae4e1e6530554723",
                Name = "Chante - Cheverly",
                Type = "Residential",
                Street = "139909 Forest Rd",
                City = "Cheverly",
                State = "MD",
                Zipcode = "32224",
                Notes = "This facility requires 1 people to complete the job in 2 hours. Window of opportunity is narrow to complete job.",
                Location = new Location {
                    Type = "Point",
                    Longitude = "56.9594756",
                    Latitude = "-33.0373694"
                },
                ClientId = "605b4a248c39095af4223271",
                Country = null
            },
            new Address 
            {
                Id = "605b5ad5ae4e1e65305534b6",
                Name = "Leslies House",
                Type = "Residential",
                Street = "139909 Gran Floral Court",
                City = "Jacksonville",
                State = "FL",
                Zipcode = "32224",
                Notes = "This facility requires 3 people to complete the job in 2 hours. Window of opportunity is narrow to complete job.",
                Location = new Location {
                    Type = "Point",
                    Longitude = "56.9594756",
                    Latitude = "-33.0373694"
                },
                ClientId = "605b4a248c39095af4223271",
                Country = "USA"
            },
            new Address 
            {
                Id = "804ee7b35a2e31de2250c2ab",
                Name = "John - Residence",
                Type = "Residential",
                Street = "50 Upshur St NW",
                City = "Washington",
                State = "DC",
                Zipcode = null,
                Notes = "This house requires 2 cleaners to complete the job in 1.5 hours.",
                Location = new Location {
                    Type = "Point",
                    Longitude = "56.9594756",
                    Latitude = "-33.0373694"
                },
                ClientId = "604edf4a8a63225c048e16e5",
                Country = "USA"
            }

        };
        #endregion
        public void Delete(string Id)
        {
            //addresses.Remove(Id).ToList().RemoveAll(a => a.Id = Id);
            var getAddr = addresses.FirstOrDefault(a => a.Id == Id);
            addresses.Remove(getAddr);
        }

        public async Task<IEnumerable<Address>> GetAll()
        {
            var addrs = await Task.FromResult(addresses);//.ToList();
            return addrs;
        }

        public async Task<Address> GetById(string AddressID)
        {
            ////string myJsonString = "{'_id' : '607ce9e94c0e5250694c4352','Name' : 'Adrians Casas','Type' : 'Residential','Street' : '139909 Gran Floral Court','City' : 'Jacksonville','State' : 'FL','Zipcode' : '20811','Country' : 'USA','Notes' : 'This facility requires 3 people to complete the job in 2 hours. Window of opportunity is narrow to complete this job.','Location' : {'Type' : 'Point','Longitude' : '33.0000006','Latitude' : '67.0389894'},'ClientId' : '605b4a248c39095af4223271'}";
            
            ////this one works
            //string myJsonString2 = "{\"_id\" : \"607ce9e94c0e5250694c4352\",\"Name\" : \"Adrians Casas\",\"Type\" : \"Residential\",\"Street\" : \"139909 Gran Floral Court\",\"City\" : \"Jacksonville\",\"State\" : \"FL\",\"Zipcode\" : \"20811\",\"Country\" : \"USA\",\"Notes\" : \"This facility requires 3 people to complete the job in 2 hours. Window of opportunity is narrow to complete this job.\",\"Location\" : {\"Type\" : \"Point\",\"Longitude\" : \"33.0000006\",\"Latitude\" : \"67.0389894\"},\"ClientId\" : \"605b4a248c39095af4223271\"}";
            ////Address add = JsonSerializer.Deserialize<Address>(myJsonString2);
            
            var commandItem =  await Task.FromResult(addresses.FirstOrDefault(x => x.Id == AddressID));
            //if(commandItem != null)
            //{
                return commandItem;
           // }
           //return new HttpNotFoundResult();
        }

        //public void Insert(Address address)
        //{
        //    throw new NotImplementedException();
        //}

        public void Create(Address address)
        {
            try
            {
                addresses.Add(address);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
        }

        public void Update(string Id, Address address)
        {
            try
            {
                addresses.Where(a => a.Id == address.Id).ToList().ForEach(a => a.Id = address.Id);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
        }
    }
}
