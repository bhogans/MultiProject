using System;
using System.Collections.Generic;

#nullable disable

namespace DapperDemo.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
