using BirdViewAPI.Entities.DTOs.CountryDTOs;
using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.EntryProgramme
{
    public class EntryProgrammeForGetDTO
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public CountryForGetDTO Country { get; set; }
    }
}
