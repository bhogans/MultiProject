using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace CleanUp.Entities
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(255)]
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
