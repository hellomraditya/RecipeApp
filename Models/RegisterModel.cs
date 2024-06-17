﻿using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage="username is required")]
        public string userName { get; set; }

        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="invalid email address")]
        
        public string email {  get; set; }

        [Required(ErrorMessage = "password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain each of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string password { get; set; }

    }
}