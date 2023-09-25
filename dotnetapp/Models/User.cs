﻿// Models/User.cs
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{

    public class User
    {
        public int Id { get; set; }
        // Write your User class here...
        
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}