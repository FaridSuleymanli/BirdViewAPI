using BirdViewAPI.Entities.DTOs.CountryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaCountryDTO
{
    public class VisaCountryCreateDTO
    {
        public CountryNameCreateDTO Country { get; set; }
    }
}
