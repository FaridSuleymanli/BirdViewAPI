using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.CountryDTOs
{
    public class CountryForGetAdminDTO
    {
        public string Name { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public int PhoneCode { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Flag { get; set; }
        public string Image { get; set; }
    }
}
