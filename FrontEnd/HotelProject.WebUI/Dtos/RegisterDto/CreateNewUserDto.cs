﻿namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Username { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
