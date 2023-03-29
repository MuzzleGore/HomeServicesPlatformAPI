using System;
using System.Collections.Generic;
using System.Linq;
using HomeServicesPlatform.Bussiness.Enums;

namespace HomeServicesPlatform.Bussiness.Entities
{
    public class DryCleaners
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public Dictionary<ClothingPieces, double> ClothingPieces { get; set; }
        public string Owner { get; set; }

        public DryCleaners(int id, string name, string address, string city, string phoneNumber,
            Dictionary<ClothingPieces,  double> clothingPieces, string owner)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            PhoneNumber = phoneNumber;
            ClothingPieces = clothingPieces;
            Owner = owner;
        }

        public DryCleaners()
        {
        }

    }
}
