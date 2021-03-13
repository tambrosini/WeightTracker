using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WeightTracker.ViewModels.Authentication
{
    public class RegistrationRequest
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        //Email is going to be used as the username to require
        //a unique email for each user
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}