using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaTypeDTOs
{
    public class VisaTypeForCreateDTO
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }
        public List<int> CountryIds { get; set; }
    }
}
