﻿namespace UniAPI.Models
{
    public class RegisterUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Nationality { get; set; }
        //public DateTime? BirthOfDate { get; set; }
        public int RoleId { get; set; }
    }
}