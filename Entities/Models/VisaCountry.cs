using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class VisaCountry
    {
        public int Id { get; set; }
        public int VisaTypeId { get; set; }
        public VisaType VisaType { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
