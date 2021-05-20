using System;
using System.ComponentModel.DataAnnotations;

namespace PenTrade.ViewModels
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password must have minimum length of 5 characters")]
        public string Password { get; set; }


    }
}
