﻿using System;
using System.Collections.Generic;
namespace HomeServicesPlatform.Bussiness.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        

        public User(int id, string name, string address, string city, string phoneNumber, string email, string password,
            string role)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
            
        }
    }
}
