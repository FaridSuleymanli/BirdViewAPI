using BirdViewAPI.Entities.DTOs.CountryDTOs;
using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaCountryDTO
{
    public class VisaCountryGetDTO
    {
        public CountryForGetDTO Country { get; set; }
    }
}
