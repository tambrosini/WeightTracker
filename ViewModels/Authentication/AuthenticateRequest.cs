﻿using System.ComponentModel.DataAnnotations;

namespace WeightTracker.ViewModels.Authentication
{
    public class AuthenticateRequest
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}