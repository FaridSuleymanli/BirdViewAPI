using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.CountryDTOs
{
    public class CountryForGetDTO
    {
        public string Name { get; set; }
        public string Flag { get; set; }
        public string Image { get; set; }
        public int VisaTypeId { get; set; }
    }
}
