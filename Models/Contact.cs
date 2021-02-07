using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Week3_Review.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage="Pls enter first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pls enter last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pls enter phone num")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Pls enter email address")]

        public string Email { get; set; }

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }

        public int CategoryId { get; set; }

        [Range(1,1000,ErrorMessage= "Please select a category")]
        public Category Category { get; set; }

        public string Slug => FirstName?.Replace(" ", "-").ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
