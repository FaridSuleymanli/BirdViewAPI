using BirdViewAPI.Entities.DTOs.CountryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaTypeDTOs
{
    public class VisaTypeForConsGetDTO
    {
        public string Title { get; set; }
        public virtual ICollection<CountryForGetDTO> Countries { get; set; }
    }
}
