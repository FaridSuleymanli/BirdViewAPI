using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class CountryService
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int ConsultationTypeId { get; set; }
        public ConsultationType ConsultationType { get; set; }
    }
}
