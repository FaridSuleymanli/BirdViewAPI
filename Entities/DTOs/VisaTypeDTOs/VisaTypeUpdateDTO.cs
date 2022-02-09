using BirdViewAPI.Entities.DTOs.VisaCountryDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaTypeDTOs
{
    public class VisaTypeUpdateDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }
        public List<int> CountryIds { get; set; }
    }
}
