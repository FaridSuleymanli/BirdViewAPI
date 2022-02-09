using BirdViewAPI.Entities.DTOs.VisaCountryDTO;
using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaTypeDTOs
{
    public class VisaTypeForGetDTO
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<VisaCountryGetDTO> VisaCountries { get; set; }
    }
}
