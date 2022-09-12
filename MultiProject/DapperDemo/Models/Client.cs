using System;
using System.Collections.Generic;

#nullable disable

namespace DapperDemo.Models
{
    public partial class Client
    {
        public Client()
        {
            Buildings = new HashSet<Building>();
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}
