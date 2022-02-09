using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.CountryServiceDTO
{
    public class CountryServicePostDTO
    {
        public int CountryId { get; set; }
        public int ConsultationTypeId { get; set; }
    }
}
