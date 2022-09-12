using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CleanUp.Entities
{
    public partial class Client
    {
        public Client()
        {
            Buildings = new HashSet<Building>();
        }

        public int ClientId { get; set; }
        [Required(ErrorMessage ="The First Name is required")]
        [MaxLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "The Last Name is required")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [DisplayName("Nick Name")]
        public string NickName { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(255)]
        public string Email { get; set; }
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Birth Date")]
        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}
